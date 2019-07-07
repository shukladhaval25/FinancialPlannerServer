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

namespace FinancialPlannerServer.RiskProfile
{
    public partial class frmRiskProfiledReturnList : Form
    {
        private const string RISKPROFILE_GETALL = "RiskProfileReturn/GetAll";
        private const string DELETE_RISKPROFILE = "RiskProfileReturn/Delete";
        DataTable _dtRiskProfile;

        public object DataBase { get; private set; }

        public frmRiskProfiledReturnList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRiskProfileReturn frmriskProfileReturn = new frmRiskProfileReturn();
            frmriskProfileReturn.TopLevel = false;
            splitContainer.Panel2.Controls.Add(frmriskProfileReturn);
            frmriskProfileReturn.Dock = DockStyle.Fill;
            frmriskProfileReturn.Show();
        }

        private void frmRiskProfiledReturnList_Load(object sender, EventArgs e)
        {
            loadRiskProfileData();
        }

        private void loadRiskProfileData()
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ RISKPROFILE_GETALL;

            RestAPIExecutor restApiExecutor = new RestAPIExecutor();

            var restResult = restApiExecutor.Execute<List<RiskProfiledReturnMaster>>(apiurl, null, "GET");

            if (jsonSerialization.IsValidJson(restResult.ToString()))
            {
                var riskProfileColleection = jsonSerialization.DeserializeFromString<List<RiskProfiledReturnMaster>>(restResult.ToString());
                _dtRiskProfile = ListtoDataTable.ToDataTable(riskProfileColleection);
                fillTreeviewData(_dtRiskProfile);
            }
            else
                MessageBox.Show(restResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fillTreeviewData(DataTable dtRiskPorifles)
        {
            trvList.Nodes.Clear();
            trvList.Nodes.Add("0", "Risk Profile", 5);
            foreach (DataRow dr in dtRiskPorifles.Rows)
            {
                TreeNode node = new TreeNode();
                node.Tag = dr.Field<string>("ID");
                node.Text = dr.Field<string>("Name");
                node.ImageIndex = 9;
                node.ToolTipText = dr.Field<string>("Name");
                trvList.Nodes[0].Nodes.Add(node);
            }
            trvList.ExpandAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (trvList.SelectedNode != null)
            {
                RiskProfiledReturnMaster riskProfileMaster = convertSelectedRowDataToRiskProfileMastser();
                frmRiskProfileReturn frmriskProfileReturn = new frmRiskProfileReturn(riskProfileMaster);
                frmriskProfileReturn.TopLevel = false;
                splitContainer.Panel2.Controls.Add(frmriskProfileReturn);
                frmriskProfileReturn.Dock = DockStyle.Fill;
                frmriskProfileReturn.Show();             
            }
        }

        private RiskProfiledReturnMaster convertSelectedRowDataToRiskProfileMastser()
        {
            RiskProfiledReturnMaster riskPrfile = new RiskProfiledReturnMaster();
            if (trvList.SelectedNode.Tag != null)
            {
                DataRow dr = getSelectedDataRow(int.Parse(trvList.SelectedNode.Tag.ToString()));
                if (dr != null)
                {                    
                    riskPrfile.Id = int.Parse(dr.Field<string>("Id"));
                    riskPrfile.Name = dr.Field<string>("Name");
                    riskPrfile.ThresholdYear = int.Parse(dr.Field<string>("ThresholdYear"));
                    riskPrfile.MaxYear = int.Parse(dr.Field<string>("MaxYear"));
                    riskPrfile.PreForeingInvestmentRatio = float.Parse(dr["PreForeingInvestmentRatio"].ToString());
                    riskPrfile.PreEquityInvestmentRatio = float.Parse(dr["PreEquityInvestmentRatio"].ToString());
                    riskPrfile.PreDebtInvestmentRatio = float.Parse(dr["PreDebtInvestmentRatio"].ToString());
                    riskPrfile.PostForeingInvestmentRatio = float.Parse(dr["PostForeingInvestmentRatio"].ToString());
                    riskPrfile.PostEquityInvestmentRatio = float.Parse(dr["PostEquityInvestmentRatio"].ToString());
                    riskPrfile.PostDebtInvestmentRatio = float.Parse(dr["PostDebtInvestmentRatio"].ToString());
                    riskPrfile.ForeingInvestmentReturn = float.Parse(dr["ForeingInvestmentReturn"].ToString());
                    riskPrfile.EquityInvestmentReturn = float.Parse(dr["EquityInvestmentReturn"].ToString());
                    riskPrfile.DebtInvestmentReturn = float.Parse(dr["DebtInvestmentReturn"].ToString());
                    riskPrfile.Description = dr.Field<string>("Description");
                    riskPrfile.UpdatedByUserName = Program.CurrentUser.UserName;
                    riskPrfile.RiskProfileReturn = new List<RiskProfiledReturn>();
                }
            }
            return riskPrfile;
        }

        private DataRow getSelectedDataRow(int id)
        {
            DataRow[] rows = _dtRiskProfile.Select("Id = '" + Convert.ToInt64(id) + "'");
            foreach (DataRow dr in rows)
            {
                return dr;
            }
            return null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (trvList.SelectedNode != null)
            {
                if (MessageBox.Show(
                    string.Format("Are you sure you want to remove {0}'s record? If you select 'Yes' then all associated conversation gets deleted.", trvList.SelectedNode.Text),
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    removeRecord(trvList.SelectedNode);
                    loadRiskProfileData();
                }
            }
            else
            {
                MessageBox.Show("Please select item to perform action.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeRecord(TreeNode selectedNode)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                RiskProfiledReturnMaster riskProfileMaster = convertSelectedRowDataToRiskProfileMastser();
                string apiurl = Program.WebServiceUrl +"/"+ DELETE_RISKPROFILE;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();                
                var restResult = restApiExecutor.Execute<RiskProfiledReturnMaster>(apiurl, riskProfileMaster, "POST");
            }
            catch(Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);                
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadRiskProfileData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable queryResultTable = new DataTable();
            string query = string.Format("Name like '%{0}%' or Description like '%{0}%'",txtSearch.Text);
            try
            {
                queryResultTable = _dtRiskProfile.Select(query).CopyToDataTable();
                fillTreeviewData(queryResultTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No matching records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
