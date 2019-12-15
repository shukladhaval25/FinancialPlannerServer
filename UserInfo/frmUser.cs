using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.DataEncrypterDecrypter;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Permission;
using FinancialPlannerServer.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.UserInfo
{
    public partial class frmUser : Form
    {
        private const string USER_UPDATE_RAPI = "User/Update";
        private const string USER_ADD_API = "User/Add";
        private User _user;
        private bool _isEditModeOn = false;
        public frmUser()
        {
            InitializeComponent();
        }
        public frmUser(User user)
        {
            InitializeComponent();
            _isEditModeOn = true;
            _user = user;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            fillRolesPermission();
            if (_user != null)
                fillUserInfo();
            
        }

        private void fillRolesPermission()
        {
            List<Role> roles = (List<Role>) new RolesPermissionnfo().GetAll();

            lookUpRole.Properties.DataSource = roles;
            lookUpRole.Properties.ValueMember = "Id";
            lookUpRole.Properties.DisplayMember = "Name";

            //DataTable dtRole = ListtoDataTable.ToDataTable(roles);
            //foreach(DataColumn dataColumn in dtRole.Columns)
            //{

            //    if (dataColumn.ColumnName != "Name" &&
            //        dataColumn.ColumnName != "Id")
            //    {
            //        dtRole.Columns.Remove(dataColumn);
            //    }
            //}

            //lookUpRole.Properties.DataSource = dtRole;
            //lookUpRole.Properties.ValueMember = "Id";
            //lookUpRole.Properties.DisplayMember = "Name";
            //lookUpRole.Properties.Columns["IsCustomRole"].Visible = false;
            //lookUpRole.Properties.Columns["CreatedOn"].Visible = false;
            //lookUpRole.Properties.Columns["CreatedBy"].Visible = false;
            //lookUpRole.Properties.Columns["UpdatedOn"].Visible = false;
            //lookUpRole.Properties.Columns["UpdatedBy"].Visible = false;

        }

        private void fillUserInfo()
        {
            txtUserName.Text = _user.UserName;
            txtFirstName.Text = _user.FirstName;
            txtLastName.Text = _user.LastName;
            txtPassword.Text = CryptoEngine.Decrypt(_user.Password);
            lblConfirmPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            lookUpRole.EditValue = _user.RoleId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lookUpRole.Text))
            {
                MessageBox.Show("Please assign role to user.", "Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_isEditModeOn)
            {
                updateUserDate();
            }
            else
            {
                addUserData();
            }
        }

        private void addUserData()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ USER_ADD_API;

                User user = new User()
                {
                    UserName = txtUserName.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Password = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Encrypt(txtPassword.Text),
                    CreatedOn = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    CreatedBy = Program.CurrentUser.Id,
                    UpdatedOn =  DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                    UpdatedBy = Program.CurrentUser.Id,
                    UpdatedByUserName = Program.CurrentUser.UserName,
                    RoleId = int.Parse(lookUpRole.EditValue.ToString())
                };
                string DATA =  jsonSerialization.SerializeToString<User>(user);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl, DATA);
                
                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record save successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save record.", "Error");
            }
        }

        private void updateUserDate()
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ USER_UPDATE_RAPI;

            User user = new User()
            {
                Id = _user.Id,
                UserName = txtUserName.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = FinancialPlanner.Common.DataEncrypterDecrypter.CryptoEngine.Encrypt(txtPassword.Text),
                UpdatedOn = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")),
                UpdatedBy = Program.CurrentUser.Id,
                UpdatedByUserName = Program.CurrentUser.UserName,
                RoleId = int.Parse(lookUpRole.EditValue.ToString())
            };

            string DATA =  jsonSerialization.SerializeToString<User>(user);

            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string json = client.UploadString(apiurl,"PUT", DATA);
            if (json != null)
            {
                var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                if (resultObject.IsSuccess)
                {
                    MessageBox.Show("Record save successfully.");
                }
            }
        }
    }
}
