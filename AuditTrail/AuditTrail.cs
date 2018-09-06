using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.AuditTrail
{
    public partial class AuditTrail : Form
    {
        private const string AUDITLOGCONTROLLER ="Activities";
        DataTable _dtAuditTrail;
        public AuditTrail()
        {
            InitializeComponent();
        }

        private void AuditTrail_Load(object sender, EventArgs e)
        {
            FinancialPlanner.Common.JSONSerialization jsonSerialization = new FinancialPlanner.Common.JSONSerialization();
            string apiurl = Program.WebServiceUrl +"/"+ AUDITLOGCONTROLLER;

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiurl);
            request.Method = "GET";
            String auditTrailJson = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);
                auditTrailJson = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            var auditTrailCollection = jsonSerialization.DeserializeFromString<Result<List<Activities>>>(auditTrailJson);

            if (auditTrailCollection.Value != null)
            {
                _dtAuditTrail = ListtoDataTable.ToDataTable(auditTrailCollection.Value);
                dtGridAuditTrail.DataSource = _dtAuditTrail;
                gridDisplaySetting();
            }
        }

        private void gridDisplaySetting()
        {
            dtGridAuditTrail.Columns["ID"].Visible = false;
            dtGridAuditTrail.Columns["EntryType"].Visible = false;

            setGridColumnsHeader();
            setGridcolumnWidth();
        }

        private void setGridcolumnWidth()
        {
            dtGridAuditTrail.Columns["ActivityTypeValue"].Width = 200;
            dtGridAuditTrail.Columns["EventDescription"].Width = 400;
            dtGridAuditTrail.Columns["HostName"].Width = 150;
            dtGridAuditTrail.Columns["UserName"].Width = 100;
            dtGridAuditTrail.Columns["ActivityAt"].Width = 150;
            dtGridAuditTrail.Columns["TypeImg"].DisplayIndex = 0;
            dtGridAuditTrail.Columns["StatusImg"].DisplayIndex = 6;
        }

        private void setGridColumnsHeader()
        {
            dtGridAuditTrail.Columns["ActivityTypeValue"].HeaderText = "Type";
            dtGridAuditTrail.Columns["EventDescription"].HeaderText = "Description";
            dtGridAuditTrail.Columns["HostName"].HeaderText = "Computer";
            dtGridAuditTrail.Columns["UserName"].HeaderText = "User";
            dtGridAuditTrail.Columns["ActivityAt"].HeaderText = "Date and Time";
            dtGridAuditTrail.Columns["SourceType"].HeaderText = "Source";
        }

        private void dtGridAuditTrail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtGridAuditTrail.Columns[e.ColumnIndex].Name == "TypeImg")
            {
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["ActivityTypeValue"].Value.ToString().Contains("Login"))
                    e.Value = Properties.Resources.icons8_padlock_16;
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["ActivityTypeValue"].Value.ToString() == "Logout")
                    e.Value = Properties.Resources.icons8_lock_16;
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["ActivityTypeValue"].Value.ToString().Contains("Email"))
                    e.Value = Properties.Resources.icons8_group_message_16;
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["ActivityTypeValue"].Value.ToString().Contains("Prospect"))
                    e.Value = Properties.Resources.icons8_reception_16___Copy;
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["ActivityTypeValue"].Value.ToString().Contains("Client"))
                    e.Value = Properties.Resources.icons8_customer_16;
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["ActivityTypeValue"].Value.ToString().Contains("User"))
                    e.Value = Properties.Resources.icons8_select_users_16;
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["ActivityTypeValue"].Value.ToString().Contains("System"))
                    e.Value = Properties.Resources.icons8_administrative_tools_16;
            }
           
            if (dtGridAuditTrail.Columns[e.ColumnIndex].Name == "StatusImg")
            {
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["EntryType"].Value.ToString() == "Success")
                    e.Value = Properties.Resources.icons8_ok_16;
                if (dtGridAuditTrail.Rows[e.RowIndex].Cells["EntryType"].Value.ToString() == "Fail")
                    e.Value = Properties.Resources.icons8_cancel_16;
            }
            if (dtGridAuditTrail.Columns[e.ColumnIndex].Name == "ActivityTypeValue")
            {
                string myStringWithoutSpaces = e.Value.ToString();
                e.Value = Regex.Replace(myStringWithoutSpaces, "([A-Z])([a-z]*)", " $1$2");
            }
        }
    }
}
