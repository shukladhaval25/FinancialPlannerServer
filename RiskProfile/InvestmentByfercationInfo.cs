using FinancialPlanner.Common;
using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model.RiskProfile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.RiskProfile
{
    public class InvestmentByfercationInfo
    {
        DataTable _dtInvestmentSegment;
        private readonly string GET_ALL = "RiskProfileInvestmentSegment/GetAll?riskProfileId={0}";
        private readonly string ADD_INVESTMENTSEGMENT_API = "RiskProfileInvestmentSegment/Add";
        private readonly string UPDATE_InvestmentSegment_API = "RiskProfileInvestmentSegment/Update";
        private readonly string DELETE_InvestmentSegment_API = "RiskProfileInvestmentSegment/Delete";

        private readonly string GET_ALL_RECOMMENDEDSCHEME = "RecommendedSchemes/GetAll?investmentsegmentId={0}";
        private readonly string ADD_RECOMMENDEDSCHEME = "RecommendedSchemes/Add";
        private readonly string UPDATE_RECOMMENDEDSCHEME = "RecommendedSchemes/Update";
        private readonly string DELETE_RECOMMENDEDSCHEME = "RecommendedSchemes/Delete";

        private readonly string GET_MODEL_PORTFILIO = "RiskProfileInvestmentSegment/ModelPortfolio?riskProfileId={0}";

        public void FillInvestmentBifurcationData(int riskProfileId, string investmentType, DataGridView dataGrid)
        {
            if (_dtInvestmentSegment != null)
                _dtInvestmentSegment.Clear();
            IList<InvestmentSegment> InvestmentSegmentObj = new List<InvestmentSegment>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(GET_ALL,riskProfileId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<InvestmentSegment>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    InvestmentSegmentObj = jsonSerialization.DeserializeFromString<IList<InvestmentSegment>>(restResult.ToString());
                }
                if (InvestmentSegmentObj != null)
                {
                    _dtInvestmentSegment = ListtoDataTable.ToDataTable(InvestmentSegmentObj.ToList());
                }
                fillGrid(investmentType, dataGrid);
            }
            catch (System.Net.WebException webException)
            {
                if (webException.Message.Equals("The remote server returned an error: (401) Unauthorized."))
                {
                    MessageBox.Show("You session has been expired. Please Login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void fillGrid(string investmentType, DataGridView dataGrid)
        {
            DataRow[] drs = _dtInvestmentSegment.Select("InvestmentType ='" + investmentType + "'");
            if (drs.Count() > 0)
            {
                dataGrid.DataSource = drs.CopyToDataTable();
                setGridview(dataGrid);
            }
            else
                dataGrid.DataSource = null;
        }

        private void setGridview(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.ColumnCount; i++)
            {
                if (dataGrid.Columns[i].Name == "SegmentName" || dataGrid.Columns[i].Name == "SegmentRatio")
                {
                    dataGrid.Columns[i].Visible = true;
                    dataGrid.Columns[i].ReadOnly = true;
                }
                else
                    dataGrid.Columns[i].Visible = false;
            }

            dataGrid.Columns["SegmentName"].HeaderText = "Segment";
            dataGrid.Columns["SegmentRatio"].HeaderText = "Ratio (%)";
        }

        public DataRow GetSelectedDataRowForSegment(int selectedSegmentId)
        {
            DataRow[] rows = _dtInvestmentSegment.Select("Id ='" + selectedSegmentId +"'");
            foreach (DataRow dr in rows)
            {
                return dr;
            }
            return null;
        }

        private void LogDebug(string methodName, Exception ex)
        {
            DebuggerLogInfo debuggerInfo = new DebuggerLogInfo();
            debuggerInfo.ClassName = this.GetType().Name;
            debuggerInfo.Method = methodName;
            debuggerInfo.ExceptionInfo = ex;
            Logger.LogDebug(debuggerInfo);
        }

        internal bool Add(InvestmentSegment invSegment)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ ADD_INVESTMENTSEGMENT_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<InvestmentSegment>(apiurl, invSegment, "POST");
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

        internal bool Update(InvestmentSegment invSegment)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ UPDATE_InvestmentSegment_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<InvestmentSegment>(apiurl, invSegment, "POST");
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

        internal bool Delete(InvestmentSegment invSegment)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ DELETE_InvestmentSegment_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<InvestmentSegment>(apiurl, invSegment, "POST");
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

        internal DataTable GetSchemes(int investmentsegmentId)
        {
            DataTable dtSchemes = new DataTable();
            IList<RecommendedSchemes> recommendedSchemesObj = new List<RecommendedSchemes>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(GET_ALL_RECOMMENDEDSCHEME,investmentsegmentId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<RecommendedSchemes>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    recommendedSchemesObj = jsonSerialization.DeserializeFromString<IList<RecommendedSchemes>>(restResult.ToString());
                }
                if (recommendedSchemesObj != null)
                {
                    dtSchemes = ListtoDataTable.ToDataTable(recommendedSchemesObj.ToList());
                }                
            }
            catch (System.Net.WebException webException)
            {
                if (webException.Message.Equals("The remote server returned an error: (401) Unauthorized."))
                {
                    MessageBox.Show("You session has been expired. Please Login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace ();
                StackFrame sf = st.GetFrame (0);
                MethodBase  currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
            }
            return dtSchemes;
        }

        internal bool Add(RecommendedSchemes recommendedSchemes)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ ADD_RECOMMENDEDSCHEME;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<RecommendedSchemes>(apiurl, recommendedSchemes, "POST");
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
        internal bool Update(RecommendedSchemes recommendedSchemes)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ UPDATE_RECOMMENDEDSCHEME;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<RecommendedSchemes>(apiurl, recommendedSchemes, "POST");
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
        internal bool Delete(RecommendedSchemes recommendedSchemes)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ DELETE_RECOMMENDEDSCHEME;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<RecommendedSchemes>(apiurl, recommendedSchemes, "POST");
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

        public IList<ModelPortfolio> GetModelPortfolio(int riskProfileId)
        {
            if (_dtInvestmentSegment != null)
                _dtInvestmentSegment.Clear();
            IList<ModelPortfolio> modelPortfolios = new List<ModelPortfolio>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + string.Format(GET_MODEL_PORTFILIO, riskProfileId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<ModelPortfolio>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    modelPortfolios = jsonSerialization.DeserializeFromString<IList<ModelPortfolio>>(restResult.ToString());
                }
                return modelPortfolios;
            }
            catch (System.Net.WebException webException)
            {
                if (webException.Message.Equals("The remote server returned an error: (401) Unauthorized."))
                {
                    MessageBox.Show("You session has been expired. Please Login again.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return modelPortfolios;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace();
                StackFrame sf = st.GetFrame(0);
                MethodBase currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return modelPortfolios;
            }
        }
    }
}
