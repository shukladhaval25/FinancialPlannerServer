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
    public class ProcessesInfo
    {
        const string GET_PRIMARY_STEPS = "ProcessAction/GetPrimarySteps";
        const string GET_LINKSUB_STEPS = "ProcessAction/GetLinkSubSteps?primaryStepId={0}";
        const string GET_LINKSUB_STEPS_REFTASKID = "ProcessAction/GetLinkSubStepsByRefTaskId?refTaskId={0}";


        const string UPDATE_PRIMARY_STEPS = "ProcessAction/UpdatePrimaryStep";
        const string UPDATE_LINKSUB_STEPS = "ProcessAction/UpdateLinkSubStep";

        const string DELETE_PRIMARY_STEP = "ProcessAction/DeletePrimaryStep?primaryStepId={0}";
        const string DELETE_LINKSUB_STEP = "ProcessAction/DeleteLinkSubStep?linkSubStepId={0}";

        internal IList<PrimaryStep> GetPrimarySteps()
        {
            IList<PrimaryStep> primarySteps = new List<PrimaryStep>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + GET_PRIMARY_STEPS;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<PrimaryStep>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    primarySteps = jsonSerialization.DeserializeFromString<IList<PrimaryStep>>(restResult.ToString());
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

        internal IList<LinkSubStep> GetLinkSubSteps(int primaryStepId)
        {
            IList<LinkSubStep> linkSubSteps = new List<LinkSubStep>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + string.Format(GET_LINKSUB_STEPS,primaryStepId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<PrimaryStep>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    linkSubSteps = jsonSerialization.DeserializeFromString<IList<LinkSubStep>>(restResult.ToString());
                }
                return linkSubSteps;
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

        internal IList<LinkSubStep> GetLinkSubStepsByRefTaskId(string  refTaskId)
        {
            IList<LinkSubStep> linkSubSteps = new List<LinkSubStep>();
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + string.Format(GET_LINKSUB_STEPS_REFTASKID, refTaskId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<IList<PrimaryStep>>(apiurl, null, "GET");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    linkSubSteps = jsonSerialization.DeserializeFromString<IList<LinkSubStep>>(restResult.ToString());
                }
                return linkSubSteps;
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

        internal bool UpdatePrimaryStep(ref PrimaryStep primaryStep)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + UPDATE_PRIMARY_STEPS;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<PrimaryStep>(apiurl, primaryStep, "POST");

                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    primaryStep = jsonSerialization.DeserializeFromString<PrimaryStep>(restResult.ToString());
                }

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

        internal bool UpdateLinkSubStep(ref LinkSubStep linkSubStep)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + UPDATE_LINKSUB_STEPS;

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<LinkSubStep>(apiurl, linkSubStep, "POST");
                if (jsonSerialization.IsValidJson(restResult.ToString()))
                {
                    linkSubStep = jsonSerialization.DeserializeFromString<LinkSubStep>(restResult.ToString());
                }

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

        internal bool DeletePrimaryStep(int primaryStepId)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + string.Format(DELETE_PRIMARY_STEP, primaryStepId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<int>(apiurl, primaryStepId, "DELETE");

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

        internal bool DeleteLinkSubStep(int linkSubStepId)
        {
            try
            {
                FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
                string apiurl = Program.WebServiceUrl + "/" + string.Format(DELETE_LINKSUB_STEP, linkSubStepId);

                RestAPIExecutor restApiExecutor = new RestAPIExecutor();

                var restResult = restApiExecutor.Execute<int>(apiurl, linkSubStepId, "DELETE");

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
