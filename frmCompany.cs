using FinancialPlanner.Common;
using FinancialPlanner.Common.Model.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer
{
    public partial class frmCompany : Form
    {
        private const string ADD_COMPANY_API = "Company/Add";
        private const string GET = "Company/Get";
        public frmCompany()
        {
            InitializeComponent();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            loadCompanyData();
        }

        private void loadCompanyData()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ GET;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<Company>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    Company companyObj = jsonSerialization.DeserializeFromString<Company>(restResult.ToString());
                    displayCompanyData(companyObj);
                }
            }
            catch (System.Net.WebException webException)
            {
                if (webException.Message.Equals("The remote server returned an error: (401) Unauthorized."))
                {
                    MessageBox.Show("You session has been expired. Please Login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
            }
        }

        private void displayCompanyData(Company companyObj)
        {
            txtCompanyName.Text = companyObj.Name;
            txtAddress.Text = companyObj.Address;
            txtContactNo.Text = companyObj.Contactno;
            txtEmail.Text = companyObj.Email;
            txtWebsite.Text = companyObj.Website;
            txtRegistrationNo.Text = companyObj.RegistrationNo;
        }

        private Company getCompanyData()
        {
            Company comp = new Company();
            comp.Name = txtCompanyName.Text;
            comp.Address = txtAddress.Text;
            comp.Contactno = txtContactNo.Text;
            comp.Email = txtEmail.Text;
            comp.Website = txtWebsite.Text;
            comp.RegistrationNo = txtRegistrationNo.Text;
            comp.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            comp.CreatedBy = Program.CurrentUser.Id;
            comp.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            comp.UpdatedBy = Program.CurrentUser.Id;
            comp.MachineName = Environment.MachineName;
            return comp;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Company company = getCompanyData();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ ADD_COMPANY_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<Company>(apiurl, company, "POST");
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
            }
        }
        private void LogDebug(string methodName, Exception ex)
        {
            DebuggerLogInfo debuggerInfo = new DebuggerLogInfo();
            debuggerInfo.ClassName = this.GetType().Name;
            debuggerInfo.Method = methodName;
            debuggerInfo.ExceptionInfo = ex;
            Logger.LogDebug(debuggerInfo);
        }
    }
}
