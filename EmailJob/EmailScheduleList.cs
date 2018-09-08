using FinancialPlanner.Common;
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

namespace FinancialPlannerServer.EmailJob
{
    public partial class EmailScheduleList : Form
    {
        private const string GET_EMAILSCHEDULER_API = "EmailScheduler/Get";
        private const string DELETE_EMAILSCHEDULE_API = "EmailScheduler/Delete";

        private DataTable _dtEmailScheduler;
        public EmailScheduleList()
        {
            InitializeComponent();
        }

        private void EmailScheduleList_Load(object sender, EventArgs e)
        {
            _dtEmailScheduler = new DataTable();
            loadEmailSchedulerData();
        }

        private void loadEmailSchedulerData()
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ GET_EMAILSCHEDULER_API ;

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl);
            request.Method = "GET";
            String emailSchedulerResultJosn = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                emailSchedulerResultJosn = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            var emailSchedulerCollection = jsonSerialization.DeserializeFromString<Result<List<EmailScheduler>>>(emailSchedulerResultJosn);

            if (emailSchedulerCollection.Value != null)
            {
                _dtEmailScheduler = ListtoDataTable.ToDataTable(emailSchedulerCollection.Value);
                dataGridEmailScheduler.DataSource = _dtEmailScheduler;
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
            dataGridEmailScheduler.Columns["TypeImg"].Width = 50;
            dataGridEmailScheduler.Columns["ScheduleTitle"].Width = 200;
            dataGridEmailScheduler.Columns["ScheduleType"].Width = 100;
            dataGridEmailScheduler.Columns["ScheduleDetail"].Width = 350;
            dataGridEmailScheduler.Columns["StartDateTime"].Width = 150;
            dataGridEmailScheduler.Columns["NextRunDateTime"].Width = 150;
            dataGridEmailScheduler.Columns["UpdatedByUserName"].Width = 100;
        }

        private void setGridColumnsHeader()
        {
            dataGridEmailScheduler.Columns["ScheduleTitle"].HeaderText = "Title";
            dataGridEmailScheduler.Columns["ArticleGroupName"].HeaderText = "Article Group";
            dataGridEmailScheduler.Columns["ScheduleType"].HeaderText = "Recurrence";
            dataGridEmailScheduler.Columns["ScheduleDetail"].HeaderText = "Details";
            dataGridEmailScheduler.Columns["StartDateTime"].HeaderText = "Start Date";
            dataGridEmailScheduler.Columns["NextRunDateTime"].HeaderText = "Next Occurrence";
            dataGridEmailScheduler.Columns["UpdatedByUserName"].HeaderText = "Updated By";
        }

        private void hideGridColumns()
        {
            dataGridEmailScheduler.Columns["ID"].Visible = false;
            dataGridEmailScheduler.Columns["ArticleGroupId"].Visible = false;
            dataGridEmailScheduler.Columns["EmailSenderGroupId"].Visible = false;

            dataGridEmailScheduler.Columns["AllowRepeat"].Visible = false;
            dataGridEmailScheduler.Columns["WeekDays"].Visible = false;
            dataGridEmailScheduler.Columns["MonthDayInterval"].Visible = false;

            dataGridEmailScheduler.Columns["CreatedOn"].Visible = false;
            dataGridEmailScheduler.Columns["CreatedBy"].Visible = false;
            dataGridEmailScheduler.Columns["UpdatedOn"].Visible = false;
            dataGridEmailScheduler.Columns["UpdatedBy"].Visible = false;

            dataGridEmailScheduler.Columns["MachineName"].Visible = false;
        }

        private void dataGridEmailScheduler_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridEmailScheduler.Columns[e.ColumnIndex].Name == "TypeImg")
            {
                if (dataGridEmailScheduler.Rows[e.RowIndex].Cells["ScheduleType"].Value.ToString() == "Monthly")
                    e.Value = Properties.Resources.icons8_calendar_plus_16;
                if (dataGridEmailScheduler.Rows[e.RowIndex].Cells["ScheduleType"].Value.ToString() == "Weekly")
                    e.Value = Properties.Resources.icons8_week_view_16;
                if (dataGridEmailScheduler.Rows[e.RowIndex].Cells["ScheduleType"].Value.ToString() == "Daily")
                    e.Value = Properties.Resources.icons8_date_span_16;
            }
        }

        private void btnAddArticleInfo_Click(object sender, EventArgs e)
        {
            EmailScheduleInfo emailScheduleInfo = new EmailScheduleInfo();
            emailScheduleInfo.TopLevel = false;
            this.Parent.Controls.Add(emailScheduleInfo);
            emailScheduleInfo.Dock = DockStyle.Fill;
            emailScheduleInfo.Show();
        }

        private void btnEditArticleInfo_Click(object sender, EventArgs e)
        {
            EmailScheduler emailScheduler = new EmailScheduler();
            emailScheduler = convertSelectedRowDataToEmailScheduler();
            EmailScheduleInfo emailScheduleInfo = new EmailScheduleInfo(emailScheduler);
            emailScheduleInfo.TopLevel = false;
            this.Parent.Controls.Add(emailScheduleInfo);
            emailScheduleInfo.Dock = DockStyle.Fill;
            emailScheduleInfo.Show();
        }

        private EmailScheduler convertSelectedRowDataToEmailScheduler()
        {
            EmailScheduler emailScheduler = new EmailScheduler();
            if (dataGridEmailScheduler.SelectedRows.Count > 0)
            {
                DataRow dr = getSelectedDataRow();
                emailScheduler.ID = int.Parse( dr.Field<string>("ID"));
                emailScheduler.ArticleGroupId = int.Parse( dr.Field<string>("ArticleGroupId"));
                emailScheduler.ArticleGroupName = dr.Field<string>("ArticleGroupName");
                emailScheduler.EmailSenderGroupId = int.Parse( dr.Field<string>("EmailSenderGroupId"));
                emailScheduler.ScheduleTitle = dr.Field<string>("ScheduleTitle");
                emailScheduler.ScheduleType = (ScheduleOccurranceType) int.Parse(dr.Field<string>("ScheduleType"));
                //emailScheduler.MonthDayInterval = (dr["MonthDayInterval"]  == Null) ? ;
                emailScheduler.WeekDays = dr.Field<string>("WeekDays");
                emailScheduler.StartDateTime = DateTime.Parse(dr.Field<string>("StartDateTime"));
                emailScheduler.NextRunDateTime =DateTime.Parse(dr.Field<string>("NextRunDateTime"));
                emailScheduler.AllowRepeat = bool.Parse( dr.Field<string>("AllowRepeat"));
                emailScheduler.CreatedOn = DateTime.Parse( dr.Field<string>("CreatedOn"));
                emailScheduler.CreatedBy = int.Parse( dr.Field<string>("CreatedBy"));
                emailScheduler.UpdatedOn = DateTime.Parse(dr.Field<string>("UpdatedOn"));
                emailScheduler.UpdatedBy = int.Parse(dr.Field<string>("UpdatedBy"));
                emailScheduler.UpdatedByUserName = dr.Field<string>("UpdatedByUserName");
            }
            return emailScheduler;
        }


        private DataRow getSelectedDataRow()
        {
            int selectedRowIndex = dataGridEmailScheduler.SelectedRows[0].Index;
            int selectedUserId = int.Parse(dataGridEmailScheduler.SelectedRows[0].Cells["ID"].Value.ToString());
            DataRow[] rows = _dtEmailScheduler.Select("Id = " + selectedUserId);
            foreach (DataRow dr in rows)
            {
                return dr;
            }
            return null;
        }

        private void btnDeleteArticleInfo_Click(object sender, EventArgs e)
        {
            if (dataGridEmailScheduler.SelectedRows.Count > 0)
            {
                if (MessageBox.Show(
                    string.Format("Are you sure you want to remove {0}'s record? If you select 'Yes' then all associated conversation gets deleted.", dataGridEmailScheduler.SelectedRows[0].Cells[1].Value),
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    removeRecord();
                }
            }
            else
            {
                MessageBox.Show("Please select item to perform action.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeRecord()
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                EmailScheduler emailScheduler = convertSelectedRowDataToEmailScheduler();

                string apiurl = Program.WebServiceUrl +"/"+ DELETE_EMAILSCHEDULE_API;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<EmailScheduler>(apiurl, emailScheduler, "POST");

                MessageBox.Show("Record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataRow[] dr = _dtEmailScheduler.Select("ID =" + emailScheduler.ID);
                if (dr.Count() > 0)
                    dr[0].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

     }
}
