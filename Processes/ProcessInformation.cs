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
        IList<LinkSubStep> linkSubSteps;
        public ProcessInformation(PrimaryStep primaryStep)
        {
            InitializeComponent();
            this.primaryStep = primaryStep;
        }

        private void ProcessInformation_Load(object sender, EventArgs e)
        {
            loadPrimayStepData();
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
            linkSubStep.Id = int.Parse(txtLinkSubStepId.Text);
            linkSubStep.PrimaryStepId = this.primaryStep.Id;
            linkSubStep.StepNo = int.Parse(txtLinkSubStepNo.Text);
            linkSubStep.Title = txtLinkSubStepTitle.Text;
            linkSubStep.Description = txtLinkSubStepDescription.Text;
            linkSubStep.Remarks = txtLinkSubStepRemarks.Text;
            linkSubStep.DurationInMinutes = string.IsNullOrEmpty(txtLinkSubStepDuration.Text) ? 0 : int.Parse(txtLinkSubStepDuration.Text);
            linkSubStep.TimelineInDays = string.IsNullOrEmpty(txtLinkSubStepTimeLine.Text) ? 0 : int.Parse(txtLinkSubStepTimeLine.Text);

            return linkSubStep;
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
    }
}