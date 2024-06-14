namespace FinancialPlannerServer.Processes
{
    partial class DesignationHierarchyView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignationHierarchyView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.gridDesingation = new DevExpress.XtraGrid.GridControl();
            this.gridViewDesignation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnReportToDesignationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnReportTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpDesignation = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblReligion = new DevExpress.XtraEditors.LabelControl();
            this.txtDesignation = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbReportingTo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridDesingation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDesignation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDesignation)).BeginInit();
            this.grpDesignation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReportingTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDesingation
            // 
            this.gridDesingation.Location = new System.Drawing.Point(12, 12);
            this.gridDesingation.MainView = this.gridViewDesignation;
            this.gridDesingation.Name = "gridDesingation";
            this.gridDesingation.Size = new System.Drawing.Size(352, 247);
            this.gridDesingation.TabIndex = 12;
            this.gridDesingation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDesignation});
            // 
            // gridViewDesignation
            // 
            this.gridViewDesignation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnDesignation,
            this.gridColumnReportToDesignationId,
            this.gridColumnReportTo});
            this.gridViewDesignation.GridControl = this.gridDesingation;
            this.gridViewDesignation.Name = "gridViewDesignation";
            this.gridViewDesignation.OptionsBehavior.Editable = false;
            this.gridViewDesignation.OptionsBehavior.ReadOnly = true;
            this.gridViewDesignation.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDesignation_FocusedRowChanged);
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            // 
            // gridColumnDesignation
            // 
            this.gridColumnDesignation.Caption = "Designation";
            this.gridColumnDesignation.FieldName = "Designation";
            this.gridColumnDesignation.Name = "gridColumnDesignation";
            this.gridColumnDesignation.Visible = true;
            this.gridColumnDesignation.VisibleIndex = 0;
            this.gridColumnDesignation.Width = 152;
            // 
            // gridColumnReportToDesignationId
            // 
            this.gridColumnReportToDesignationId.Caption = "Report To Id";
            this.gridColumnReportToDesignationId.FieldName = "ReportToDesignationId";
            this.gridColumnReportToDesignationId.Name = "gridColumnReportToDesignationId";
            // 
            // gridColumnReportTo
            // 
            this.gridColumnReportTo.Caption = "Report To";
            this.gridColumnReportTo.FieldName = "ReportTo";
            this.gridColumnReportTo.Name = "gridColumnReportTo";
            this.gridColumnReportTo.Visible = true;
            this.gridColumnReportTo.VisibleIndex = 1;
            this.gridColumnReportTo.Width = 182;
            // 
            // grpDesignation
            // 
            this.grpDesignation.Controls.Add(this.labelControl2);
            this.grpDesignation.Controls.Add(this.lblReligion);
            this.grpDesignation.Controls.Add(this.txtDesignation);
            this.grpDesignation.Controls.Add(this.labelControl1);
            this.grpDesignation.Controls.Add(this.btnClose);
            this.grpDesignation.Controls.Add(this.btnSave);
            this.grpDesignation.Controls.Add(this.cmbReportingTo);
            this.grpDesignation.Controls.Add(this.txtDescription);
            this.grpDesignation.Location = new System.Drawing.Point(370, 12);
            this.grpDesignation.Name = "grpDesignation";
            this.grpDesignation.Size = new System.Drawing.Size(370, 247);
            this.grpDesignation.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Description:";
            // 
            // lblReligion
            // 
            this.lblReligion.Location = new System.Drawing.Point(44, 73);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(66, 13);
            this.lblReligion.TabIndex = 27;
            this.lblReligion.Text = "Reporting To:";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(126, 44);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(214, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Desingation:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(278, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "Cancel";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "To close client rating without saving any information click here.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnClose.SuperTip = superToolTip1;
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(215, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 23);
            toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
            toolTipTitleItem2.Text = "Save";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "To save record click here.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnSave.SuperTip = superToolTip2;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbReportingTo
            // 
            this.cmbReportingTo.Location = new System.Drawing.Point(126, 70);
            this.cmbReportingTo.Name = "cmbReportingTo";
            this.cmbReportingTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbReportingTo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbReportingTo.Size = new System.Drawing.Size(214, 20);
            this.cmbReportingTo.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(44, 122);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(296, 67);
            this.txtDescription.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(41, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem3.Appearance.Options.UseImage = true;
            toolTipTitleItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem3.Image")));
            toolTipTitleItem3.Text = "Delete Client";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "To delete selected client rating record click here.";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnDelete.SuperTip = superToolTip3;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.ToolTip = "Delete Client";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(10, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem4.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            toolTipTitleItem4.Appearance.Options.UseImage = true;
            toolTipTitleItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem4.Image")));
            toolTipTitleItem4.Text = "New Client";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "To add new client rating click here.";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.btnAdd.SuperTip = superToolTip4;
            this.btnAdd.TabIndex = 9;
            this.btnAdd.ToolTip = "Add new client";
            this.btnAdd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.btnAdd.ToolTipTitle = "New Client";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DesignationHierarchyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 293);
            this.Controls.Add(this.gridDesingation);
            this.Controls.Add(this.grpDesignation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "DesignationHierarchyView";
            this.Text = "Designation Hierarchy";
            this.Load += new System.EventHandler(this.DesignationHierarchy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDesingation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDesignation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDesignation)).EndInit();
            this.grpDesignation.ResumeLayout(false);
            this.grpDesignation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesignation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbReportingTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDesingation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDesignation;
        private DevExpress.XtraEditors.GroupControl grpDesignation;
        private DevExpress.XtraEditors.LabelControl lblReligion;
        private DevExpress.XtraEditors.TextEdit txtDesignation;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbReportingTo;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnReportToDesignationId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnReportTo;
    }
}