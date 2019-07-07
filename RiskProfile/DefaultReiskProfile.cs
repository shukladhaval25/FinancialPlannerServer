using FinancialPlanner.Common;
using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System;

namespace FinancialPlannerServer.RiskProfile
{
    public class RiskProfileInfo
    {
        const string  RISKPROFILERETURN_DETAIL_GETALL ="RiskProfileReturn/GetAllDetails?id={0}";

        DataSet _dsRisProfile;
        DataTable _dtRiskProfileMaster;
        DataTable _dtRiskProfileReturn;
        const int DEFAULT_YEARS  = 80;

        public RiskProfileInfo()
        {
            _dtRiskProfileMaster = new DataTable();
            _dtRiskProfileReturn = new DataTable();
        }

        //public DataTable GetDefaultRiskProfileReturn()
        //{
        //    setDefaultColumnsForRiskPrifleReturn();
        //    setDefaultValueBasedonRemainingYears();
        //    return _dtRiskProfileReturn;
        //}

        public DataTable GetDefaultRiskProfileReturn(RiskProfiledReturnMaster riskProfiledReturnMaster)
        {
            if (riskProfiledReturnMaster != null)
            {
                setDefaultColumnsForRiskPrifleReturn();
                generateRiskProfileTable(riskProfiledReturnMaster);
                return _dtRiskProfileReturn;
            }
            return null;
        }

        private void generateRiskProfileTable(RiskProfiledReturnMaster riskProfiledReturnMaster)
        {
            for (int i = 0; i <= riskProfiledReturnMaster.MaxYear; i++)
            {
                RiskProfiledReturn riskProfileReturn = new RiskProfiledReturn();
                riskProfileReturn.YearRemaining = i;
                DataRow drRiskProfRetun = _dtRiskProfileReturn.NewRow();
                drRiskProfRetun["YearRemaining"] = riskProfileReturn.YearRemaining;

                float foreingInvRatio,foreingInvReturn;
                float equityInvRatio,equityInvReturn;
                float debtInvRatio,debtInvReturn;

                if (riskProfileReturn.YearRemaining <= riskProfiledReturnMaster.ThresholdYear)
                {
                    drRiskProfRetun["ForeingInvestmentRatio"] = riskProfiledReturnMaster.PreForeingInvestmentRatio;
                    foreingInvRatio = riskProfiledReturnMaster.PreForeingInvestmentRatio;
                    drRiskProfRetun["EquityInvestementRatio"] = riskProfiledReturnMaster.PreEquityInvestmentRatio;
                    equityInvRatio = riskProfiledReturnMaster.PreEquityInvestmentRatio;
                    drRiskProfRetun["DebtInvestementRatio"] = riskProfiledReturnMaster.PreDebtInvestmentRatio;
                    debtInvRatio = riskProfiledReturnMaster.PreDebtInvestmentRatio;
                }
                else
                {
                    drRiskProfRetun["ForeingInvestmentRatio"] = riskProfiledReturnMaster.PostForeingInvestmentRatio;
                    foreingInvRatio = riskProfiledReturnMaster.PostForeingInvestmentRatio;
                    drRiskProfRetun["EquityInvestementRatio"] = riskProfiledReturnMaster.PostEquityInvestmentRatio;
                    equityInvRatio = riskProfiledReturnMaster.PostEquityInvestmentRatio;
                    drRiskProfRetun["DebtInvestementRatio"] = riskProfiledReturnMaster.PostDebtInvestmentRatio;
                    debtInvRatio = riskProfiledReturnMaster.PostDebtInvestmentRatio;
                }

                drRiskProfRetun["ForeingInvestementReaturn"] = riskProfiledReturnMaster.ForeingInvestmentReturn;
                foreingInvReturn = riskProfiledReturnMaster.ForeingInvestmentReturn;
                drRiskProfRetun["EquityInvestementReturn"] = riskProfiledReturnMaster.EquityInvestmentReturn;
                equityInvReturn = riskProfiledReturnMaster.EquityInvestmentReturn;
                drRiskProfRetun["DebtInvestementReturn"] = riskProfiledReturnMaster.DebtInvestmentReturn;
                debtInvReturn = riskProfiledReturnMaster.DebtInvestmentReturn;

                drRiskProfRetun["AverageInvestementReturn"] = (((foreingInvRatio * foreingInvReturn) / 100) + ((equityInvRatio * equityInvReturn) / 100) + ((debtInvRatio * debtInvReturn) / 100));
                _dtRiskProfileReturn.Rows.Add(drRiskProfRetun);
            }
        }

        public DataTable GetRiskProfileReturnById(int id)
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ string.Format(RISKPROFILERETURN_DETAIL_GETALL,id);

            RestAPIExecutor restApiExecutor = new RestAPIExecutor();

            var restResult = restApiExecutor.Execute<List<RiskProfiledReturn>>(apiurl, null, "GET");

            if (jsonSerialization.IsValidJson(restResult.ToString()))
            {
                var riskProfileColleection = jsonSerialization.DeserializeFromString<List<RiskProfiledReturn>>(restResult.ToString());
                _dtRiskProfileReturn.Clear();
                _dtRiskProfileReturn = ListtoDataTable.ToDataTable(riskProfileColleection);
            }
            else
                MessageBox.Show(restResult.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return _dtRiskProfileReturn;
        }

        public decimal GetRiskProfileReturnRatio(int RiskProfileId,int yearRemaining)
        {
            if (yearRemaining == 0)
                return 0;

            if (_dtRiskProfileReturn.Rows.Count == 0)
                GetRiskProfileReturnById(RiskProfileId);

            DataRow[] drs = _dtRiskProfileReturn.Select(string.Format("RiskProfileId ='{0}' and YearRemaining = '{1}'", RiskProfileId, yearRemaining));
            if (drs != null)
            {
                foreach (var dr in drs)
                {
                    return decimal.Parse(dr["AverageInvestemetReturn"].ToString());
                }
            }
            return 0;
        }

        //private void setDefaultValueBasedonRemainingYears()
        //{            
        //    for(int i =0; i<= DEFAULT_YEARS;i++)
        //    {
        //        RiskProfiledReturn riskProfileReturn = new RiskProfiledReturn();
        //        riskProfileReturn.YearRemaining = i;
        //        riskProfileReturn.ForeingInvestmentRatio = 0;
        //        riskProfileReturn.EquityInvestementRatio = 0;
        //        riskProfileReturn.DebtInvestementRatio = 0;
        //        riskProfileReturn.ForeingInvestementReaturn = 0;
        //        riskProfileReturn.EquityInvestementReturn = 0;
        //        riskProfileReturn.DebtInvestementReturn = 0;

        //        DataRow drRiskProfRetun = _dtRiskProfileReturn.NewRow();
        //        drRiskProfRetun["YearRemaining"] = riskProfileReturn.YearRemaining;
        //        drRiskProfRetun["ForeingInvestmentRatio"] = riskProfileReturn.ForeingInvestmentRatio;
        //        drRiskProfRetun["EquityInvestementRatio"] = riskProfileReturn.EquityInvestementRatio;
        //        drRiskProfRetun["DebtInvestementRatio"] = riskProfileReturn.DebtInvestementRatio;
        //        drRiskProfRetun["ForeingInvestementReaturn"] = riskProfileReturn.ForeingInvestementReaturn;
        //        drRiskProfRetun["EquityInvestementReturn"] = riskProfileReturn.EquityInvestementReturn;
        //        drRiskProfRetun["DebtInvestementReturn"] = riskProfileReturn.DebtInvestementReturn;
        //        drRiskProfRetun["AverageInvestementReturn"] = riskProfileReturn.AverageInvestemetReturn;
        //        _dtRiskProfileReturn.Rows.Add(drRiskProfRetun);
        //    }           
        //}

        private void setDefaultColumnsForRiskPrifleReturn()
        {
            _dtRiskProfileReturn.Columns.Clear();
            _dtRiskProfileReturn.Clear();
            DataColumn dcId = new DataColumn("ID",typeof(System.Int16));
            _dtRiskProfileReturn.Columns.Add(dcId);

            DataColumn dcRiskProfileId = new DataColumn("RiskProfileId",typeof(System.Int16));
            _dtRiskProfileReturn.Columns.Add(dcRiskProfileId);

            DataColumn dcYearRemaining = new DataColumn("YearRemaining",typeof(System.Int16));
            _dtRiskProfileReturn.Columns.Add(dcYearRemaining);

            DataColumn dcforeingInvestmentRatio = new DataColumn("ForeingInvestmentRatio",typeof(System.Decimal));
            _dtRiskProfileReturn.Columns.Add(dcforeingInvestmentRatio);

            DataColumn dcEquityInvestmentRatio = new DataColumn("EquityInvestementRatio",typeof(System.Decimal));
            _dtRiskProfileReturn.Columns.Add(dcEquityInvestmentRatio);

            DataColumn dcDebtInvestmentRatio = new DataColumn("DebtInvestementRatio",typeof(System.Decimal));
            _dtRiskProfileReturn.Columns.Add(dcDebtInvestmentRatio);

            DataColumn dcforeingInvestmentReturnRatio = new DataColumn("ForeingInvestementReaturn",typeof(System.Decimal));
            _dtRiskProfileReturn.Columns.Add(dcforeingInvestmentReturnRatio);

            DataColumn dcEquityInvestmentReturnRatio = new DataColumn("EquityInvestementReturn",typeof(System.Decimal));
            _dtRiskProfileReturn.Columns.Add(dcEquityInvestmentReturnRatio);

            DataColumn dcDebtInvestmentReturnRatio = new DataColumn("DebtInvestementReturn",typeof(System.Decimal));
            _dtRiskProfileReturn.Columns.Add(dcDebtInvestmentReturnRatio);

            DataColumn dcAvgReturn = new DataColumn("AverageInvestementReturn", typeof(System.Decimal));

            //DataColumn dcAvgReturn = new DataColumn("AverageInvestementReturn",typeof(System.Decimal),
            //    ("((ForeingInvestmentRatio * ForeingInvestementReaturn) / 100) + " +
            //      "((EquityInvestementRatio * EquityInvestementReturn) / 100)  + " +
            //      "((DebtInvestementRatio * DebtInvestementReturn) / 100)"));
            dcAvgReturn.ReadOnly = false;
            _dtRiskProfileReturn.Columns.Add(dcAvgReturn);

        }

    }
}
