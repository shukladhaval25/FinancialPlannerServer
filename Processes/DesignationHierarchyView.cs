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
    public partial class DesignationHierarchyView : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtDesingation = new DataTable();
        IList<DesignationHierarchy> designationHeirarchies;
        public DesignationHierarchyView()
        {
            InitializeComponent();
        }

        private void DesignationHierarchy_Load(object sender, EventArgs e)
        {
            getDesignationHierarchyData();
        }

        private void filupReportingTo()
        {
            cmbReportingTo.Properties.Items.Clear();
            foreach (DataRow dr in dtDesingation.Rows)
            {
                cmbReportingTo.Properties.Items.Add(dr["Designation"].ToString());
            }
        }

        private void getDesignationHierarchyData()
        {
            DesignationHierarchyInfo designationHierarchyInfo = new DesignationHierarchyInfo();
            designationHeirarchies = designationHierarchyInfo.GetAll();
            dtDesingation = ListtoDataTable.ToDataTable(designationHeirarchies.ToList());
            gridDesingation.DataSource = dtDesingation;
            filupReportingTo();
        }

        private void gridViewDesignation_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridViewDesignation.SelectedRowsCount > 0 && e.FocusedRowHandle > 0 )
            {
                int id = int.Parse(gridViewDesignation.GetRowCellValue(e.FocusedRowHandle, "Id").ToString());
                txtDesignation.Tag = gridViewDesignation.GetRowCellValue(e.FocusedRowHandle, "Id").ToString();
                txtDesignation.Text = gridViewDesignation.GetRowCellValue(e.FocusedRowHandle, "Designation").ToString();
                txtDescription.Text = gridViewDesignation.GetRowCellValue(e.FocusedRowHandle, "Description").ToString();
                cmbReportingTo.Text = (gridViewDesignation.GetRowCellValue(e.FocusedRowHandle, "ReportTo") == null) ? "" : gridViewDesignation.GetRowCellValue(e.FocusedRowHandle, "ReportTo").ToString();
                cmbReportingTo.Tag = string.IsNullOrEmpty(cmbReportingTo.Text) ? "" : gridViewDesignation.GetRowCellValue(e.FocusedRowHandle, "ReportingToDesignationId").ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDesignation.Text = "";
            txtDesignation.Tag = "0";
            cmbReportingTo.Text = "";
            cmbReportingTo.Tag = null;
            txtDescription.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gridViewDesignation.SelectedRowsCount > 0)
            {
                if ((DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record?",
                 "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    DesignationHierarchyInfo designationHierarchyInfo = new DesignationHierarchyInfo();
                    int id = int.Parse(gridViewDesignation.GetRowCellValue(gridViewDesignation.FocusedRowHandle, "Id").ToString());
                    bool isDeleted = designationHierarchyInfo.Delete(id);
                    if (isDeleted)
                    {
                        getDesignationHierarchyData();
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unable to delete this record.",
                          "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DesignationHierarchy designationHierarchy = new DesignationHierarchy();
                designationHierarchy = convertToDesignationHierarchy();

                bool isSave = false;
                if (designationHierarchy.Id.Equals(0))
                {
                    isSave = new DesignationHierarchyInfo().Add(designationHierarchy);
                }
                else
                {
                    isSave = new DesignationHierarchyInfo().Update(designationHierarchy);
                }
                if (isSave)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Record saved sucessfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getDesignationHierarchyData();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error :" + ex.ToString(),
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DesignationHierarchy convertToDesignationHierarchy()
        {
            DesignationHierarchy designationHierarchy = new DesignationHierarchy();
            designationHierarchy.Id = int.Parse(txtDesignation.Tag.ToString());
            designationHierarchy.Designation = txtDesignation.Text;
            designationHierarchy.ReportingToDesignationId = string.IsNullOrEmpty(cmbReportingTo.Text) ? null : getReporingToId(cmbReportingTo.Text);
            designationHierarchy.Description = txtDescription.Text;

            return designationHierarchy;
        }

        private int? getReporingToId(string text)
        {
            if (string.IsNullOrEmpty(cmbReportingTo.Text))
                return null;
            DesignationHierarchy designationHierarchy = designationHeirarchies.First(i => i.Designation.Trim() == text.Trim());
            return designationHierarchy.Id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
