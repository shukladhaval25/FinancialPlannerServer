using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace FinancialPlannerServer.Common
{
    public class LoanInfo
    {
        const string GET_ALL_LOAN_API = "Loan/GetAll?plannerId={0}";
        const string GET_ALL_BY_ID_API = "Loan/GetById?id={0}&plannerId={1}";
        const string ADD_LOAN_API = "Loan/Add";
        const string UPDATE_LOAN_API = "Loan/Update";
        const string DELETE_LOAN_API = "Loan/Delete";
        DataTable _dtLoan;
        internal IList<Loan> GetAll(int plannerId)
        {
            IList<Loan> loanObj = new List<Loan>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(GET_ALL_LOAN_API,plannerId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<Loan>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    loanObj = jsonSerialization.DeserializeFromString<IList<Loan>>(restResult.ToString());
                }
                return loanObj;
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

        internal Loan GetById(int id, int plannerId)
        {
            Loan loanObj = new Loan();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ string.Format(GET_ALL_BY_ID_API,id,plannerId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<Loan>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    loanObj = jsonSerialization.DeserializeFromString<Loan>(restResult.ToString());
                }
                return loanObj;
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

        internal void FillGrid(DataGridView dtGridLoan)
        {
            dtGridLoan.Columns[0].Visible = false;
            dtGridLoan.Columns[1].Visible = false;
            dtGridLoan.Columns[2].HeaderText = "Type Of Loan";
            dtGridLoan.Columns[3].HeaderText = "Outstanding Amount";
            dtGridLoan.Columns[4].HeaderText = "EMIs";
            dtGridLoan.Columns[5].HeaderText = "Interest Rate";
            dtGridLoan.Columns[6].HeaderText = "Term left (Months)";
            dtGridLoan.Columns[7].HeaderText = "No. EMIs payable (Year)";
            dtGridLoan.Columns[8].HeaderText = "Description";
            dtGridLoan.Columns["CreatedOn"].Visible = false;
            dtGridLoan.Columns["CreatedBy"].Visible = false;
            dtGridLoan.Columns["UpdatedOn"].Visible = false;
            dtGridLoan.Columns["UpdatedBy"].Visible = false;
            dtGridLoan.Columns["UpdatedByUserName"].Visible = false;
            dtGridLoan.Columns["MachineName"].Visible = false;
        }
        internal Loan GetLonInfo(DataGridView dtGridLoan, DataTable dtLoan)
        {
            _dtLoan = dtLoan;
            return convertSelectedRowDataToLoan(dtGridLoan);
        }
        private void LogDebug(string methodName, Exception ex)
        {
            DebuggerLogInfo debuggerInfo = new DebuggerLogInfo();
            debuggerInfo.ClassName = this.GetType().Name;
            debuggerInfo.Method = methodName;
            debuggerInfo.ExceptionInfo = ex;
            Logger.LogDebug(debuggerInfo);
        }

        internal bool Add(Loan loan)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ ADD_LOAN_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<Loan>(apiurl, loan, "POST");
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
        internal bool Update(Loan loan)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ UPDATE_LOAN_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<Loan>(apiurl, loan, "POST");

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
        internal bool Delete(Loan loan)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl +"/"+ DELETE_LOAN_API;
                RestAPIExecutor restApiExecutor = new RestAPIExecutor();
                var restResult = restApiExecutor.Execute<Loan>(apiurl, loan, "POST");

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
        private Loan convertSelectedRowDataToLoan(DataGridView dtGridLoan)
        {
            if (dtGridLoan.SelectedRows.Count >= 1)
            {
                Loan loan = new Loan();
                DataRow dr = getSelectedDataRowForLoan(dtGridLoan);
                if (dr != null)
                {
                    loan.Id = int.Parse(dr.Field<string>("ID"));
                    loan.Pid = int.Parse(dr.Field<string>("PID"));
                    loan.TypeOfLoan = dr.Field<string>("TypeOfLoan");
                    loan.OutstandingAmt = double.Parse(dr.Field<string>("OutstandingAmt"));
                    loan.Emis = int.Parse(dr.Field<string>("EMIs"));
                    loan.InterestRate = decimal.Parse(dr.Field<string>("InterestRate"));
                    loan.TermLeftInMonths = int.Parse(dr.Field<string>("TermLeftInMonths"));
                    loan.NoEmisPayableUntilYear = int.Parse(dr.Field<string>("NoEMISPayableUntilYear"));
                    loan.Description = dr.Field<string>("Description");
                    if ((dr["LoanStartDate"] != DBNull.Value))
                    {
                        loan.LoanStartDate = DateTime.Parse(dr.Field<string>("LoanStartDate"));
                    }
                    return loan;
                }
            }
            return null;
        }

        private DataRow getSelectedDataRowForLoan(DataGridView dtGridLoan)
        {
            if (dtGridLoan.SelectedRows.Count >= 1)
            {
                int selectedRowIndex = dtGridLoan.SelectedRows[0].Index;
                if (dtGridLoan.SelectedRows[0].Cells["ID"].Value != System.DBNull.Value)
                {
                    int selectedUserId = int.Parse(dtGridLoan.SelectedRows[0].Cells["ID"].Value.ToString());
                    DataRow[] rows = _dtLoan.Select("Id ='" + selectedUserId +"'");
                    foreach (DataRow dr in rows)
                    {
                        return dr;
                    }
                }
            }
            return null;
        }
    }
}