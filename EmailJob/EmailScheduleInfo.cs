using FinancialPlanner.Common;
using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
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

namespace FinancialPlannerServer.EmailJob
{
    public partial class EmailScheduleInfo : Form
    {
        private const string EMAIL_ARTICLE_API = "EmailArticle/Get";
        private const string ADD_ARTICLE_API = "EmailScheduler/Add";
        private const string UPDATE_ARTICLE_API = "EmailScheduler/Update";

        private EmailScheduler _emailScheduler;

        private DataTable _dtArticle;
        public EmailScheduleInfo()
        {
            InitializeComponent();
            txtScheduleName.Tag = "0";
        }

        public EmailScheduleInfo(EmailScheduler emailScheduler)
        {
            InitializeComponent();
            _emailScheduler = emailScheduler;
        }

        private void cmbRecurrence_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRecurrence.Text == "Daily")
            {
                grpWeekly.Visible = false;
                grpMonthly.Visible = false;
            }
            else if (cmbRecurrence.Text == "Monthly")
            {
                grpWeekly.Visible = false;
                grpMonthly.Visible = true;
            }
            else if (cmbRecurrence.Text == "Weekly")
            {
                grpWeekly.Visible = true;
                grpMonthly.Visible = false;
            }
        }

        private void EmailScheduleInfo_Load(object sender, EventArgs e)
        {
            List<EmailArticle> emailArticles =   getEmailArticleGroup();
            _dtArticle = ListtoDataTable.ToDataTable(emailArticles);
            addDistinceGroupNode();
            if (_emailScheduler != null)
            {
                displayEmailSchedulerData();
            }
        }

        private void displayEmailSchedulerData()
        {
            txtScheduleName.Tag = _emailScheduler.ID;
            txtScheduleName.Text = _emailScheduler.ScheduleTitle;
            cmbArticleGroup.Text = getGroupByID(_emailScheduler.ArticleGroupId);
            dtStarDate.Value = _emailScheduler.StartDateTime;
            dtStartTime.Value = _emailScheduler.StartDateTime;
            cmbRecurrence.Text = getScheduleType( _emailScheduler.ScheduleType);
            numMonthDay.Value = (_emailScheduler.MonthDayInterval == null) ? 0 : decimal.Parse(_emailScheduler.MonthDayInterval.ToString());
            setdaysValue(_emailScheduler.WeekDays);
        }

        private void setdaysValue(string weekDays)
        {
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkTuesday.Checked = false;
            chkFriday.Checked = false;
            chkSaturday.Checked = false;
            chkSunday.Checked = false;
            if (weekDays.Contains(chkMonday.Text))
                chkMonday.Checked = true;
            if (weekDays.Contains(chkTuesday.Text))
                chkTuesday.Checked = true;
            if (weekDays.Contains(chkWednesday.Text))
                chkWednesday.Checked = true;
            if (weekDays.Contains(chkThursday.Text))
                chkThursday.Checked = true;
            if (weekDays.Contains(chkFriday.Text))
                chkFriday.Checked = true;
            if (weekDays.Contains(chkSaturday.Text))
                chkSaturday.Checked = true;
            if (weekDays.Contains(chkSunday.Text))
                chkSunday.Checked = true;
        }

        private string getScheduleType(ScheduleOccurranceType scheduleType)
        {
            if (scheduleType == ScheduleOccurranceType.Daily)
                return "Daily";
            if (scheduleType == ScheduleOccurranceType.Monthly)
                return "Monthly";
            if (scheduleType == ScheduleOccurranceType.Weekly)
                return "Weekly";
            return "";
        }

        private string getGroupByID(int articleGroupId)
        {
            DataRow[] drRows = _dtArticle.Select("GroupID = " + articleGroupId +" and ID = " + txtScheduleName.Tag.ToString());
            if (drRows != null)
                return drRows[0].Field<string>("GroupName").ToString();
            return null;
        }

        private void addDistinceGroupNode()
        {
            cmbArticleGroup.Items.Clear();
            var distinctRows = (from DataRow dRow in _dtArticle.Rows
                                select dRow["GroupName"] ).Distinct();
            foreach (string rowValue in distinctRows)
            {
                cmbArticleGroup.Items.Add(rowValue);
            }
        }
        private List<EmailArticle> getEmailArticleGroup()
        {
            List<EmailArticle> emailArticles = new List<EmailArticle>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(EMAIL_ARTICLE_API);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<EmailArticle>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    emailArticles = (List<EmailArticle>)jsonSerialization.DeserializeFromString<IList<EmailArticle>>(restResult.ToString());
                }

                return emailArticles;
            }
            catch (System.Net.WebException webException)
            {
                if (webException.Message.Equals("The remote server returned an error: (401) Unauthorized."))
                {
                    MessageBox.Show("You session has been expired. Please Login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return null;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return null;
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
        private void lnkArticles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (lnkArticles.Text == "Show Articles")
            {
                lnkArticles.Text = "Hide Articles";
                fillArticlesInfo();
                grpEmailArticles.Visible = true;
            }
            else
            {
                lnkArticles.Text = "Show Articles";
                grpEmailArticles.Visible = false;
            }
        }

        private void fillArticlesInfo()
        {
            lstArticles.Items.Clear();
            if (_dtArticle != null)
            {
                var distinctRows =  _dtArticle.Select("GroupName ='" + cmbArticleGroup.Text + "'");
                foreach (DataRow rowValue in distinctRows)
                {
                    lstArticles.Items.Add(rowValue.Field<string>("Title"));
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmailScheduler emailScheduler = getEmailSchedulerData();
            bool isSaved = saveEmailScheduler(emailScheduler);

            if (isSaved)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool saveEmailScheduler(EmailScheduler emailScheduler)
        {

            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ ADD_ARTICLE_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<EmailScheduler>(apiurl, emailScheduler, "POST");
                return true;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return false;
            }
        }

        private EmailScheduler getEmailSchedulerData()
        {
            EmailScheduler emailScheduler = new  EmailScheduler();
            emailScheduler.ID = int.Parse(txtScheduleName.Tag.ToString());
            emailScheduler.ScheduleTitle = txtScheduleName.Text; 
            emailScheduler.ArticleGroupId = getArticleGroupId(cmbArticleGroup.Text);
            emailScheduler.ArticleGroupName = cmbArticleGroup.Text;
            emailScheduler.EmailSenderGroupId = 0;
            emailScheduler.ScheduleType = (ScheduleOccurranceType) cmbRecurrence.SelectedIndex;
            emailScheduler.MonthDayInterval = int.Parse(numMonthDay.Value.ToString());
            emailScheduler.WeekDays = getWeekDaysValue();
            emailScheduler.StartDateTime = 
                new DateTime(dtStarDate.Value.Year , dtStarDate.Value.Month, dtStarDate.Value.Day ,
                dtStartTime.Value.Hour, dtStartTime.Value.Minute, dtStartTime.Value.Second);
            emailScheduler.NextRunDateTime = getNextFireTime(emailScheduler);
            emailScheduler.AllowRepeat = false;
            emailScheduler.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            emailScheduler.CreatedBy = Program.CurrentUser.Id;
            emailScheduler.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            emailScheduler.UpdatedBy = Program.CurrentUser.Id;
            emailScheduler.MachineName = Environment.MachineName;
            return emailScheduler;

        }

        private DateTime getNextFireTime(EmailScheduler emailScheduler)
        {
            switch (emailScheduler.ScheduleType)
            {
                case ScheduleOccurranceType.Daily:
                    return nextFireTimeByDaily(emailScheduler);
                case ScheduleOccurranceType.Monthly:
                    return nextFireTimeByMonthly(emailScheduler);
                case ScheduleOccurranceType.Weekly:
                    return nextFireTimeByWeekly(emailScheduler);
                default:
                    return emailScheduler.StartDateTime;
            }             
            throw new NotImplementedException();
        }

        private DateTime nextFireTimeByWeekly(EmailScheduler emailScheduler)
        {
            string[] weekDays = new string[] {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };

            if (emailScheduler.StartDateTime > DateTime.Now)
            {
               
                foreach (string day in weekDays)
                {
                    //if (chkMonday.Checked && )

                    //emailScheduler.StartDateTime.DayOfWeek == DayOfWeek.
                }

                //emailScheduler.StartDateTime.DayOfWeek = DayOfWeek.
            }
            return new DateTime();
        }

        private DateTime nextFireTimeByMonthly(EmailScheduler emailScheduler)
        {
            if (emailScheduler.StartDateTime > DateTime.Now)
            {
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, int.Parse(numMonthDay.Value.ToString()),
                    emailScheduler.StartDateTime.Hour,
                    emailScheduler.StartDateTime.Minute,
                    emailScheduler.StartDateTime.Second);
            }
            else
            {
                DateTime nextMonthFireDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, int.Parse(numMonthDay.Value.ToString()),
                    emailScheduler.StartDateTime.Hour,
                    emailScheduler.StartDateTime.Minute,
                    emailScheduler.StartDateTime.Second);
                return nextMonthFireDate.AddMonths(1);
            }               
        }

        private DateTime nextFireTimeByDaily(EmailScheduler emailScheduler)
        {
            if (emailScheduler.StartDateTime > DateTime.Now)
                return emailScheduler.StartDateTime;
            else
               return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                    emailScheduler.StartDateTime.Hour,
                    emailScheduler.StartDateTime.Minute,
                    emailScheduler.StartDateTime.Second).AddDays(1);
        }

        private string getWeekDaysValue()
        {
            string weekdays = string.Empty;
            string monday  = (chkMonday.Checked) ? chkMonday.Text : string.Empty;
            string thuesday  = chkTuesday.Checked ? chkTuesday.Text : string.Empty;
            string wednesday = chkWednesday.Checked ? chkWednesday.Text : string.Empty;
            string thursday = chkThursday.Checked ? chkThursday.Text : string.Empty;
            string friday = chkFriday.Checked ? chkFriday.Text : string.Empty;
            string saturday = chkSaturday.Checked ? chkSaturday.Text : string.Empty;
            string sunday = chkSunday.Checked ? chkSunday.Text : string.Empty;
            weekdays = monday + "," + thuesday + "," + wednesday + "," + thuesday + "," + friday + "," + saturday + "," + sunday;
            weekdays = (weekdays.StartsWith(",") ? weekdays.Substring(1) : weekdays);
            weekdays = (weekdays.EndsWith(",") ? weekdays.Substring(0, weekdays.Length - 1) : weekdays);
            weekdays = (weekdays.Equals(",,,,") ? string.Empty : weekdays);
            return weekdays;
        }

        private int getArticleGroupId(string text)
        {
            if (_dtArticle != null)
            {
                DataRow[] distinctRows =  _dtArticle.Select("GroupName ='" + cmbArticleGroup.Text + "'");
                return int.Parse(distinctRows[0].Field<string>("GroupId").ToString());
            }
            return 0;
        }
    }
}
