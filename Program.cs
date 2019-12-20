using FinancialPlanner.Common.Model;
using FinancialPlanner.Common.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer
{
    static class Program
    {
        private static string _webServiceUrl;
        public static User CurrentUser;
        public static Role CurrentUserRolePermission;
        public static string WebServiceUrl
        {
            get { return _webServiceUrl; }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _webServiceUrl = getWebServiceUrl();
            Application.Run(new frmLogin());
        }

        private static string getWebServiceUrl()
        {
            //return "http://localhost:37882/api";
            return System.Configuration.ConfigurationSettings.AppSettings.Get("webserviceurl");
        }
    }
}
