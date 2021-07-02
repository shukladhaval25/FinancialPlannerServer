using DevExpress.XtraEditors;
using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Model.RiskProfile;
using FinancialPlanner.Common.Model.ScoreCalculation;
using FinancialPlannerServer.ScoreRangeCalcuation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.RiskProfile
{
    public partial class frmRiskProfileReturn : Form
    {
        const string ADD_RISKPROFILE_RETURN = "RiskProfileReturn/Add";
        const string UPDATE_RISKPROFILE_RETURN = "RiskProfileReturn/Update";
        const string DELETE_RISKPROFILE_RETURN = "RiskProfileReturn/Delete";

        int _riskProfileId = 0;
        RiskProfiledReturnMaster _riskProfiledReturnMaster;
        RiskProfileInfo _defaultRiskProfile = new RiskProfileInfo();
        DataTable _dtRiskProfileReturn;
        DataTable _dtRecommendedScheme;
        DataTable _dtScoreRange;
        InvestmentByfercationInfo invBifurcationIno = new InvestmentByfercationInfo();
        public frmRiskProfileReturn()
        {
            InitializeComponent();
        }
        public frmRiskProfileReturn(RiskProfiledReturnMaster riskProfiledReturnMaster)
        {
            InitializeComponent();
            _riskProfiledReturnMaster = riskProfiledReturnMaster;
            loadRiskProfileMasterData();
            loadRislProfileReturnDetails();
            loadScoreRangeDetails();
        }

        private void loadScoreRangeDetails()
        {
            _dtScoreRange = new ScoreRangeInfo().GetScoreRange(_riskProfiledReturnMaster.Id);
            vGridScoreRange.DataSource = _dtScoreRange;
            if (_dtScoreRange == null)
            {
                _dtScoreRange = new DataTable();

            }
        }

        private void loadRislProfileReturnDetails()
        {
            _dtRiskProfileReturn = _defaultRiskProfile.GetRiskProfileReturnById(_riskProfileId);
            dtGridRiskProfileDetails.DataSource = _dtRiskProfileReturn;
            setRiskProfileDetailsGrid();
        }

        private void loadRiskProfileMasterData()
        {
            _riskProfileId = _riskProfiledReturnMaster.Id;
            txtRiskProfileName.Tag = _riskProfiledReturnMaster.Id.ToString();
            txtRiskProfileName.Text = _riskProfiledReturnMaster.Name;
            numThresholdYear.Value = _riskProfiledReturnMaster.ThresholdYear;
            numMaxYear.Value = _riskProfiledReturnMaster.MaxYear;
            txtPreForeignInvRation.Text = _riskProfiledReturnMaster.PreForeingInvestmentRatio.ToString();
            txtPreEquityInvRatio.Text = _riskProfiledReturnMaster.PreEquityInvestmentRatio.ToString();
            txtPreDebtInvRatio.Text = _riskProfiledReturnMaster.PreDebtInvestmentRatio.ToString();
            txtPostForeingInvRatio.Text = _riskProfiledReturnMaster.PostForeingInvestmentRatio.ToString();
            txtPostEquityInvRatio.Text = _riskProfiledReturnMaster.PostEquityInvestmentRatio.ToString();
            txtPostDebtInvRatio.Text = _riskProfiledReturnMaster.PostDebtInvestmentRatio.ToString();
            txtForeingReturn.Text = _riskProfiledReturnMaster.ForeingInvestmentReturn.ToString();
            txtEquityInvReturn.Text = _riskProfiledReturnMaster.EquityInvestmentReturn.ToString();
            txtDebtInvReturn.Text = _riskProfiledReturnMaster.DebtInvestmentReturn.ToString();
            txtDescription.Text = _riskProfiledReturnMaster.Description;
        }

        private void frmRiskProfileReturn_Load(object sender, EventArgs e)
        {
            if (_riskProfileId == 0)
            {
                txtRiskProfileName.Text = "";
                txtDescription.Text = "";
                numThresholdYear.Value = 5;
                numMaxYear.Value = 70;
                txtPreForeignInvRation.Text = "0";
                txtPreEquityInvRatio.Text = "20";
                txtPreDebtInvRatio.Text = "80";
                txtPostForeingInvRatio.Text = "0";
                txtPostEquityInvRatio.Text = "80";
                txtPostDebtInvRatio.Text = "20";
                txtForeingReturn.Text = "0";
                txtEquityInvReturn.Text = "13";
                txtDebtInvReturn.Text = "8";
            }
        }

        private void setRiskProfileDetailsGrid()
        {
            dtGridRiskProfileDetails.Columns[0].Visible = false;
            dtGridRiskProfileDetails.Columns[1].Visible = false;
            dtGridRiskProfileDetails.Columns[2].ReadOnly = true;
            dtGridRiskProfileDetails.Columns[9].ReadOnly = false;
            dtGridRiskProfileDetails.Columns[2].HeaderText = "Reaming Year";
            dtGridRiskProfileDetails.Columns[3].HeaderText = "Commodities Investment (%)";
            dtGridRiskProfileDetails.Columns[4].HeaderText = "Equity Investment (%)";
            dtGridRiskProfileDetails.Columns[5].HeaderText = "Debt Investment (%)";
            dtGridRiskProfileDetails.Columns[6].HeaderText = "Foreign Return (%)";
            dtGridRiskProfileDetails.Columns[7].HeaderText = "Equity Return (%)";
            dtGridRiskProfileDetails.Columns[8].HeaderText = "Debt Return (%)";
            dtGridRiskProfileDetails.Columns[9].HeaderText = "Average Return (%)";
        }

        private void dtGridRiskProfileDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void LogDebug(string methodName, Exception ex)
        {
            DebuggerLogInfo debuggerInfo = new DebuggerLogInfo();
            debuggerInfo.ClassName = this.GetType().Name;
            debuggerInfo.Method = methodName;
            debuggerInfo.ExceptionInfo = ex;
            Logger.LogDebug(debuggerInfo);
        }
        private decimal getAverageReturn(int rowIndex)
        {
            decimal foreingInv;
            decimal.TryParse(
                dtGridRiskProfileDetails.Rows[rowIndex].Cells["ForeingInvestmentRatio"].Value.ToString(),
                out foreingInv);

            decimal equityInv;
            decimal.TryParse(
                dtGridRiskProfileDetails.Rows[rowIndex].Cells["EquityInvestementRatio"].Value.ToString(),
                out equityInv);

            decimal debtInv;
            decimal.TryParse(
                dtGridRiskProfileDetails.Rows[rowIndex].Cells["DebtInvestementRatio"].Value.ToString(),
                out debtInv);

            decimal foreingReturn;
            decimal.TryParse(
                dtGridRiskProfileDetails.Rows[rowIndex].Cells["ForeingInvestementReaturn"].Value.ToString(),
                out foreingReturn);

            decimal equityReturn;
            decimal.TryParse(
                dtGridRiskProfileDetails.Rows[rowIndex].Cells["EquityInvestementReturn"].Value.ToString(),
                out equityReturn);

            decimal debtReturn;
            decimal.TryParse(
                dtGridRiskProfileDetails.Rows[rowIndex].Cells["DebtInvestementReturn"].Value.ToString(),
                out debtReturn);

            decimal _foreingValue =  (foreingInv * foreingReturn) / 100;
            decimal _equityvalue =  (equityInv * equityReturn) / 100;
            decimal _debtValue =   (debtInv * debtReturn) / 100;

            decimal averageReturn = _foreingValue + _equityvalue + _debtValue;
            return averageReturn;
        }

        private void dtGridRiskProfileDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (e.ColumnIndex == dtGridRiskProfileDetails.Columns["ForeingInvestmentRatio"].Index ||
            //    e.ColumnIndex == dtGridRiskProfileDetails.Columns["EquityInvestementRatio"].Index ||
            //    e.ColumnIndex == dtGridRiskProfileDetails.Columns["DebtInvestementRatio"].Index ||
            //    e.ColumnIndex == dtGridRiskProfileDetails.Columns["ForeingInvestementReaturn"].Index ||
            //    e.ColumnIndex == dtGridRiskProfileDetails.Columns["EquityInvestementReturn"].Index ||
            //    e.ColumnIndex == dtGridRiskProfileDetails.Columns["DebtInvestementReturn"].Index)
            //{
            //    dtGridRiskProfileDetails.Rows[e.RowIndex].ErrorText = "";
            //    decimal newDecimal;
            //    if (dtGridRiskProfileDetails.Rows[e.RowIndex].IsNewRow) { return; }
            //    if (!decimal.TryParse(e.FormattedValue.ToString(),
            //        out newDecimal) || ((newDecimal < 0) || (newDecimal > 100)))
            //    {
            //        e.Cancel = true;
            //        dtGridRiskProfileDetails.Rows[e.RowIndex].ErrorText = "the value must be a between 0 to 100";
            //    }                
            //}
        }

        private void btnPersonalDetailSave_Click(object sender, EventArgs e)
        {
            RiskProfiledReturnMaster riskProfileMaster = new RiskProfiledReturnMaster();
            riskProfileMaster = getRiskProfileData();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = string.Empty;
                if (riskProfileMaster.Id == 0)
                    apiurl = Program.WebServiceUrl + "/" + ADD_RISKPROFILE_RETURN;
                else
                    apiurl = Program.WebServiceUrl + "/" + UPDATE_RISKPROFILE_RETURN;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<RiskProfiledReturnMaster>(apiurl, riskProfileMaster, "POST");
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogDebug(ex);
            }
        }

        private RiskProfiledReturnMaster getRiskProfileData()
        {
            RiskProfiledReturnMaster rpr = new RiskProfiledReturnMaster();
            rpr.Id = _riskProfileId;
            rpr.Name = txtRiskProfileName.Text;
            rpr.ThresholdYear = int.Parse(numThresholdYear.Value.ToString());
            rpr.MaxYear = int.Parse(numMaxYear.Value.ToString());
            rpr.PreForeingInvestmentRatio = float.Parse(txtPreForeignInvRation.Text);
            rpr.PreEquityInvestmentRatio = float.Parse(txtPreEquityInvRatio.Text);
            rpr.PreDebtInvestmentRatio = float.Parse(txtPreDebtInvRatio.Text);

            rpr.PostForeingInvestmentRatio = float.Parse(txtPostForeingInvRatio.Text);
            rpr.PostEquityInvestmentRatio = float.Parse(txtPostEquityInvRatio.Text);
            rpr.PostDebtInvestmentRatio = float.Parse(txtPostDebtInvRatio.Text);

            rpr.ForeingInvestmentReturn = float.Parse(txtForeingReturn.Text);
            rpr.EquityInvestmentReturn = float.Parse(txtEquityInvReturn.Text);
            rpr.DebtInvestmentReturn = float.Parse(txtDebtInvReturn.Text);
            rpr.Description = txtDescription.Text;
            rpr.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            rpr.UpdatedBy = Program.CurrentUser.Id;
            rpr.UpdatedByUserName = Program.CurrentUser.UserName;
            rpr.MachineName = System.Environment.MachineName;
            rpr.RiskProfileReturn = new List<RiskProfiledReturn>();
            if (_dtRiskProfileReturn != null)
            {
                foreach (DataRow dr in _dtRiskProfileReturn.Rows)
                {
                    RiskProfiledReturn riskProfile = new RiskProfiledReturn();
                    //riskProfile.Id = dr.Field<int>("ID");
                    riskProfile.RiskProfileId = rpr.Id;
                    riskProfile.YearRemaining = int.Parse(dr["YearRemaining"].ToString());
                    riskProfile.ForeingInvestmentRatio = decimal.Parse(dr["ForeingInvestmentRatio"].ToString());
                    riskProfile.EquityInvestementRatio = decimal.Parse(dr["EquityInvestementRatio"].ToString());
                    riskProfile.DebtInvestementRatio = decimal.Parse(dr["DebtInvestementRatio"].ToString());

                    riskProfile.ForeingInvestementReaturn = decimal.Parse(dr["ForeingInvestementReaturn"].ToString());
                    riskProfile.EquityInvestementReturn = decimal.Parse(dr["EquityInvestementReturn"].ToString());
                    riskProfile.DebtInvestementReturn = decimal.Parse(dr["DebtInvestementReturn"].ToString());
                    rpr.RiskProfileReturn.Add(riskProfile);
                }
            }
            return rpr;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtGridRiskProfileDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtGridRiskProfileDetails.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                {
                    if (e.ColumnIndex != 0 && e.ColumnIndex != 1 & e.ColumnIndex != 2)
                    {
                        decimal averageReturn = getAverageReturn(e.RowIndex);
                        
                        dtGridRiskProfileDetails.Rows[e.RowIndex].Cells[9].Value = averageReturn;

                        DataRow[] drs = _dtRiskProfileReturn.Select("YearRemaining = " + dtGridRiskProfileDetails.Rows[e.RowIndex].Cells[2].Value);

                        drs[0]["ForeingInvestmentRatio"] = dtGridRiskProfileDetails.Rows[e.RowIndex].Cells["ForeingInvestmentRatio"].Value.ToString();
                        drs[0]["EquityInvestementRatio"] = dtGridRiskProfileDetails.Rows[e.RowIndex].Cells["EquityInvestementRatio"].Value.ToString();
                        drs[0]["DebtInvestementRatio"] = dtGridRiskProfileDetails.Rows[e.RowIndex].Cells["DebtInvestementRatio"].Value.ToString();

                        drs[0]["ForeingInvestementReaturn"] = dtGridRiskProfileDetails.Rows[e.RowIndex].Cells["ForeingInvestementReaturn"].Value.ToString();
                        drs[0]["EquityInvestementReturn"] = dtGridRiskProfileDetails.Rows[e.RowIndex].Cells["EquityInvestementReturn"].Value.ToString();
                        drs[0]["DebtInvestementReturn"] = dtGridRiskProfileDetails.Rows[e.RowIndex].Cells["DebtInvestementReturn"].Value.ToString();

                        drs[0]["AverageInvestementReturn"] = averageReturn;
                        drs[0].AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
            }
        }

        private void btnShowCalculation_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                _riskProfiledReturnMaster = getRiskProfileData();
                calculateReiskProfileReturnDetails();
            }
        }

        private void calculateReiskProfileReturnDetails()
        {
            if (isValidData())
            {
                _dtRiskProfileReturn = _defaultRiskProfile.GetDefaultRiskProfileReturn(_riskProfiledReturnMaster);
                dtGridRiskProfileDetails.DataSource = _dtRiskProfileReturn;
                setRiskProfileDetailsGrid();
            }
        }

        private bool isValidData()
        {
            if (string.IsNullOrEmpty(txtPreForeignInvRation.Text) ||
                string.IsNullOrEmpty(txtPreEquityInvRatio.Text) ||
                string.IsNullOrEmpty(txtPreDebtInvRatio.Text) ||
                string.IsNullOrEmpty(txtPostForeingInvRatio.Text) ||
                string.IsNullOrEmpty(txtPostEquityInvRatio.Text) ||
                string.IsNullOrEmpty(txtPostDebtInvRatio.Text) ||
                string.IsNullOrEmpty(txtForeingReturn.Text) ||
                string.IsNullOrEmpty(txtEquityInvReturn.Text) ||
                string.IsNullOrEmpty(txtDebtInvReturn.Text))
            {
                MessageBox.Show("Invalid value for one of the field. Please enter valid data.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void txtPreForeignInvRation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPreForeignInvRation_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
                float.Parse(txtPreForeignInvRation.Text),
                float.Parse(txtPreEquityInvRatio.Text),
                float.Parse(txtPreDebtInvRatio.Text)))
            {
                txtPreForeignInvRation.Focus();
            }

        }
        private bool isValidTotalRatio(float forignValue, float equityValue, float debtValue)
        {
            if ((forignValue + equityValue + debtValue) > 100)
            {
                MessageBox.Show("Total should not more then 100.", "Exceed Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtPreEquityInvRatio_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
                float.Parse(txtPreForeignInvRation.Text),
                float.Parse(txtPreEquityInvRatio.Text),
                float.Parse(txtPreDebtInvRatio.Text)))
            {
                txtPreEquityInvRatio.Focus();
            }
        }

        private void txtPreDebtInvRatio_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
                float.Parse(txtPreForeignInvRation.Text),
                float.Parse(txtPreEquityInvRatio.Text),
                float.Parse(txtPreDebtInvRatio.Text)))
            {
                txtPreDebtInvRatio.Focus();
            }
        }

        private void txtPostForeingInvRatio_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
               float.Parse(txtPostForeingInvRatio.Text),
               float.Parse(txtPostEquityInvRatio.Text),
               float.Parse(txtPostDebtInvRatio.Text)))
            {
                txtPostForeingInvRatio.Focus();
            }
        }

        private void txtPostEquityInvRatio_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
             float.Parse(txtPostForeingInvRatio.Text),
             float.Parse(txtPostEquityInvRatio.Text),
             float.Parse(txtPostDebtInvRatio.Text)))
            {
                txtPostEquityInvRatio.Focus();
            }
        }

        private void txtPostDebtInvRatio_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
             float.Parse(txtPostForeingInvRatio.Text),
             float.Parse(txtPostEquityInvRatio.Text),
             float.Parse(txtPostDebtInvRatio.Text)))
            {
                txtPostDebtInvRatio.Focus();
            }
        }

        private void txtForeingReturn_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
             float.Parse(txtForeingReturn.Text),
             float.Parse(txtEquityInvReturn.Text),
             float.Parse(txtDebtInvReturn.Text)))
            {
                txtForeingReturn.Focus();
            }
        }

        private void txtEquityInvReturn_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
            float.Parse(txtForeingReturn.Text),
            float.Parse(txtEquityInvReturn.Text),
            float.Parse(txtDebtInvReturn.Text)))
            {
                txtEquityInvReturn.Focus();
            }
        }

        private void txtDebtInvReturn_Leave(object sender, EventArgs e)
        {
            if (!isValidTotalRatio(
            float.Parse(txtForeingReturn.Text),
            float.Parse(txtEquityInvReturn.Text),
            float.Parse(txtDebtInvReturn.Text)))
            {
                txtDebtInvReturn.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpSegment.Enabled = true;
            setDefaultValueSegment();
        }
    
        private void rdoEquity_CheckedChanged(object sender, EventArgs e)
        {
            fillSegmentInfo();
        }

        private void fillSegmentInfo()
        {
            lstSchemeName.Items.Clear();
            if (rdoEquity.Checked)
                fillInvestmentBifurcationData(rdoEquity.Text);
            if (rdoGold.Checked)
                fillInvestmentBifurcationData(rdoGold.Text);
            if (rdoDebt.Checked)
                fillInvestmentBifurcationData(rdoDebt.Text);
        }

        private void fillInvestmentBifurcationData(string investmentType)
        {            
            invBifurcationIno.FillInvestmentBifurcationData(_riskProfileId, investmentType, dtGridSegment);
        }

        private void tabControlRiskProfile_Selecting(object sender, TabControlCancelEventArgs e)
        {
            try
            {
                switch (tabControlRiskProfile.SelectedTab.Name)
                {
                    case "tpageInvBifercation":
                        fillSegmentInfo();
                        break;
                }
            }
            catch(Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                MessageBox.Show("Error -> " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSegment_Click(object sender, EventArgs e)
        {
            grpSegment.Enabled = true;           
        }

        private void dtGridSegment_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGridSegment.SelectedRows.Count >= 1)
            {
                int selectedRowIndex = dtGridSegment.SelectedRows[0].Index;
                if (dtGridSegment.SelectedRows[0].Cells["ID"].Value != System.DBNull.Value)
                {
                    int selectedSegmentId = int.Parse(dtGridSegment.SelectedRows[0].Cells["ID"].Value.ToString());

                    DataRow dr = invBifurcationIno.GetSelectedDataRowForSegment(selectedSegmentId);
                    if (dr != null)
                        displayInvestmentSegment(dr);
                    else
                        setDefaultValueSegment();
                }
            }
        }

        private void setDefaultValueSegment()
        {
            txtSegmentName.Tag = "0";
            txtSegmentName.Text = "";
            txtSegmentRatio.Text = "0";
        }

        private void displayInvestmentSegment(DataRow dr)
        {
            if (dr != null)
            {
                txtSegmentName.Tag = dr.Field<string>("ID");
                txtSegmentName.Text = dr.Field<string>("SegmentName");
                txtSegmentRatio.Text = dr.Field<string>("SegmentRatio");
                fillupSchemes();
            }                           
        }

        private void fillupSchemes()
        {
            lstSchemeName.Items.Clear();
            txtSchemeName.Tag = "";
            txtSchemeName.Text = "";
            if (txtSegmentName.Tag != null)
            {
                _dtRecommendedScheme = invBifurcationIno.GetSchemes(int.Parse(txtSegmentName.Tag.ToString()));
                if (_dtRecommendedScheme != null && _dtRecommendedScheme.Rows.Count > 0)
                {
                    foreach (DataRow dr in _dtRecommendedScheme.Rows)
                    {
                        lstSchemeName.Items.Add(dr["SchemeName"]);
                    }
                }
            }
        }

        private void txtSegmentRatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCancelSegment_Click(object sender, EventArgs e)
        {
            grpSegment.Enabled = false;
        }

        private void rdoGold_CheckedChanged(object sender, EventArgs e)
        {
            fillSegmentInfo();
        }

        private void rdoDebt_CheckedChanged(object sender, EventArgs e)
        {
            fillSegmentInfo();
        }

        private void btnSaveSegment_Click(object sender, EventArgs e)
        {
            InvestmentSegment invSegment = getInvestmentSegmentData();
            bool isSaved = false;

            if (invSegment != null && invSegment.Id == 0)
                isSaved = invBifurcationIno.Add(invSegment);
            else
            
                isSaved = invBifurcationIno.Update(invSegment);

            if (isSaved)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillSegmentInfo();
                grpSegment.Enabled = false;
            }
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private InvestmentSegment getInvestmentSegmentData()
        {
            InvestmentSegment invSeg = new InvestmentSegment();
            invSeg.RiskProfileId = _riskProfileId;
            invSeg.Id = int.Parse(txtSegmentName.Tag.ToString());
            invSeg.SegmentName = txtSegmentName.Text;
            if (rdoEquity.Checked)
                invSeg.InvestmentType = rdoEquity.Text;
            if (rdoGold.Checked)
                invSeg.InvestmentType = rdoGold.Text;
            if (rdoDebt.Checked)
                invSeg.InvestmentType = rdoDebt.Text;            
            invSeg.SegmentRatio = string.IsNullOrEmpty(txtSegmentRatio.Text) ? 0 : float.Parse(txtSegmentRatio.Text);
            invSeg.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            invSeg.CreatedBy = Program.CurrentUser.Id;
            invSeg.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            invSeg.UpdatedBy = Program.CurrentUser.Id;
            invSeg.MachineName = Environment.MachineName;
            return invSeg;
        }

        private void btnDeleteSegment_Click(object sender, EventArgs e)
        {
            if (dtGridSegment.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    InvestmentSegment invSegment = getInvestmentSegmentData();
                    invBifurcationIno.Delete(invSegment);
                    fillSegmentInfo();
                }
            }
        }

        private void lstSchemeName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstSchemeName.SelectedItems.Count > 0)
            {
                txtSchemeName.Text = lstSchemeName.Text;
                DataRow[] drs = _dtRecommendedScheme.Select("SchemeName = '" +  txtSchemeName.Text + "'");
                if (drs.Count() > 0)
                {
                    txtSchemeName.Tag = drs[0]["ID"].ToString();
                }
            }
        }

        private void btnAddScheme_Click(object sender, EventArgs e)
        {
            grpScheme.Enabled = true;
            txtSchemeName.Tag = "0";
            txtSchemeName.Text = "";
        }

        private void btnSchemeSave_Click(object sender, EventArgs e)
        {
            RecommendedSchemes recommendedSchemes = getRecommendedSchemesData();
            bool isSaved = false;

            if (recommendedSchemes != null && recommendedSchemes.Id == 0)
                isSaved = invBifurcationIno.Add(recommendedSchemes);
            else
                isSaved = invBifurcationIno.Update(recommendedSchemes);

            if (isSaved)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillupSchemes();
                grpScheme.Enabled = false;
            }
            else
                MessageBox.Show("Unable to save record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private RecommendedSchemes getRecommendedSchemesData()
        {
            RecommendedSchemes recScheme = new RecommendedSchemes();
            recScheme.Id = int.Parse(txtSchemeName.Tag.ToString());
            recScheme.InvestmentSegmentID = int.Parse(txtSegmentName.Tag.ToString());
            recScheme.SchemeName = txtSchemeName.Text;
            recScheme.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            recScheme.CreatedBy = Program.CurrentUser.Id;
            recScheme.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            recScheme.UpdatedBy = Program.CurrentUser.Id;
            recScheme.UpdatedByUserName = Program.CurrentUser.UserName;
            recScheme.MachineName = System.Environment.MachineName;
            return recScheme;
        }

        private void btnSchemeCancel_Click(object sender, EventArgs e)
        {
            grpScheme.Enabled = false;
        }

        private void btnEditScheme_Click(object sender, EventArgs e)
        {
            if (lstSchemeName.SelectedItems.Count > 0)
            {
                grpScheme.Enabled = true;
            }
        }

        private void btnDeleteScheme_Click(object sender, EventArgs e)
        {
            if (lstSchemeName.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RecommendedSchemes recommendedSchemes = getRecommendedSchemesData();
                    invBifurcationIno.Delete(recommendedSchemes);
                    fillupSchemes();
                }
            }
        }

        private void txtRiskProfileName_TextChanged(object sender, EventArgs e)
        {
            lblRiskProfileName.Text = txtRiskProfileName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_riskProfileId == 0)
            {
                XtraMessageBox.Show("You can not save score range without saving risk profile first. Please save risk profile and try again.", "Not Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<ScoreRange> scores = new List<ScoreRange>();
            foreach (DataRow dataRow in _dtScoreRange.Rows)
            {
                ScoreRange score = new ScoreRange();
                score.Id = (dataRow["Id"] != DBNull.Value) ? int.Parse(dataRow["Id"].ToString()) : 0;
                score.RiskProfileId = int.Parse(txtRiskProfileName.Tag.ToString());
                score.FromRange  = (dataRow["FromRange"]== DBNull.Value? 0 : float.Parse(dataRow["FromRange"].ToString()));
                score.ToRange = dataRow["ToRange"] != DBNull.Value ? float.Parse(dataRow["ToRange"].ToString()): 0;
                score.Equity = dataRow["Equity"] != DBNull.Value ? float.Parse(dataRow["Equity"].ToString()) : 0;
                score.Debt = dataRow["Debt"] != DBNull.Value ? float.Parse(dataRow["Debt"].ToString()) : 0;
                score.Gold = dataRow["Gold"] != DBNull.Value ? float.Parse(dataRow["Gold"].ToString()) : 0;
                scores.Add(score);
            }
            ScoreRangeInfo scoreInfo = new ScoreRangeInfo();
            bool blnSave = scoreInfo.Add(scores);
            if (blnSave)
            {
                MessageBox.Show("Record save successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadScoreRangeDetails();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            vGridScoreRange.AddNewRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = vGridScoreRange.FocusedRecord;
            if (XtraMessageBox.Show("Are you sure, you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vGridScoreRange.GetCellValue(vGridScoreRange.GetRowByFieldName("Id"), rowIndex) != null)
                {
                    int Id = int.Parse(vGridScoreRange.GetCellValue(vGridScoreRange.GetRowByFieldName("Id"), rowIndex).ToString());
                    ScoreRange score = new ScoreRange();
                    score.Id = Id;
                    ScoreRangeInfo  scoreInfo = new ScoreRangeInfo();
                    scoreInfo.Delete(score);
                    loadScoreRangeDetails();
                }
            }
        }
    }
}
