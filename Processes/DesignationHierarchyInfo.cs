using FinancialPlanner.Common;
using FinancialPlanner.Common.Planning;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.Processes
{
    public class DesignationHierarchyInfo
    {
        const string GET_DESIGNATIONHIERARCHY = "DesignationHierarchy/GetAll";
        const string GET_LINKSUB_STEPS = "ProcessAction/GetLinkSubSteps?primaryStepId={0}";

        const string ADD_DESINGATIONHIERARCHY = "DesignationHierarchy/Add";
        const string UPDATE_DESIGNATIONHIERARCHY = "DesignationHierarchy/Update";

        const string DELETE_DESIGNATIONHIERARCHY = "DesignationHierarchy/Delete?Id={0}";

        internal IList<DesignationHierarchy> GetAll()
        {
            IList<DesignationHierarchy> primarySteps = new List<DesignationHierarchy>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + GET_DESIGNATIONHIERARCHY;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<PrimaryStep>>(apiurl, null, "GET");
                if (restResult != null)
                {
                    if (jsonSerialization.IsValidJson(restResult.ToString()))
                    {
                        primarySteps = jsonSerialization.DeserializeFromString<IList<DesignationHierarchy>>(restResult.ToString());
                    }
                }
                return primarySteps;
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
                StackTrace st = new StackTrace();
                StackFrame sf = st.GetFrame(0);
                MethodBase currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return null;
            }
        }

        internal bool Delete(int id)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + string.Format(DELETE_DESIGNATIONHIERARCHY, id);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<int>(apiurl, id, "DELETE");

                return true;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace();
                StackFrame sf = st.GetFrame(0);
                MethodBase currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                return false;
            }
        }

        internal bool Add(DesignationHierarchy designationHierarchy)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + ADD_DESINGATIONHIERARCHY;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<DesignationHierarchy>(apiurl, designationHierarchy, "POST");

                return true;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace();
                StackFrame sf = st.GetFrame(0);
                MethodBase currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                throw ex;
                //return false;
            }
        }

        internal bool Update(DesignationHierarchy designationHierarchy)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + UPDATE_DESIGNATIONHIERARCHY;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<DesignationHierarchy>(apiurl, designationHierarchy, "POST");

                return true;
            }
            catch (Exception ex)
            {
                StackTrace st = new StackTrace();
                StackFrame sf = st.GetFrame(0);
                MethodBase currentMethodName = sf.GetMethod();
                LogDebug(currentMethodName.Name, ex);
                throw ex;
                //return false;
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
    }
}
