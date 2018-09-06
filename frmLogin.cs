using FinancialPlanner.Common.Model;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace FinancialPlannerServer
{
    public partial class frmLogin : Form
    {
        private const string AUTHENTICATIONAPI = "Authentication/Authenticate";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            User user = new User()
            {
                UserName = txtUserName.Text,
                Password = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Encrypt(txtPassword.Text),
                MachineName = Environment.MachineName
            };
            string DATA =  jsonSerialization.SerializeToString<User>(user);

            string loginUrl = Program.WebServiceUrl +"/"+ AUTHENTICATIONAPI;

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(loginUrl, DATA);
            if (json != null)
            {
                Result<User> resultObject = jsonSerialization.DeserializeFromString<Result<User>>(json);
                if (resultObject.IsSuccess && resultObject.Value != null)
                {
                    Program.CurrentUser = resultObject.Value;
                    frmServerMain frmserMain = new frmServerMain();
                    this.Visible = false;
                    frmserMain.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid user or credential.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
