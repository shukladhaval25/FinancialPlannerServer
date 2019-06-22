using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.EmailManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FinancialPlannerServer
{
    public partial class frmSystemSetting : Form
    {
        #region "Application configuration API"
        private const string GET_APPLICATIONCONFIG_API ="ApplicationConfiguration";

        private const string ADD_APPLICATIONCONFIG_API = "ApplicationConfiguration/AddConfig";
        private const string UPDATE_APPLICATIONCONFIG_API = "ApplicationConfiguration/UpdateConfig";

        private const string ADD_MULTIPAL_APPLICATIONCONFIG_API = "ApplicationConfiguration/AddConfigs";
        private const string UPDATE_MULTIPAL_APPLICATIONCONFIG_API = "ApplicationConfiguration/UpdateConfigs";
        #endregion

        #region "Email Article APIs"
        private const string GET_EMAILARTICLES_API ="EmailArticle/Get";
        private const string ADD_EMAILARTICLE_API = "EmailArticle/Add";
        private const string UPDATE_EMAILARTICLE_API = "EmailArticle/Update";
        private const string DETELE_EMAILARATICLE_API ="EmailArticle/Delete";
        #endregion
        //private  EmailArticle _article;
        private DataTable _dtAppConfig;
        private DataTable _dtArticle;
        public frmSystemSetting()
        {
            InitializeComponent();
        }

        private void frmSystemSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnSaveSMTPSetting_Click(object sender, EventArgs e)
        {
            if (validateAllRequireField())
            {
                saveSMTPConfiguration();
            }
            else
            {
                MessageBox.Show("Please enter all require data.", "Data Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool validateAllRequireField()
        {
            return (!string.IsNullOrEmpty(txtHost.Text) || !string.IsNullOrEmpty(txtPort.Text) ||
                  !string.IsNullOrEmpty(txtFromEmail.Text) || !string.IsNullOrEmpty(txtUserName.Text) ||
                  !string.IsNullOrEmpty(txtPassword.Text));
        }

        private void saveSMTPConfiguration()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = string.Empty;

                List<ApplicationConfiguration> appConfigs = getSMTPConfig();

                DataRow[] drCollection = _dtAppConfig.Select("Category = 'SMTP Setting'");
                if (drCollection.Count() == 0)
                {
                    apiurl = Program.WebServiceUrl + "/" + ADD_MULTIPAL_APPLICATIONCONFIG_API;
                }
                else
                {
                    apiurl = Program.WebServiceUrl + "/" + UPDATE_MULTIPAL_APPLICATIONCONFIG_API;
                }

                string DATA =  jsonSerialization.SerializeToString<List<ApplicationConfiguration>>(appConfigs);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl,"POST", DATA);

                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save record." + resultObject.ExceptionInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<ApplicationConfiguration> getSMTPConfig()
        {

            MailServer.FromEmail = txtFromEmail.Text;
            MailServer.HostPort = int.Parse(txtPort.Text);
            MailServer.HostName = txtHost.Text;
            MailServer.UserName = txtUserName.Text;
            MailServer.Password = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Encrypt(txtPassword.Text);
            MailServer.IsSSL = chkIsSSL.Checked;
            MailServer.POP3_IMPS_HostName = txtPOP3Host.Text;
            MailServer.POP3_IMPS_HostPort = txtPOP3Port.Text;

            List<KeyValuePair<string, string>> lstSMTPsetting = new List<KeyValuePair<string, string>>();
            lstSMTPsetting.Add(new KeyValuePair<string, string>("FromEmail", MailServer.FromEmail));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("SMTPPort", MailServer.HostPort.ToString()));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("SMTPHost", MailServer.HostName));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("UserName", MailServer.UserName));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("Password", MailServer.Password));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("IsSSL", MailServer.IsSSL.ToString()));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("POP3_IMPS_Host", MailServer.POP3_IMPS_HostName.ToString()));
            lstSMTPsetting.Add(new KeyValuePair<string, string>("POP3_IMPS_Port", MailServer.POP3_IMPS_HostPort.ToString()));

            List<ApplicationConfiguration> lstConfig = new List<ApplicationConfiguration>();

            foreach (KeyValuePair<string, string> val in lstSMTPsetting)
            {
                ApplicationConfiguration appConfig = new ApplicationConfiguration()
                {
                    Category ="Mail Server Setting",
                    SettingName = val.Key,
                    SettingValue = val.Value.Replace("'","''"),
                    CreatedOn = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    CreatedBy = Program.CurrentUser.Id,
                    UpdatedOn =  DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    UpdatedBy = Program.CurrentUser.Id,
                    UpdatedByUserName = Program.CurrentUser.UserName,
                    MachineName = System.Environment.MachineName
                };
                lstConfig.Add(appConfig);
            }
            return lstConfig;
        }

        private void btnFindfolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDiallog.ShowDialog() == DialogResult.OK)
                txtAppPath.Text = folderBrowserDiallog.SelectedPath;
        }

        private void frmSystemSetting_Load(object sender, EventArgs e)
        {
            loadApplicationConfig();

            displayApplicationConfig();
        }

        private void displaySMTPConfig()
        {
            if (_dtAppConfig != null)
            {
                DataRow[] smtpSettingRows = _dtAppConfig.Select("CATEGORY = 'Mail Server Setting'");
                foreach (DataRow dr in smtpSettingRows)
                {
                    if (dr.Field<string>("SettingName") == "FromEmail")
                    {
                        txtFromEmail.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPPort")
                    {
                        txtPort.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPHost")
                    {
                        txtHost.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "UserName")
                    {
                        txtUserName.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "Password")
                    {
                        txtPassword.Text = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Decrypt(dr.Field<string>("SettingValue"));
                    }
                    else if (dr.Field<string>("SettingName") == "IsSSL")
                    {
                        chkIsSSL.Checked = Boolean.Parse(dr.Field<string>("SettingValue"));
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPPort")
                    {
                        txtPort.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPHost")
                    {
                        txtHost.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "POP3_IMPS_Port")
                    {
                        txtPOP3Port.Text = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "POP3_IMPS_Host")
                    {
                        txtPOP3Host.Text = dr.Field<string>("SettingValue");
                    }
                }              
            }
        }
        private void displayApplicationConfig()
        {
            displaySMTPConfig();
            displayApplicationPath();
        }

        private void displayApplicationPath()
        {
            if (_dtAppConfig != null)
            {
                DataRow[] appPathRows = _dtAppConfig.Select("SettingName= 'Application Path'");
                if (appPathRows.Count() > 0)
                    txtAppPath.Text = appPathRows[0].Field<string>("SettingValue");
                else
                    txtAppPath.Text = "";
            }
            else
                txtAppPath.Text = "";
        }

        private void loadApplicationConfig()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ GET_APPLICATIONCONFIG_API;

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl);
                request.Method = "GET";
                String appConfigJsobResult = String.Empty;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();

                    StreamReader reader = new StreamReader(dataStream);
                    appConfigJsobResult = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                }

                var appConfigCollection= jsonSerialization.DeserializeFromString<Result<List<ApplicationConfiguration>>>(appConfigJsobResult);

                if (appConfigCollection.Value != null)
                {
                    _dtAppConfig = ListtoDataTable.ToDataTable(appConfigCollection.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fail to load application data. Error:{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAppPathSave_Click(object sender, EventArgs e)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = string.Empty;

                ApplicationConfiguration appConfig = new ApplicationConfiguration()
                {
                    Category ="Server Setting",
                    SettingName = "Application Path",
                    SettingValue = txtAppPath.Text.Replace("'","''"),
                    CreatedOn = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    CreatedBy = Program.CurrentUser.Id,
                    UpdatedOn =  DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    UpdatedBy = Program.CurrentUser.Id,
                    UpdatedByUserName = Program.CurrentUser.UserName,
                    MachineName = System.Environment.MachineName
                };

                DataRow[] drCollection = _dtAppConfig.Select("SettingName = 'Application Path'");
                if (drCollection.Count() == 0)
                {
                    apiurl = Program.WebServiceUrl + "/" + ADD_APPLICATIONCONFIG_API;
                }
                else
                {
                    apiurl = Program.WebServiceUrl + "/" + UPDATE_APPLICATIONCONFIG_API;
                    appConfig.Id = int.Parse(drCollection[0][0].ToString());
                }

                string DATA =  jsonSerialization.SerializeToString<ApplicationConfiguration>(appConfig);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl,"POST", DATA);

                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save record." + resultObject.ExceptionInfo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabEmailSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmailSetting.SelectedIndex == 1)
            {
                resetArticleForm();
                loadArticleFormWithData();
                displayArtilceTreeView(_dtArticle);
            }
        }

        private void displayArtilceTreeView(DataTable dtEmailArticle)
        {
            trvArticle.Nodes.Clear();
            trvArticle.Nodes.Add("My Articles", "My Articles", 8);
            if (dtEmailArticle != null)
            {
                addDistinceGroupNode(dtEmailArticle);
                addAllArticleUnderGoupNode(dtEmailArticle);
            }
        }

        private void addAllArticleUnderGoupNode(DataTable dtEmailArticle)
        {
            foreach (DataRow dr in dtEmailArticle.Rows)
            {
                TreeNode[] searchResultNodes = trvArticle.Nodes[0].Nodes.Find(dr.Field<string>("GroupName"), true);
                TreeNode node = new TreeNode();
                node.Tag = dr.Field<string>("ID");
                node.Text = dr.Field<string>("Title");
                node.ImageIndex = 8;
                node.ToolTipText = node.Text;
                searchResultNodes[0].Nodes.Add(node);
            }
            trvArticle.ExpandAll();
        }

        private void addDistinceGroupNode(DataTable dtEmailArticle)
        {
            var distinctRows = (from DataRow dRow in dtEmailArticle.Rows
                                select dRow["GroupName"] ).Distinct();
            foreach (string rowValue in distinctRows)
            {
                trvArticle.Nodes[0].Nodes.Add(rowValue, rowValue, 9);
            }
        }

        private void loadArticleFormWithData()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ GET_EMAILARTICLES_API;

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl);
                request.Method = "GET";
                String emailArticleResultJson = String.Empty;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();

                    StreamReader reader = new StreamReader(dataStream);
                    emailArticleResultJson = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                }
                var emailArticleCollection = jsonSerialization.DeserializeFromString<Result<List<EmailArticle>>>(emailArticleResultJson);

                if (emailArticleCollection.Value != null)
                {
                    _dtArticle = ListtoDataTable.ToDataTable(emailArticleCollection.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Fail to load application data. Error:{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetArticleForm()
        {
            if (_dtAppConfig == null)
                _dtAppConfig = new DataTable();

            _dtAppConfig.Clear();
            trvArticle.Nodes.Clear();
            grpArticleInfo.Enabled = false;
        }

        private void btnCancelArticleInfo_Click(object sender, EventArgs e)
        {
            grpArticleInfo.Enabled = false;
        }

        private void btnEditArticleInfo_Click(object sender, EventArgs e)
        {
            grpArticleInfo.Enabled = true;
            btnSaveArticleInfo.Enabled = true;
            fillGroupCombo();

            if (trvArticle.SelectedNode != null && trvArticle.SelectedNode.Tag != null)
            {
                DataRow dr = getSelectedDataRow(int.Parse(trvArticle.SelectedNode.Tag.ToString()));
                if (dr != null)
                {
                    cmbGroup.Tag = int.Parse(dr.Field<string>("GroupID"));
                    cmbGroup.Text = dr.Field<string>("GroupName");
                    txtArticleTitle.Tag = int.Parse(dr.Field<string>("ID"));
                    txtArticleTitle.Text = dr.Field<string>("Title");
                    txtArticleContentPath.Text = dr.Field<string>("ContentFilePath");
                    txtArticleDesc.Text = dr.Field<string>("Description");
                }
                else
                {
                    clearArticleData();
                    grpArticleInfo.Enabled = false;
                }
            }
            else
            {
                clearArticleData();
                grpArticleInfo.Enabled = false;
            }
        }

        private void fillGroupCombo()
        {
            cmbGroup.Items.Clear();
            var distinctRows = (from DataRow dRow in _dtArticle.Rows
                                select dRow["GroupName"] ).Distinct();
            foreach (string rowValue in distinctRows)
            {
                cmbGroup.Items.Add(rowValue);
            }
        }

        private DataRow getSelectedDataRow(int id)
        {
            if (id > 0)
            {
                DataRow[] rows = _dtArticle.Select("ID = " + id);
                foreach (DataRow dr in rows)
                {
                    return dr;
                }
            }
            else
            {
                MessageBox.Show("Please select valid article.", "Article", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }

        private void btnAddArticleInfo_Click(object sender, EventArgs e)
        {
            clearArticleData();
            fillGroupCombo();
            grpArticleInfo.Enabled = true;
            btnSaveArticleInfo.Enabled = true;

        }
        private void clearArticleData()
        {
            cmbGroup.Tag = null;
            cmbGroup.Text = "";
            txtArticleTitle.Tag = null;
            txtArticleTitle.Text = "";
            txtArticleContentPath.Text = "";
            txtArticleDesc.Text = "";            
        }

        private void btnArticleContentFile_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArticleContentPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnSaveArticleInfo_Click(object sender, EventArgs e)
        {
            if (validateArticleField())
            {
                updateEmailArticleInfo();
            }
            else
            {
                MessageBox.Show("Please enter all require data.", "Data Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validateArticleField()
        {
            return (!string.IsNullOrEmpty(cmbGroup.Name) || !string.IsNullOrEmpty(txtArticleTitle.Text));
        }

        private void updateEmailArticleInfo()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = string.Empty;

                EmailArticle article = new EmailArticle()
                {
                    GroupName = cmbGroup.Text,
                    Title = txtArticleTitle.Text,
                    ContentFilePath = txtArticleContentPath.Text,
                    Description = txtArticleDesc.Text,
                    CreatedOn = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    CreatedBy = Program.CurrentUser.Id,
                    UpdatedOn =  DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    UpdatedBy = Program.CurrentUser.Id,
                    UpdatedByUserName = Program.CurrentUser.UserName,
                    MachineName = System.Environment.MachineName
                };

                if (txtArticleTitle.Tag == null)
                {
                    apiurl = Program.WebServiceUrl + "/" + ADD_EMAILARTICLE_API;
                }
                else
                {
                    apiurl = Program.WebServiceUrl + "/" + UPDATE_EMAILARTICLE_API;
                    article.ID = int.Parse(txtArticleTitle.Tag.ToString());
                }

                string DATA =  jsonSerialization.SerializeToString<EmailArticle>(article);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl,"POST", DATA);

                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadArticleFormWithData();
                        btnSaveArticleInfo.Enabled = false;
                        displayArtilceTreeView(_dtArticle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtsearchResult =  _dtArticle.Select(string.Format("GroupName like '%{0}%' or Title like '%{0}%'", txtSearchEmailArticle.Text)).CopyToDataTable();
            displayArtilceTreeView(dtsearchResult);
        }

        private void btnDeleteArticleInfo_Click(object sender, EventArgs e)
        {
            if (trvArticle.SelectedNode != null)
            {
                if (MessageBox.Show(
                    string.Format("Are you sure you want to remove {0}'s record? If you select 'Yes' then all associated conversation gets deleted.", trvArticle.SelectedNode.Text),
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    removeRecord(trvArticle.SelectedNode);
                }
            }
            else
            {
                MessageBox.Show("Please select item to perform action.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeRecord(TreeNode selectedNode)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl  = Program.WebServiceUrl + "/" + DETELE_EMAILARATICLE_API;

                EmailArticle article = convertSelectedRowDataToEmailArticle();

                string DATA =  jsonSerialization.SerializeToString<EmailArticle>(article);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl,"POST", DATA);

                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        trvArticle.SelectedNode.Remove();
                        DataRow[] dr =  _dtArticle.Select("ID =" + article.ID);
                        if (dr.Count() > 0)
                            dr[0].Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private EmailArticle convertSelectedRowDataToEmailArticle()
        {
            EmailArticle article = new EmailArticle();
            if (trvArticle.SelectedNode.Tag != null)
            {
                DataRow dr = getSelectedDataRow(int.Parse(trvArticle.SelectedNode.Tag.ToString()));
                if (dr != null)
                {
                    article.ID = int.Parse(dr.Field<string>("ID"));
                    article.GroupId = int.Parse(dr.Field<string>("GroupID"));
                    article.GroupName = dr.Field<string>("GroupName");
                    article.Title = dr.Field<string>("Title");
                    article.ContentFilePath = dr.Field<string>("ContentFilePath");
                    article.Description = dr.Field<string>("Description");
                    article.UpdatedByUserName = Program.CurrentUser.UserName;
                    article.MachineName = System.Environment.MachineName;
                }
            }
            return article;
        }

        private void btnRestoreDefault_Click(object sender, EventArgs e)
        {
            txtPort.Text = "587";
        }

        private void cmbGroup_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGroup.Text))
                cmbGroup.Tag = "0";           
        }

        private void trvArticle_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnEditArticleInfo_Click(sender,e);
        }
    }
}
