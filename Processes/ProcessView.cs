using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Planning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.Processes
{
    public partial class ProcessView : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtProcess = new DataTable();
        IList<PrimaryStep> primarySteps;
        public ProcessView()
        {
            InitializeComponent();
        }

        private void ProcessView_Load(object sender, EventArgs e)
        {
            loadPrimaryStepData();
        }

        private void loadPrimaryStepData()
        {
            ProcessesInfo processesInfo = new ProcessesInfo();
            primarySteps = processesInfo.GetPrimarySteps();
            dtProcess = ListtoDataTable.ToDataTable(primarySteps.ToList());
            grdProcessStep.DataSource = dtProcess;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProcessInformation processInformation = new ProcessInformation(new PrimaryStep());
            processInformation.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tileViewProcesStep.GetSelectedRows().Count() > 0)
            {
                int Id;
                int.TryParse(tileViewProcesStep.GetFocusedRowCellValue("Id").ToString(), out Id);
                PrimaryStep primaryStep = primarySteps.First(i => i.Id == Id);

                ProcessInformation processInformation = new ProcessInformation(primaryStep);
                processInformation.ShowDialog();
            }
        }

        private void tileViewProcesStep_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tileViewProcesStep.GetSelectedRows().Count() > 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("All associated link sub steps data get deleted. Make sure you want to delete this primary step.",
                "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if ((DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record?",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    int id = int.Parse(tileViewProcesStep.GetRowCellValue(tileViewProcesStep.FocusedRowHandle, "Id").ToString());
                    bool isDeleted = new ProcessesInfo().DeletePrimaryStep(id);
                    if (isDeleted)
                    {
                        loadPrimaryStepData();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unable to delete this record.",
                          "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
