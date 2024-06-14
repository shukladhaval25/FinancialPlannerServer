using DevExpress.XtraEditors;
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
    public partial class ProcessInformation : DevExpress.XtraEditors.XtraForm
    {
        PrimaryStep primaryStep;
        DataTable dtLinkSubStep;
        DataTable dtPoints = new DataTable();
        IList<LinkSubStep> linkSubSteps;
        IList<DesignationHierarchy> designationHierarchies;
        DataTable dtProcessMultiplePoints;
        public ProcessInformation(PrimaryStep primaryStep)
        {
            InitializeComponent();
            this.primaryStep = primaryStep;
        }

        private void ProcessInformation_Load(object sender, EventArgs e)
        {
            dtPoints.Columns.Add("Point");
            gridPoints.DataSource = dtPoints;
            loadDesingationHierarchy();
            loadPrimayStepData();
            loadProcessMultiplePoints();
            
        }

        private void loadProcessMultiplePoints()
        {
            dtProcessMultiplePoints = new DataTable();
            dtProcessMultiplePoints.Columns.Add("Description");
            gridPoints.DataSource = dtProcessMultiplePoints;
           
        }

        private void loadDesingationHierarchy()
        {
            designationHierarchies = new DesignationHierarchyInfo().GetAll();
            cmbPrimaryStepResponsibility.Properties.Items.Clear();
            cmbPrimaryStepOwner.Properties.Items.Clear();
            cmbPrimaryStepChecker.Properties.Items.Clear();

            cmbLinkSubStepResponsibility.Properties.Items.Clear();
            cmbLinkSubStepOwner.Properties.Items.Clear();
            cmbLinkSubStepChecker.Properties.Items.Clear();

            foreach (DesignationHierarchy designationHierarchy in designationHierarchies)
            {
                string value = designationHierarchy.Designation.Trim();
                cmbPrimaryStepResponsibility.Properties.Items.Add(value);
                cmbPrimaryStepOwner.Properties.Items.Add(value);
                cmbPrimaryStepChecker.Properties.Items.Add(value);

                cmbLinkSubStepResponsibility.Properties.Items.Add(value);
                cmbLinkSubStepOwner.Properties.Items.Add(value);
                cmbLinkSubStepChecker.Properties.Items.Add(value);
            }
        }

        private void loadPrimayStepData()
        {
            txtPrimaryStepId.Text = this.primaryStep.Id.ToString();
            txtPrimaryStepNo.Text = this.primaryStep.StepNo.ToString();
            txtPrimaryStepTitle.Text = this.primaryStep.Title;
            txtPrimaryStepDescription.Text = this.primaryStep.Description;
            txtPrimaryStepRemarks.Text = this.primaryStep.Remarks;
            txtPrimaryStepDuration.Text = this.primaryStep.DurationInMinutes.ToString();
            txtPrimaryStepTimeline.Text = this.primaryStep.TimelineInDays.ToString();

            if (this.primaryStep.PrimaryResponsibility != null)
            {
                //Primary Resposibility
                DesignationHierarchy designationHierarchy = designationHierarchies.First(i => i.Id == this.primaryStep.PrimaryResponsibility);
                if (designationHierarchy != null)
                {
                    cmbPrimaryStepResponsibility.Text = designationHierarchy.Designation;
                    //Owneer
                    designationHierarchy = designationHierarchies.First(i => i.Id == this.primaryStep.Owner);
                    cmbPrimaryStepOwner.Text = designationHierarchy.Designation;
                    //Checker
                    designationHierarchy = designationHierarchies.First(i => i.Id == this.primaryStep.Checker);
                    cmbPrimaryStepChecker.Text = designationHierarchy.Designation;
                }
            }
        }

        private void txtPrimaryStepId_EditValueChanged(object sender, EventArgs e)
        {
            grpLinkSubStep.Enabled = !txtPrimaryStepId.Text.Equals("0");
            if (grpLinkSubStep.Enabled)
            {
                ProcessesInfo processesInfo = new ProcessesInfo();
                linkSubSteps = processesInfo.GetLinkSubSteps(this.primaryStep.Id);
                dtLinkSubStep = ListtoDataTable.ToDataTable(linkSubSteps.ToList());
                
                grdLinkSubProcessStep.DataSource = dtLinkSubStep;
            }
        }
      
        private void btnSavePrimaryStep_Click(object sender, EventArgs e)
        {
            try
            {
                this.primaryStep.StepNo = int.Parse(txtPrimaryStepNo.Text);
                this.primaryStep.Title = txtPrimaryStepTitle.Text;
                this.primaryStep.Description = txtPrimaryStepDescription.Text;
                this.primaryStep.Remarks = txtPrimaryStepRemarks.Text;
                this.primaryStep.DurationInMinutes = (string.IsNullOrEmpty( txtPrimaryStepDuration.Text))? 0 : int.Parse(txtPrimaryStepDuration.Text);
                this.primaryStep.TimelineInDays = (string.IsNullOrEmpty(txtPrimaryStepTimeline.Text) ? 0 : int.Parse(txtPrimaryStepTimeline.Text));
                this.primaryStep.PrimaryResponsibility = getDesignationId(cmbPrimaryStepResponsibility.Text);
                this.primaryStep.Owner = getDesignationId(cmbPrimaryStepOwner.Text);
                this.primaryStep.Checker = getDesignationId(cmbPrimaryStepChecker.Text);
                
                bool isSaved = new ProcessesInfo().UpdatePrimaryStep(ref this.primaryStep);
                if (isSaved)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Record saved sucessfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPrimayStepData();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error :" + ex.ToString(),
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void layoutView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (layoutView1.SelectedRowsCount > 0)
            {
                int id = int.Parse(layoutView1.GetRowCellValue(e.FocusedRowHandle, "Id").ToString());
                loadLinkSubStepProcessData(id);
            }
        }

        private void loadLinkSubStepProcessData(int id)
        {
            LinkSubStep linkSubStep = linkSubSteps.First(i => i.Id == id);
            txtLinkSubStepId.Text = linkSubStep.Id.ToString();
            txtLinkSubStepNo.Text = linkSubStep.StepNo.ToString();
            txtLinkSubStepTitle.Text = linkSubStep.Title;
            txtLinkSubStepDescription.Text = linkSubStep.Description;
            txtLinkSubStepRemarks.Text = linkSubStep.Remarks;
            txtLinkSubStepDuration.Text = linkSubStep.DurationInMinutes.ToString();
            txtLinkSubStepTimeLine.Text = linkSubStep.TimelineInDays.ToString();

            //Primary Resposibility
            DesignationHierarchy designationHierarchy = designationHierarchies.First(i => i.Id == linkSubStep.PrimaryResponsibility);
            cmbLinkSubStepResponsibility.Text = designationHierarchy.Designation;
            //Owneer
            designationHierarchy = designationHierarchies.First(i => i.Id == linkSubStep.Owner);
            cmbLinkSubStepOwner.Text = designationHierarchy.Designation;
            //Checker
            designationHierarchy = designationHierarchies.First(i => i.Id == linkSubStep.Checker);
            cmbLinkSubStepChecker.Text = designationHierarchy.Designation;

            chkAllowByPassProcess.Checked = linkSubStep.AllowByPassProcess;
            //DataTable dtPoints = new DataTable();
            dtPoints.Rows.Clear();
            if (linkSubStep.Points.Count > 0)
            {
                foreach(string point in linkSubStep.Points)
                {
                    DataRow dataRow = dtPoints.NewRow();
                    dataRow["Point"] = point;
                    dtPoints.Rows.Add(dataRow);
                }
            }
            gridPoints.DataSource = dtPoints;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearLinkSubStepsObjects();
        }

        private void clearLinkSubStepsObjects()
        {
            txtLinkSubStepId.Text = "0";
            txtLinkSubStepNo.Text = "";
            txtLinkSubStepTitle.Text = "";
            txtLinkSubStepDescription.Text = "";
            txtLinkSubStepRemarks.Text = "";
            txtLinkSubStepDuration.Text = "";
            txtLinkSubStepTimeLine.Text = "";
            cmbLinkSubStepResponsibility.Text = "";
            cmbLinkSubStepOwner.Text = "";
            cmbLinkSubStepChecker.Text = "";
        }

        private void btnSaveLinkSubSteps_Click(object sender, EventArgs e)
        {
            try
            {
                LinkSubStep linkSubStep = new LinkSubStep();
                linkSubStep = convertToLinkSubStep();
                bool isSave = new ProcessesInfo().UpdateLinkSubStep(ref linkSubStep);
                if (isSave)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Record saved sucessfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrimaryStepId_EditValueChanged(sender, e);
                    loadLinkSubStepProcessData(linkSubStep);                    
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error :" + ex.ToString(),
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadLinkSubStepProcessData(LinkSubStep linkSubStep)
        {
            txtLinkSubStepId.Text = linkSubStep.Id.ToString();
            txtLinkSubStepNo.Text = linkSubStep.StepNo.ToString();
            txtLinkSubStepTitle.Text = linkSubStep.Title;
            txtLinkSubStepDescription.Text = linkSubStep.Description;
            txtLinkSubStepRemarks.Text = linkSubStep.Remarks;
            txtLinkSubStepDuration.Text = linkSubStep.DurationInMinutes.ToString();
            txtLinkSubStepTimeLine.Text = linkSubStep.TimelineInDays.ToString();
        }

        private LinkSubStep convertToLinkSubStep()
        {
            LinkSubStep linkSubStep = new LinkSubStep();
            linkSubStep.Id = (string.IsNullOrEmpty(txtLinkSubStepId.Text)?0 : int.Parse(txtLinkSubStepId.Text));
            linkSubStep.PrimaryStepId = this.primaryStep.Id;
            linkSubStep.StepNo = int.Parse(txtLinkSubStepNo.Text);
            linkSubStep.Title = txtLinkSubStepTitle.Text;
            linkSubStep.Description = txtLinkSubStepDescription.Text;
            linkSubStep.Remarks = txtLinkSubStepRemarks.Text;
            linkSubStep.DurationInMinutes = string.IsNullOrEmpty(txtLinkSubStepDuration.Text) ? 0 : int.Parse(txtLinkSubStepDuration.Text);
            linkSubStep.TimelineInDays = string.IsNullOrEmpty(txtLinkSubStepTimeLine.Text) ? 0 : int.Parse(txtLinkSubStepTimeLine.Text);

            linkSubStep.PrimaryResponsibility = getDesignationId(cmbLinkSubStepResponsibility.Text);
            linkSubStep.Owner = getDesignationId(cmbLinkSubStepOwner.Text);
            linkSubStep.Checker = getDesignationId(cmbLinkSubStepChecker.Text);
            linkSubStep.AllowByPassProcess = chkAllowByPassProcess.Checked;
            linkSubStep.Points = getPoints();
            return linkSubStep;
        }

        private List<string> getPoints()
        {
            List<string> points = new List<string>();
            if (gridViewPoints.RowCount > 0)
            {
                for (int rowcount = 0; rowcount < gridViewPoints.RowCount; rowcount++)
                {
                    points.Add(gridViewPoints.GetRowCellValue(rowcount, "Point").ToString());
                }
            }
            return points;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (layoutView1.SelectedRowsCount > 0)
            {
                if ((DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record?",
                 "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    int id = int.Parse(layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Id").ToString());
                    bool isDeleted = new ProcessesInfo().DeleteLinkSubStep(id);
                    if (isDeleted)
                    {
                        txtPrimaryStepId_EditValueChanged(sender, e);
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Unable to delete this record.",
                          "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPrimaryStepResponsibility_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((ComboBoxEdit)sender).Tag = getDesignationId(((ComboBoxEdit)sender).Text);
        }

        private int? getDesignationId(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;

            DesignationHierarchy designationHierarchy = designationHierarchies.First(i => i.Designation.Trim() == text.Trim());
            return designationHierarchy.Id;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridViewPoints.AddNewRow();
        }

        private void btnDeletePoint_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewPoints.DeleteRow(gridViewPoints.FocusedRowHandle);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}