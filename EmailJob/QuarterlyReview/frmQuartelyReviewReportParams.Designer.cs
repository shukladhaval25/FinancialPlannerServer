namespace FinancialPlannerServer.QuarterlyReview
{
    partial class frmQuartelyReviewReportParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuartelyReviewReportParams));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlClients = new DevExpress.XtraGrid.GridControl();
            this.gridViewClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnSendQuarterlyReview = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.dtQuaterlyReview = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuaterlyReview.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuaterlyReview.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select clients which you want to send quartely review sheet.";
            // 
            // gridControlClients
            // 
            this.gridControlClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlClients.Location = new System.Drawing.Point(12, 42);
            this.gridControlClients.MainView = this.gridViewClient;
            this.gridControlClients.Name = "gridControlClients";
            this.gridControlClients.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlClients.Size = new System.Drawing.Size(1145, 363);
            this.gridControlClients.TabIndex = 3;
            this.gridControlClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClient});
            // 
            // gridViewClient
            // 
            this.gridViewClient.GridControl = this.gridControlClients;
            this.gridViewClient.Name = "gridViewClient";
            this.gridViewClient.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewClient_CellValueChanged);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnSendQuarterlyReview
            // 
            this.btnSendQuarterlyReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendQuarterlyReview.Image = ((System.Drawing.Image)(resources.GetObject("btnSendQuarterlyReview.Image")));
            this.btnSendQuarterlyReview.Location = new System.Drawing.Point(12, 415);
            this.btnSendQuarterlyReview.Name = "btnSendQuarterlyReview";
            this.btnSendQuarterlyReview.Size = new System.Drawing.Size(146, 23);
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "Quarterly Reivew";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Send quarterly review sheet.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnSendQuarterlyReview.SuperTip = superToolTip1;
            this.btnSendQuarterlyReview.TabIndex = 4;
            this.btnSendQuarterlyReview.Text = "Send Review Sheet";
            this.btnSendQuarterlyReview.ToolTip = "Send Quarterly Review Sheet";
            this.btnSendQuarterlyReview.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.btnSendQuarterlyReview.ToolTipTitle = "Send Quarterly Review Sheet";
            this.btnSendQuarterlyReview.Click += new System.EventHandler(this.btnSendQuarterlyReview_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.Image")));
            this.btnSelectAll.Location = new System.Drawing.Point(985, 415);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(83, 23);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDeSelectAll
            // 
            this.btnDeSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeSelectAll.Location = new System.Drawing.Point(1074, 415);
            this.btnDeSelectAll.Name = "btnDeSelectAll";
            this.btnDeSelectAll.Size = new System.Drawing.Size(83, 23);
            this.btnDeSelectAll.TabIndex = 6;
            this.btnDeSelectAll.Text = "Deselect All";
            this.btnDeSelectAll.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.btnDeSelectAll.Click += new System.EventHandler(this.btnDeSelectAll_Click);
            // 
            // dtQuaterlyReview
            // 
            this.dtQuaterlyReview.EditValue = null;
            this.dtQuaterlyReview.Location = new System.Drawing.Point(107, 12);
            this.dtQuaterlyReview.Name = "dtQuaterlyReview";
            this.dtQuaterlyReview.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtQuaterlyReview.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtQuaterlyReview.Size = new System.Drawing.Size(178, 20);
            this.dtQuaterlyReview.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtQuaterlyReview);
            this.groupBox1.Location = new System.Drawing.Point(321, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 36);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(291, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quarterly Review :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(713, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 36);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(37, 11);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(401, 20);
            this.txtCC.TabIndex = 1;
            this.txtCC.Text = "financialsolutionsascent@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CC:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(1128, 47);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 23);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.ToolTip = "Export to excel";
            this.btnExport.ToolTipTitle = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmQuartelyReviewReportParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeSelectAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnSendQuarterlyReview);
            this.Controls.Add(this.gridControlClients);
            this.Controls.Add(this.label1);
            this.Name = "frmQuartelyReviewReportParams";
            this.Text = "Quartely Review";
            this.Load += new System.EventHandler(this.frmQuartelyReviewReportParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuaterlyReview.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtQuaterlyReview.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClient;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        public DevExpress.XtraEditors.SimpleButton btnSendQuarterlyReview;
        public DevExpress.XtraEditors.SimpleButton btnSelectAll;
        public DevExpress.XtraEditors.SimpleButton btnDeSelectAll;
        private DevExpress.XtraEditors.DateEdit dtQuaterlyReview;
        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}