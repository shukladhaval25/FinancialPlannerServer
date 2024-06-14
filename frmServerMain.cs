using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlannerServer.Processes;
using FinancialPlannerServer.QuarterlyReview;
using FinancialPlannerServer.ScoreCalcuation;
using FinancialPlannerServer.Security;
using FinancialPlannerServer.UserInfo;
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
        private Security.RolesSecurity _rolesSecurity;
        private EmailJob.EmailScheduleList _emailScheduleList;
        private RiskProfile.frmRiskProfiledReturnList _riskProfileList;
        private ScoresEntry ScoresEntry;
        private ScoreMaster scoreMaster;
        private Permission permission;
        private ProcessView processView;
        private DesignationHierarchyView designationHierarchyView;
        private frmCompany _company;
        private IList<User> users;
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

        private void tbtnSecurity_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(_rolesSecurity))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(_rolesSecurity)].Show();
            }
            else
            {
                if (_rolesSecurity == null || _rolesSecurity.IsDisposed)
                    _rolesSecurity = new Security.RolesSecurity();

                _rolesSecurity.TopLevel = false;
                pnlContainer.Controls.Add(_rolesSecurity);
                _rolesSecurity.Dock = DockStyle.Fill;
                _rolesSecurity.Show();
            }
        }

        private void companyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(_company))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(_company)].Show();
            }
            else
            {
                if (_company == null || _company.IsDisposed)
                    _company = new frmCompany();

                _company.TopLevel = false;
                _company.BringToFront();
                pnlContainer.Controls.Add(_company);
                _company.Dock = DockStyle.Fill;
                _company.Show();
            }
        }

        private void tbtnRiskProfile_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(_riskProfileList))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(_riskProfileList)].Show();
            }
            else
            {
                if (_riskProfileList == null || _riskProfileList.IsDisposed)
                    _riskProfileList = new RiskProfile.frmRiskProfiledReturnList();

                _riskProfileList.TopLevel = false;
                _riskProfileList.BringToFront();
                pnlContainer.Controls.Add(_riskProfileList);
                _riskProfileList.Dock = DockStyle.Fill;
                _riskProfileList.Show();
            }
        }

        private void tbtnRoles_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(permission))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(permission)].Show();
            }
            else
            {
                if (permission == null || permission.IsDisposed)
                    permission = new Permission();

                permission.TopLevel = false;
                pnlContainer.Controls.Add(permission);
                permission.Dock = DockStyle.Fill;
                permission.Show();
            }
        }

        private void quaterlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void QuarterlyReviewSheetMenuItem_Click(object sender, EventArgs e)
        {
            frmQuartelyReviewReportParams frmQuartelyReview = new frmQuartelyReviewReportParams();
            frmQuartelyReview.Show();
        }

        private void frmServerMain_Load(object sender, EventArgs e)
        {
            setMailServerSettingFromConfiguration();
            users = new UserServiceInfo().GetUsers();
            diagramOrgChartController1.DataSource = users;

        }
        private void setMailServerSettingFromConfiguration()
        {
            MailManager mailManager = new MailManager();
            string host = FinancialPlanner.Common.EmailManager.MailServer.HostName;
            //if (!FinancialPlanner.Common.EmailManager.MailServer.HostName)
        }

        private void AnnualReviewSheetMenuItem_Click(object sender, EventArgs e)
        {
            frmAnnualReviewReportParams frmAnnualReviewReport = new frmAnnualReviewReportParams();
            frmAnnualReviewReport.Show();
        }

        private void tbtbScopeSetting_Click(object sender, EventArgs e)
        {
            
        }

        private void scoreMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreCalcuation.ScoreMaster scoreMaster = new ScoreCalcuation.ScoreMaster();
            scoreMaster.Show();

            if (pnlContainer.Controls.Contains(scoreMaster))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(scoreMaster)].Show();
            }
            else
            {
                if (scoreMaster == null || scoreMaster.IsDisposed)
                    scoreMaster = new ScoreMaster();

                scoreMaster.TopLevel = false;
                pnlContainer.Controls.Add(scoreMaster);
                scoreMaster.Dock = DockStyle.Fill;
                scoreMaster.Show();
            }
        }

        private void scoreEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pnlContainer.Controls.Contains(ScoresEntry ))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(ScoresEntry)].Show();
            }
            else
            {
                if (ScoresEntry == null || ScoresEntry.IsDisposed)
                    ScoresEntry = new ScoresEntry();

                ScoresEntry.TopLevel = false;
                pnlContainer.Controls.Add(ScoresEntry);
                ScoresEntry.Dock = DockStyle.Fill;
                ScoresEntry.Show();
            }
        }

        private void tbtnProcesses_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(processView))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(processView)].Show();
            }
            else
            {
                if (processView == null || processView.IsDisposed)
                    processView = new ProcessView();

                processView.TopLevel = false;
                pnlContainer.Controls.Add(processView);
                processView.Dock = DockStyle.Fill;
                processView.Show();
            }
        }

        private void tbtnDepartmentHierarchy_Click(object sender, EventArgs e)
        {
            if (pnlContainer.Controls.Contains(designationHierarchyView))
            {
                pnlContainer.Controls[pnlContainer.Controls.GetChildIndex(designationHierarchyView)].Show();
            }
            else
            {
                if (designationHierarchyView == null || designationHierarchyView.IsDisposed)
                    designationHierarchyView = new DesignationHierarchyView();

                designationHierarchyView.TopLevel = false;
                pnlContainer.Controls.Add(designationHierarchyView);
                designationHierarchyView.Dock = DockStyle.Fill;
                designationHierarchyView.Show();
            }
        }

        private void diagramControl_Click(object sender, EventArgs e)
        {

        }
    }
}
