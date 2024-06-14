using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Permission;
using FinancialPlannerServer.Security;
using FinancialPlannerServer.Testing;
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
        private const string GETADMINSTATUS = "User/GetAdminStatus";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter user name.", "User Name");
                return;
            }
            if (!txtUserName.Text.Equals("Admin"))
            {
                MessageBox.Show("Only admin can connect with this application.", "Contact to your administrator");
                return;
            }
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
                    Program.CurrentUserRolePermission = getCurrentUserRolePermission();
                    if (Program.CurrentUserRolePermission.Name != "Admin")
                    {
                        MessageBox.Show("You don't have permission to access this application. Please contact to Administrator", "Permission", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    frmServerMain frmserMain = new frmServerMain();
                    this.Visible = false;
                    frmserMain.ShowDialog();
                    //frmTesting frmTestingObj = new frmTesting();
                    //this.Visible = false;
                    //frmTestingObj.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Invalid user or credential.", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private Role getCurrentUserRolePermission()
        {
            if (Program.CurrentUser != null)
            {
                RolesPermissionnfo permissionInfo = new RolesPermissionnfo();
                Role role = permissionInfo.Get(Program.CurrentUser.RoleId);
                return role;
            }
            return new Role();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ GETADMINSTATUS;
            RestAPIExecutor restApiExecutor = new RestAPIExecutor();
            var restResult = restApiExecutor.Execute<User>(apiurl, null, "GET");
            if (jsonSerialization.IsValidJson(restResult.ToString()))
            {
                var user = jsonSerialization.DeserializeFromString<User>(restResult.ToString());
                if (string.IsNullOrEmpty(user.UserName))
                {
                    SetAdminAccount setadminac = new SetAdminAccount();
                    if (setadminac.ShowDialog() != DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }

        }
    }
}
