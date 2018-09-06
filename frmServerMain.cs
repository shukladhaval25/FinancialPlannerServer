using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer
{
    public partial class frmServerMain : Form
    {
        private const string AUDITLOGCONTROLLER ="Activities/Add";
        private UserInfo.frmUseList _userlst;
        private frmSystemSetting _systemSetting;
        private AuditTrail.AuditTrail _auditTrail;
        private EmailJob.EmailScheduleList _emailScheduleList;
        public frmServerMain()
        {
            InitializeComponent();          
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(_userlst))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(_userlst)].Show();
            }
            else
            {
                if (_userlst == null || _userlst.IsDisposed)
                    _userlst = new UserInfo.frmUseList();

                _userlst.TopLevel = false;
                pnlContainer.Controls.Add(_userlst);
                _userlst.Dock = DockStyle.Fill;
                _userlst.Show();
            }
        }

        private void frmServerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                //string apiurl = Program.WebServiceUrl +"/"+ AUDITLOGCONTROLLER;

                //Activities activity = new Activities();
                //activity.ActivityTypeValue = ActivityType.Logout;
                //activity.EntryType = EntryStatus.Success;
                //activity.SourceType = Source.Server;
                //activity.HostName = Environment.MachineName;
                //activity.UserName = Program.CurrentUser.UserName;

                //string DATA =  jsonSerialization.SerializeToString<Activities>(activity);

                //WebClient client = new WebClient();
                //client.Headers["Content-type"] = "application/json";
                //client.Encoding = Encoding.UTF8;
                //string json = client.UploadString(apiurl, DATA);

                //if (json != null)
                //{
                //    var resultObject = jsonSerialization.DeserializeFromString<Result>(json);
                //}
            }
            catch (Exception ex)
            {
                Logger.LogDebug(ex.ToString());
            }
        }

        private void btnAuditTrailList_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(_auditTrail))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(_auditTrail)].Show();
            }
            else
            {
                if (_auditTrail == null || _auditTrail.IsDisposed)
                    _auditTrail = new AuditTrail.AuditTrail();

                _auditTrail.TopLevel = false;
                pnlContainer.Controls.Add(_auditTrail);
                _auditTrail.Dock = DockStyle.Fill;
                _auditTrail.Show();
            }
        }

        private void pnlContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            if (pnlContainer.Controls.Count > 2)
            {
                pnlContainer.Controls[0].Visible = false;
                pnlContainer.Controls[1].Visible = false;
            }

            pnlContainer.Controls[pnlContainer.Controls.Count - 1].Visible = true;
            pnlContainer.Controls[pnlContainer.Controls.Count - 1].BringToFront();
        }

        private void pnlContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (pnlContainer.Controls.Count == 2)
            {
                pnlContainer.Controls[0].Visible = true;
                pnlContainer.Controls[1].Visible = true;
            }
        }

        private void btnSystemSetting_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(_systemSetting))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(_systemSetting)].Show();
            }
            else
            {
                if (_systemSetting == null || _systemSetting.IsDisposed)
                    _systemSetting = new frmSystemSetting();

                _systemSetting.TopLevel = false;
                _systemSetting.BringToFront();
                pnlContainer.Controls.Add(_systemSetting);
                _systemSetting.Dock = DockStyle.Fill;
                _systemSetting.Show();
            }
        }

        private void tbtnEmail_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(_emailScheduleList))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(_emailScheduleList)].Show();
            }
            else
            {
                if (_emailScheduleList == null || _emailScheduleList.IsDisposed)
                    _emailScheduleList = new EmailJob.EmailScheduleList();

                _emailScheduleList.TopLevel = false;
                pnlContainer.Controls.Add(_emailScheduleList);
                _emailScheduleList.Dock = DockStyle.Fill;
                _emailScheduleList.Show();
            }
        }
    }
}
