using DevExpress.XtraEditors;
using FinancialPlanner.Common;
using FinancialPlanner.Common.Model;
using FinancialPlannerServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlannerClient.Clients
{
    public class ClientService
    {
        private const string CLIENTS_GETALL = "Client/Get";
        private const string CLIENT_BY_ID = "Client/GetById?id={0}";
        public IList<Client> GetAll()
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl + "/" + CLIENTS_GETALL;

            RestAPIExecutor restApiExecutor = new RestAPIExecutor();

            var restResult = restApiExecutor.Execute<List<Client>>(apiurl, null, "GET");

            if (jsonSerialization.IsValidJson(restResult.ToString()))
            {
                return jsonSerialization.DeserializeFromString<List<Client>>(restResult.ToString());
            }
            else
            {
                XtraMessageBox.Show(restResult.ToString(), "Error");
                return null;
            }
        }
        public Client GetClientById(int clientId)
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl + "/" + string.Format(CLIENT_BY_ID,clientId);

            RestAPIExecutor restApiExecutor = new RestAPIExecutor();

            var restResult = restApiExecutor.Execute<Client>(apiurl, null, "GET");

            if (jsonSerialization.IsValidJson(restResult.ToString()))
            {
                return jsonSerialization.DeserializeFromString<Client>(restResult.ToString());
            }
            else
            {
                XtraMessageBox.Show(restResult.ToString(), "Error");
                return null;
            }
        }
    }
}
