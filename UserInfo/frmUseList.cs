using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
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
    public partial class frmUseList : Form
    {
        private const string USERAPI = "User";
        private const string USER_DELETE_API = "User/Remove";
        DataTable _dtUser;
        public frmUseList()
        {
            InitializeComponent();
        }

        private void frmUseList_Load(object sender, EventArgs e)
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ USERAPI;

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl);
            request.Method = "GET";
            String userResultJson = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                userResultJson = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            var userCollection = jsonSerialization.DeserializeFromString<Result<List<User>>>(userResultJson);

            if (userCollection.Value != null)
            {
                _dtUser = ListtoDataTable.ToDataTable(userCollection.Value);
                dtGridUser.DataSource = _dtUser;
                gridDisplaySetting();
            }
        }

        

        private void gridDisplaySetting()
        {
            hideGridColumns();
            setGridColumnsHeader();
            setGridColumnsWidth();
        }

        private void setGridColumnsWidth()
        {
            dtGridUser.Columns["UserName"].Width = 150;
            dtGridUser.Columns["FirstName"].Width = 200;
            dtGridUser.Columns["LastName"].Width = 200;
            dtGridUser.Columns["UpdatedOn"].Width = 200;
            dtGridUser.Columns["UpdatedByUserName"].Width = 200;
        }

        private void setGridColumnsHeader()
        {
            dtGridUser.Columns["UserName"].HeaderText = "User Name";
            dtGridUser.Columns["FirstName"].HeaderText = "First Name";
            dtGridUser.Columns["LastName"].HeaderText = "Last Name";
            dtGridUser.Columns["UpdatedOn"].HeaderText = "Updated On";
            dtGridUser.Columns["UpdatedByUserName"].HeaderText = "Updated By";
        }

        private void hideGridColumns()
        {
            dtGridUser.Columns["ID"].Visible = false;
            dtGridUser.Columns["Password"].Visible = false;
            dtGridUser.Columns["CreatedOn"].Visible = false;
            dtGridUser.Columns["CreatedBy"].Visible = false;
            dtGridUser.Columns["CreatedByUserName"].Visible = false;
            dtGridUser.Columns["UpdatedBy"].Visible = false;
            //dtGridUser.Columns["UpdatedByUserName"].Visible = false;
            dtGridUser.Columns["MachineName"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUser userinfo = new frmUser();
            userinfo.TopLevel = false;
            this.Parent.Controls.Add(userinfo);
            userinfo.Dock = DockStyle.Fill;
            userinfo.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            User user = convertSelectedRowDataToUser();
            frmUser userinfo = new frmUser(user);
            userinfo.TopLevel = false;
            this.Parent.Controls.Add(userinfo);
            userinfo.Dock = DockStyle.Fill;
            this.Visible = false;
            userinfo.Show();
        }

        private DataRow getSelectedDataRow()
        {
            int selectedRowIndex = dtGridUser.SelectedRows[0].Index;
            int selectedUserId = int.Parse(dtGridUser.SelectedRows[0].Cells["ID"].Value.ToString());
            DataRow[] rows = _dtUser.Select("Id = '" + selectedUserId + "'");
            foreach (DataRow dr in rows)
            {
                return dr;
            }
            return null;
        }
        private User convertSelectedRowDataToUser()
        {
            User user = new User();
            if (dtGridUser.SelectedRows.Count > 0)
            {
                DataRow dr = getSelectedDataRow();
                user.Id = int.Parse(dr.Field<string>("ID"));
                user.UserName = dr.Field<string>("UserName");
                user.FirstName = dr.Field<string>("FirstName");
                user.LastName = dr.Field<string>("LastName");
                user.Password = dr.Field<string>("Password");
               
               user.UpdatedByUserName = Program.CurrentUser.UserName;
                if (dr["RoleId"] != DBNull.Value)
                    user.RoleId = int.Parse(dr["RoleId"].ToString());
                if (dr["DesignationId"] != DBNull.Value)
                    user.DesignationId = int.Parse(dr["DesignationId"].ToString());
                if (dr["ReportToId"] != DBNull.Value)
                    user.ReportToId = int.Parse(dr["ReportToId"].ToString());
            }
            return user;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataRow dr = getSelectedDataRow();
                int selectedUserId = int.Parse(dtGridUser.SelectedRows[0].Cells["ID"].Value.ToString());
                if (selectedUserId == 1)
                {
                    MessageBox.Show("Admin user can not delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                User user = convertSelectedRowDataToUser();

                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + USER_DELETE_API;

                string DATA = jsonSerialization.SerializeToString<User>(user);

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.UploadString(apiurl, "POST", DATA);

                if (json != null)
                {
                    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                    if (resultObject.IsSuccess)
                    {
                        MessageBox.Show("Record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while deleting record.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmUseList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
