﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using FinancialPlanner.Common;
using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.EmailManager;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.QuarterlyReview
{
    public partial class frmQuartelyReviewReportParams : Form
    {
        private const string CLIENTS_WITHPRIMARYCONTACT_GETALL = "ClientContact/ClientWithPrimaryContact?dateTime={0}";
        const string GET_All_FAMAILYMEMBER_API = "FamilyMember/GetAll?clientId={0}";
        const string GET_SPOUSE_PERSONAL_API = "ClientSpouse/GetById?id={0}";
        private DataTable _dtClient;
        List<int> selectedRowsIndex = new List<int>();
        public frmQuartelyReviewReportParams()
        {
            InitializeComponent();
        }

        private void frmQuartelyReviewReportParams_Load(object sender, EventArgs e)
        {
            //fillClients();
        }

        private async void fillClients()
        {
            //IList<TaskCard> tasks = await Task.Run(() => taskCardService.GetTasks(this.taskView));

            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl + "/" + string.Format(CLIENTS_WITHPRIMARYCONTACT_GETALL, dtQuaterlyReview.DateTime.ToShortDateString());

            RestAPIExecutor restApiExecutor = new RestAPIExecutor();

            var restResult =  await Task.Run(() => restApiExecutor.Execute<List<ClientPrimaryContact>>(apiurl, null, "GET"));

            if (jsonSerialization.IsValidJson(restResult.ToString()))
            {
                var clientColleection = jsonSerialization.DeserializeFromString<List<ClientPrimaryContact>>(restResult.ToString());
                _dtClient = ListtoDataTable.ToDataTable(clientColleection);
                fillClientGridView(_dtClient);
            }
            else
            {
                XtraMessageBox.Show(restResult.ToString(), "Error");
            }

         
        }

        private void fillClientGridView(DataTable dtClient)
        {
            _dtClient.Columns.Add("IsSelected", Type.GetType("System.Boolean"));
            _dtClient.Columns.Add("Status");
            gridControlClients.DataSource = _dtClient;
            gridControlClients.RefreshDataSource();
           
            gridViewClient.Columns["IsSelected"].VisibleIndex = 0;
            gridViewClient.Columns["IsSelected"].Caption = "";
            gridViewClient.Columns["IsSelected"].Width = 40;
            gridViewClient.Columns["Id"].Width  =60;           
            gridViewClient.Columns["Name"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;            
        }

        private void btnSendQuarterlyReview_Click(object sender, EventArgs e)
        {
            sendReviewRport();
        }

        private void sendReviewRport()
        {

           foreach(int index in selectedRowsIndex)
           {
                string emailId = gridViewClient.GetRowCellValue(index, "PrimaryEmail").ToString();
                if (!string.IsNullOrEmpty(emailId))
                {
                    try
                    {
                        int clientId = int.Parse(gridViewClient.GetRowCellValue(index, "Id").ToString());
                        string clientName = gridViewClient.GetRowCellValue(index, "Name").ToString();
                        ClientSpouse clientSpouse = getSpousePersonalInfo(clientId);
                        List<string> members = new List<string>();
                        members.Add(clientName);
                        if (!string.IsNullOrEmpty(clientSpouse.Name))
                            members.Add(clientSpouse.Name);

                        foreach (string member in GetFamilyMembers(clientId))
                        {
                            members.Add(member);
                        }

                        //Prepare excel sheet with member list
                        string reviewSheetFilePath = generateReviewSheet(members);

                        //Send email to that member.
                        sendEmail(emailId, reviewSheetFilePath, clientName,index);

                       

                    }
                    catch(Exception ex)
                    {
                        gridViewClient.SetRowCellValue(index, "Status", "Error while sending email:" + ex.ToString());
                        Logger.LogDebug(ex);
                    }                    
                }
           }
            deleteReviewFilesFolder();
        }

        private void deleteReviewFilesFolder()
        {
            //if (System.IO.Directory.Exists(Path.Combine(Path.GetTempPath(), "ReviewSheet")))
            //    System.IO.Directory.Delete(Path.Combine(Path.GetTempPath(), "ReviewSheet"),true);
        }

        private void sendEmail(string primaryEmail,string reviewSheetPath,string clientName,int index)
        {
            try
            {
                Attachment attachment = getQuarterlyReviewTemplateForEmail(reviewSheetPath);
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(MailServer.FromEmail);
                mailMessage.To.Add(new MailAddress(primaryEmail));
                mailMessage.Subject = "Data require for quaterly review";
                mailMessage.IsBodyHtml = false ;
                mailMessage.Attachments.Add(attachment);
                //mailMessage.Body = "Hi" + clientName + "," + Environment.NewLine + Environment.NewLine +
                //    "Quartely Review information send." +
                //     Environment.NewLine + Environment.NewLine +
                //    "With Regards," + Environment.NewLine + Environment.NewLine + "Asccent Finance solution";

                mailMessage.Body = "Dear Madam/ Sir, " + Environment.NewLine + Environment.NewLine +

                   "Greetings from Ascent Financial Solutions." + Environment.NewLine + Environment.NewLine +

                   "As your Quarterly Review is due, You are kindly requested to provide your financial data." + Environment.NewLine + Environment.NewLine +

                   "Please find herewith attached Template for the same." + Environment.NewLine +
                   "Kindly send data before 15th April' 2021." + Environment.NewLine + Environment.NewLine +

                   "We value your relationship with us and are committed to provide excellent Financial Solutions and services." + Environment.NewLine + Environment.NewLine +
                   "Regards," + Environment.NewLine +

                   "Financial Planning Team" + Environment.NewLine +
                   "ASCENT FINANCIAL SOLUTIONS" + Environment.NewLine +
                   "314,315,316 Notus IT park," + Environment.NewLine +
                   "Sarabhai Campus," + Environment.NewLine +
                   "Genda Circle, Vadodara, Gujarat 390023" + Environment.NewLine +
                   "http://www.ascentsolutions.in";

                bool isEmailSend = EmailService.SendEmail(mailMessage);
                if (isEmailSend)
                {
                    // MessageBox.Show("Quarterly Review Template report send to client on '" + primaryEmail + "'.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridViewClient.SetRowCellValue(index, "Status", "Email send successfully");
                }
                else
                {
                    gridViewClient.SetRowCellValue(index, "Status", "Unable to send email to:" +  primaryEmail);
                    //MessageBox.Show("Unable to send email to '" + primaryEmail + "'. Check your email configuration setting.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.LogDebug(ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private Attachment getQuarterlyReviewTemplateForEmail(string reviewSheetPath)
        {            
            string hostName = MailServer.HostName;
            Attachment attachment = new Attachment(reviewSheetPath);
            attachment.Name = "QuarterlyReviewTemplate.xlsx";
            return attachment;
        }

        private List<String> GetFamilyMembers(int clientId)
        {
                IList<FamilyMember> familyMemberObj = new List<FamilyMember>();
                try
                {
                    FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                    string apiurl = Program.WebServiceUrl + "/" + string.Format(GET_All_FAMAILYMEMBER_API, clientId);

                    RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                    var restResult = restApiExecutor.Execute<IList<FamilyMember>>(apiurl, null, "GET");

                    if (jsonSerialization.IsValidJson(restResult.ToString()))
                    {
                        familyMemberObj = jsonSerialization.DeserializeFromString<IList<FamilyMember>>(restResult.ToString());
                    }
                    return familyMemberObj.Select(i => i.Name).ToList();
                }
                catch (Exception ex)
                {
                    Logger.LogDebug(ex);
                    return null;
                }            
        }

        private ClientSpouse getSpousePersonalInfo(int clientId)
        {
            ClientSpouse clientSpouseObj = new ClientSpouse();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + string.Format(GET_SPOUSE_PERSONAL_API, clientId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<Client>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    clientSpouseObj = jsonSerialization.DeserializeFromString<ClientSpouse>(restResult.ToString());
                }
                return clientSpouseObj;
            }
            catch (Exception ex)
            {
                Logger.LogDebug(ex);
                return null;
            }
        }

        private string generateReviewSheet(List<string> members)
        {
            string fileExcel;
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Review data required Template Format.xlsx", Path.GetFullPath(Path.Combine(RunningPath)));
            fileExcel = FileName; // @"C:\Users\shukl\Downloads\Ascent Finance Solution\Review data required Template Format.xlsx";
            //Excel.Application xlapp;
            //Excel.Workbook xlworkbook;
            //xlapp = new Excel.Application();

            //xlworkbook = xlapp.Workbooks.Open(fileExcel, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            //xlapp.Visible = true;

            var MyApp = new Microsoft.Office.Interop.Excel.Application();
            MyApp.Visible = false;
            //proper way:
            var xlBook = MyApp.Workbooks.Open(fileExcel);

            var xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlBook.Worksheets.get_Item(1); // Explicit cast is not required here
                                                                          // Check and change sheet name to 'Sheet1'
            if (xlSheet.Name != "Sheet1")
                xlSheet.Name = "Sheet1";
            //you don't need to save a workbook now
            //as i mentioned above, you can do it later by using SaveAs method
            //xlBook.Save();
            int rowIndex = 19;
            int colIndex = 3;
            for (int i = 0; i <= members.Count - 1 ; i++)
            {
                string stmp = (string)xlSheet.Cells[rowIndex, colIndex].Value;
           
                xlSheet.Cells[rowIndex, colIndex].Value = members[i];               
                colIndex = colIndex + 1;
            }

            string tempPath = Path.Combine(Path.GetTempPath(), "ReviewSheet");
            if (!System.IO.Directory.Exists(tempPath))
                System.IO.Directory.CreateDirectory(tempPath);

            string sNewFileName = Path.Combine(tempPath ,
    string.Concat(members[0].ToString(), "_Review", ".xlsx"));
            xlBook.SaveAs(sNewFileName);
            xlBook.Close();
            return sNewFileName; 
        }
        private void gridViewClient_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
            if (e.Column.Caption == "" &&  gridViewClient.GetRowCellValue(e.RowHandle,e.Column).ToString() == "True" )
            {
                selectedRowsIndex.Add(e.RowHandle);
            }
            else if (e.Column.Caption == "" && 
                (gridViewClient.GetRowCellValue(e.RowHandle, e.Column).ToString() == "" ||
                gridViewClient.GetRowCellValue(e.RowHandle, e.Column).ToString() == "False"))
            {
                if (selectedRowsIndex.Contains(e.RowHandle))
                {
                    selectedRowsIndex.Remove(e.RowHandle);
                }
            }
        }
        
        private List<int> getSelectedRowsIndex()
        {
            return selectedRowsIndex;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for(int i =0;  i <= gridViewClient.RowCount -1; i++)
            {
                gridViewClient.SetRowCellValue(i, "IsSelected", true);
            }
        }

        private void btnDeSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= gridViewClient.RowCount - 1; i++)
            {
                gridViewClient.SetRowCellValue(i, "IsSelected", false );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtQuaterlyReview.Text == "")
            {
                MessageBox.Show("Please enter date for quarterly review");
                return;
            }
            fillClients();
        }
    }
}
