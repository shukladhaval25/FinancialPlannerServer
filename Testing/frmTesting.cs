using System;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinancialPlannerServer.Testing
{
    public partial class frmTesting : Form
    {
        public frmTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileExcel;
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Review data required Template Format.xlsx", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            fileExcel = FileName; // @"C:\Users\shukl\Downloads\Ascent Finance Solution\Review data required Template Format.xlsx";
            //Excel.Application xlapp;
            //Excel.Workbook xlworkbook;
            //xlapp = new Excel.Application();

            //xlworkbook = xlapp.Workbooks.Open(fileExcel, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            //xlapp.Visible = true;

            var MyApp = new Excel.Application();
            MyApp.Visible = false;
            //proper way:
            var xlBook = MyApp.Workbooks.Open(fileExcel);

            var xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1); // Explicit cast is not required here
                                                                      // Check and change sheet name to 'Sheet1'
            if (xlSheet.Name != "Sheet1")
                xlSheet.Name = "Sheet1";
            //you don't need to save a workbook now
            //as i mentioned above, you can do it later by using SaveAs method
            //xlBook.Save();
            int rowIndex = 19;
            int colIndex = 3;
            for (int i= 1; i <=3; i++)
            {
                string stmp = (string)xlSheet.Cells[rowIndex , colIndex].Value;
                //if (stmp == "yesterday")
                if (i == 1)
                    xlSheet.Cells[rowIndex, colIndex].Value = "Mr. Dhaval Shukla";
                else if (i==2)
                    xlSheet.Cells[rowIndex, colIndex].Value = "Mrs. Chhaya Shukla";
                else if (i==3)
                    xlSheet.Cells[rowIndex, colIndex].Value = "Mr. Svarna Shukla";

                colIndex = colIndex + 1;
            }
            

            string sNewFileName = Path.Combine(Path.GetDirectoryName(fileExcel),
    string.Concat(Path.GetFileNameWithoutExtension(fileExcel), "_", DateTime.Today.ToString("yyyyMMdd"), ".xslx"));
            xlBook.SaveAs(sNewFileName);
            MyApp.Visible = true;
            //if (stmp.Contains("-"))
            //xlSheet.Cells[2, 1].Value = stmp.Remove(ind, ind);
        }

        private void sendMail()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    Chilkat.MailMan mailman = new Chilkat.MailMan();

        //    // Set the SMTP server.
        //    mailman.SmtpHost = "smtp.my-tls-mail-server.com";

        //    // Set the SMTP login/password (if required)
        //    mailman.SmtpUsername = "MY_SMTP_USERNAME";
        //    mailman.SmtpPassword = "MY_SMTP_PASSWORD";

        //    // Connect to SMTP port 465 using TLS.
        //    mailman.SmtpSsl = true;
        //    mailman.SmtpPort = 465;

        //    // Create a new email object
        //    Chilkat.Email email = new Chilkat.Email();

        //    email.Subject = "This is a test";
        //    email.Body = "This is a test";
        //    email.From = "Chilkat Support <support@chilkatsoft.com>";
        //    bool success = email.AddTo("Chilkat Admin", "admin@chilkatsoft.com");
        //    // To add more recipients, call AddTo, AddCC, or AddBcc once per recipient.

        //    // Add some attachments.
        //    // The AddFileAttachment method returns the value of the content-type it chose for the attachment.
        //    string contentType = email.AddFileAttachment("qa_data/jpg/starfish.jpg");
        //    if (email.LastMethodSuccess != true)
        //    {
        //        Debug.WriteLine(email.LastErrorText);
        //        return;
        //    }

        //    contentType = email.AddFileAttachment("qa_data/pdf/fishing.pdf");
        //    if (email.LastMethodSuccess != true)
        //    {
        //        Debug.WriteLine(email.LastErrorText);
        //        return;
        //    }

        //    // Call SendEmail to connect to the SMTP server and send.
        //    // The connection (i.e. session) to the SMTP server remains
        //    // open so that subsequent SendEmail calls may use the
        //    // same connection.  
        //    success = mailman.SendEmail(email);
        //    if (success != true)
        //    {
        //        Debug.WriteLine(mailman.LastErrorText);
        //        return;
        //    }

        //    success = mailman.CloseSmtpConnection();
        //    if (success != true)
        //    {
        //        Debug.WriteLine("Connection to SMTP server not closed cleanly.");
        //    }

        //    Debug.WriteLine("Mail with attachments sent!");

        }
    }
}
