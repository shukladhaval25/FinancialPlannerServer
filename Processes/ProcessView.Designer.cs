namespace FinancialPlannerServer.Processes
{
    partial class ProcessView
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
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.tileViewColumnStepNo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnTitle = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnDuration = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnTimeline = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.grdProcessStep = new DevExpress.XtraGrid.GridControl();
            this.tileViewProcesStep = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumnDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnRemarks = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnPrimaryResponsibility = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnOwner = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumnChecker = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.grpProcesses = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcessStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewProcesStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpProcesses)).BeginInit();
            this.grpProcesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileViewColumnStepNo
            // 
            this.tileViewColumnStepNo.Caption = "StepNo";
            this.tileViewColumnStepNo.FieldName = "StepNo";
            this.tileViewColumnStepNo.Name = "tileViewColumnStepNo";
            this.tileViewColumnStepNo.Visible = true;
            this.tileViewColumnStepNo.VisibleIndex = 0;
            // 
            // tileViewColumnTitle
            // 
            this.tileViewColumnTitle.Caption = "Title";
            this.tileViewColumnTitle.FieldName = "Title";
            this.tileViewColumnTitle.Name = "tileViewColumnTitle";
            this.tileViewColumnTitle.Visible = true;
            this.tileViewColumnTitle.VisibleIndex = 1;
            // 
            // tileViewColumnId
            // 
            this.tileViewColumnId.Caption = "Id";
            this.tileViewColumnId.FieldName = "Id";
            this.tileViewColumnId.Name = "tileViewColumnId";
            // 
            // tileViewColumnDuration
            // 
            this.tileViewColumnDuration.Caption = "Duration In Minutes";
            this.tileViewColumnDuration.FieldName = "DurationInMinutes";
            this.tileViewColumnDuration.Name = "tileViewColumnDuration";
            this.tileViewColumnDuration.Visible = true;
            this.tileViewColumnDuration.VisibleIndex = 4;
            // 
            // tileViewColumnTimeline
            // 
            this.tileViewColumnTimeline.Caption = "Timeline In Days";
            this.tileViewColumnTimeline.FieldName = "TimelineInDays";
            this.tileViewColumnTimeline.Name = "tileViewColumnTimeline";
            this.tileViewColumnTimeline.Visible = true;
            this.tileViewColumnTimeline.VisibleIndex = 5;
            // 
            // grdProcessStep
            // 
            this.grdProcessStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProcessStep.Location = new System.Drawing.Point(5, 23);
            this.grdProcessStep.MainView = this.tileViewProcesStep;
            this.grdProcessStep.Name = "grdProcessStep";
            this.grdProcessStep.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grdProcessStep.Size = new System.Drawing.Size(826, 388);
            this.grdProcessStep.TabIndex = 4;
            this.grdProcessStep.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewProcesStep,
            this.cardView1});
            // 
            // tileViewProcesStep
            // 
            this.tileViewProcesStep.Appearance.ItemHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileViewProcesStep.Appearance.ItemHovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileViewProcesStep.Appearance.ItemHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tileViewProcesStep.Appearance.ItemHovered.Options.UseBorderColor = true;
            this.tileViewProcesStep.Appearance.ItemHovered.Options.UseFont = true;
            this.tileViewProcesStep.Appearance.ItemHovered.Options.UseForeColor = true;
            this.tileViewProcesStep.Appearance.ItemSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileViewProcesStep.Appearance.ItemSelected.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileViewProcesStep.Appearance.ItemSelected.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.tileViewProcesStep.Appearance.ItemSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tileViewProcesStep.Appearance.ItemSelected.Options.UseBorderColor = true;
            this.tileViewProcesStep.Appearance.ItemSelected.Options.UseFont = true;
            this.tileViewProcesStep.Appearance.ItemSelected.Options.UseForeColor = true;
            this.tileViewProcesStep.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumnId,
            this.tileViewColumnStepNo,
            this.tileViewColumnTitle,
            this.tileViewColumnDescription,
            this.tileViewColumnRemarks,
            this.tileViewColumnDuration,
            this.tileViewColumnTimeline,
            this.tileViewColumnPrimaryResponsibility,
            this.tileViewColumnOwner,
            this.tileViewColumnChecker});
            this.tileViewProcesStep.GridControl = this.grdProcessStep;
            this.tileViewProcesStep.Name = "tileViewProcesStep";
            tileViewItemElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            tileViewItemElement1.Appearance.Hovered.Options.UseFont = true;
            tileViewItemElement1.Appearance.Hovered.Options.UseForeColor = true;
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.tileViewColumnStepNo;
            tileViewItemElement1.Text = "tileViewColumnStepNo";
            tileViewItemElement1.TextLocation = new System.Drawing.Point(100, 20);
            tileViewItemElement2.AnimateTransition = DevExpress.Utils.DefaultBoolean.True;
            tileViewItemElement2.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement2.Appearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            tileViewItemElement2.Appearance.Hovered.Options.UseFont = true;
            tileViewItemElement2.Appearance.Hovered.Options.UseForeColor = true;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.tileViewColumnTitle;
            tileViewItemElement2.StretchHorizontal = true;
            tileViewItemElement2.Text = "tileViewColumnTitle";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileViewItemElement2.TextLocation = new System.Drawing.Point(0, 45);
            tileViewItemElement3.Column = this.tileViewColumnId;
            tileViewItemElement3.Text = "tileViewColumnId";
            this.tileViewProcesStep.TileTemplate.Add(tileViewItemElement1);
            this.tileViewProcesStep.TileTemplate.Add(tileViewItemElement2);
            this.tileViewProcesStep.TileTemplate.Add(tileViewItemElement3);
            this.tileViewProcesStep.ItemDoubleClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tileViewProcesStep_ItemDoubleClick);
            // 
            // tileViewColumnDescription
            // 
            this.tileViewColumnDescription.Caption = "Description";
            this.tileViewColumnDescription.FieldName = "Description";
            this.tileViewColumnDescription.Name = "tileViewColumnDescription";
            this.tileViewColumnDescription.Visible = true;
            this.tileViewColumnDescription.VisibleIndex = 2;
            // 
            // tileViewColumnRemarks
            // 
            this.tileViewColumnRemarks.Caption = "Remarks";
            this.tileViewColumnRemarks.FieldName = "Remarks";
            this.tileViewColumnRemarks.Name = "tileViewColumnRemarks";
            this.tileViewColumnRemarks.Visible = true;
            this.tileViewColumnRemarks.VisibleIndex = 3;
            // 
            // tileViewColumnPrimaryResponsibility
            // 
            this.tileViewColumnPrimaryResponsibility.Caption = "Primary Responsibility";
            this.tileViewColumnPrimaryResponsibility.FieldName = "PrimaryResponsibility";
            this.tileViewColumnPrimaryResponsibility.Name = "tileViewColumnPrimaryResponsibility";
            this.tileViewColumnPrimaryResponsibility.Visible = true;
            this.tileViewColumnPrimaryResponsibility.VisibleIndex = 6;
            // 
            // tileViewColumnOwner
            // 
            this.tileViewColumnOwner.Caption = "Owner";
            this.tileViewColumnOwner.FieldName = "Owner";
            this.tileViewColumnOwner.Name = "tileViewColumnOwner";
            this.tileViewColumnOwner.Visible = true;
            this.tileViewColumnOwner.VisibleIndex = 7;
            // 
            // tileViewColumnChecker
            // 
            this.tileViewColumnChecker.Caption = "Checker";
            this.tileViewColumnChecker.FieldName = "Checker";
            this.tileViewColumnChecker.Name = "tileViewColumnChecker";
            this.tileViewColumnChecker.Visible = true;
            this.tileViewColumnChecker.VisibleIndex = 8;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.grdProcessStep;
            this.cardView1.Name = "cardView1";
            // 
            // grpProcesses
            // 
            this.grpProcesses.Controls.Add(this.btnDelete);
            this.grpProcesses.Controls.Add(this.grdProcessStep);
            this.grpProcesses.Controls.Add(this.btnEdit);
            this.grpProcesses.Controls.Add(this.btnAdd);
            this.grpProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProcesses.Location = new System.Drawing.Point(0, 0);
            this.grpProcesses.Name = "grpProcesses";
            this.grpProcesses.Size = new System.Drawing.Size(837, 450);
            this.grpProcesses.TabIndex = 5;
            this.grpProcesses.Text = "Process for Financial Planning";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(69, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem1.Text = "Delete Process";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "To delete selected process record click here.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnDelete.SuperTip = superToolTip1;
            this.btnDelete.TabIndex = 9;
            this.btnDelete.ToolTip = "Delete Client";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(38, 422);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem2.Text = "Edit Process\r\n";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "To modify selected process information click here.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnEdit.SuperTip = superToolTip2;
            this.btnEdit.TabIndex = 8;
            this.btnEdit.ToolTip = "Edit Client";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(7, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem3.Text = "New Process";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "To add new process inforamtion click here.";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnAdd.SuperTip = superToolTip3;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.ToolTip = "Add New Process";
            this.btnAdd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.btnAdd.ToolTipTitle = "New Client";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ProcessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.grpProcesses);
            this.Name = "ProcessView";
            this.Text = "Process";
            this.Load += new System.EventHandler(this.ProcessView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProcessStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewProcesStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpProcesses)).EndInit();
            this.grpProcesses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProcessStep;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewProcesStep;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnId;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnStepNo;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnTitle;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnRemarks;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnDuration;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnTimeline;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnPrimaryResponsibility;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnOwner;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumnChecker;
        private DevExpress.XtraEditors.GroupControl grpProcesses;
        public DevExpress.XtraEditors.SimpleButton btnDelete;
        public DevExpress.XtraEditors.SimpleButton btnEdit;
        public DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}