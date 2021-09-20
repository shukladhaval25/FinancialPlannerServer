using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.EmailManager;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer
{
    public class MailManager
    {
        private const string GET_APPLICATIONCONFIG_API = "ApplicationConfiguration";
        private DataTable _dtAppConfig;

        public MailManager()
        {
            loadApplicationConfig();
            loadSMTPMailServerSetting();
            //loadIMAPServerSetting();
        }

        private void loadIMAPServerSetting()
        {
            MailServer.HostName = "imap.gmail.com";
            MailServer.HostPort = 993;
            MailServer.UserName = "dhaval.shukla79@gmail.com";
            MailServer.Password = "Dhaval@007";
            MailServer.IsSSL = true;
            MailServer.FromEmail = "dhaval.shukla79@gmail.com";
        }

        //Fetch All Mails
        //public IList<IMail> GetAllEamil()
        //{
        //    try
        //    {
        //        EmailService emailService = new EmailService();
        //        return emailService.GetAllMails();
        //    }
        //    catch(Exception ex)
        //    {
        //        return null;
        //    }
        //}
        //Filter Email
        //Get mail setting from server
        private EmailServer getPOPSeverSetting()
        {
            EmailServer emailServer = new EmailServer();
            emailServer.HostName = "pop.gmail.com";
            emailServer.HostPort = 995;
            emailServer.UserName = "dhaval.shukla79@gmail.com";
            emailServer.Password = "Dhaval@007";
            emailServer.IsSSL = true;
            return emailServer;
        }

        private EmailServer getIMAPSeverSetting()
        {
            EmailServer emailServer = new EmailServer();
            emailServer.HostName = "imap.gmail.com";
            emailServer.HostPort = 993;
            emailServer.UserName = "dhaval.shukla79@gmail.com";
            emailServer.Password = "Dhaval@007";
            emailServer.IsSSL = true;
            return emailServer;
        }

        private void loadApplicationConfig()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + GET_APPLICATIONCONFIG_API;

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

                var appConfigCollection = jsonSerialization.DeserializeFromString<Result<List<FinancialPlanner.Common.Model.ApplicationConfiguration>>>(appConfigJsobResult);

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

        private void loadSMTPMailServerSetting()
        {
            if (_dtAppConfig != null)
            {
                DataRow[] smtpSettingRows = _dtAppConfig.Select("CATEGORY = 'Mail Server Setting'");
                foreach (DataRow dr in smtpSettingRows)
                {
                    if (dr.Field<string>("SettingName") == "FromEmail")
                    {
                        MailServer.FromEmail = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPPort")
                    {
                        MailServer.HostPort = int.Parse(dr.Field<string>("SettingValue"));
                    }
                    else if (dr.Field<string>("SettingName") == "SMTPHost")
                    {
                        MailServer.HostName = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "UserName")
                    {
                        MailServer.UserName = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "Password")
                    {
                        MailServer.Password = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Decrypt(dr.Field<string>("SettingValue"));
                    }
                    else if (dr.Field<string>("SettingName") == "IsSSL")
                    {
                        MailServer.IsSSL = Boolean.Parse(dr.Field<string>("SettingValue"));
                    }
                    else if (dr.Field<string>("SettingName") == "POP3_IMPS_Host")
                    {
                        MailServer.POP3_IMPS_HostName = dr.Field<string>("SettingValue");
                    }
                    else if (dr.Field<string>("SettingName") == "POP3_IMPS_Port")
                    {
                        MailServer.POP3_IMPS_HostPort = int.Parse(dr.Field<string>("SettingValue"));
                    }
                }
            }
        }
    }

    public class EmailServer
    {
        public string HostName { get; set; }
        public int HostPort { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsSSL { get; set; }
    }
}
