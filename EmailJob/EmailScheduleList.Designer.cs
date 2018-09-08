namespace FinancialPlannerServer.EmailJob
{
    partial class EmailScheduleList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailScheduleList));
            this.grpEmailScheduleSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imgCollection16x16 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEmailScheduler = new System.Windows.Forms.DataGridView();
            this.TypeImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpActionControls = new System.Windows.Forms.GroupBox();
            this.btnDeleteArticleInfo = new System.Windows.Forms.Button();
            this.btnAddArticleInfo = new System.Windows.Forms.Button();
            this.btnEditArticleInfo = new System.Windows.Forms.Button();
            this.grpEmailScheduleSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmailScheduler)).BeginInit();
            this.grpActionControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmailScheduleSearch
            // 
            this.grpEmailScheduleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEmailScheduleSearch.Controls.Add(this.btnSearch);
            this.grpEmailScheduleSearch.Controls.Add(this.textBox1);
            this.grpEmailScheduleSearch.Controls.Add(this.cmbSearchBy);
            this.grpEmailScheduleSearch.Controls.Add(this.label1);
            this.grpEmailScheduleSearch.Location = new System.Drawing.Point(12, 12);
            this.grpEmailScheduleSearch.Name = "grpEmailScheduleSearch";
            this.grpEmailScheduleSearch.Size = new System.Drawing.Size(1062, 58);
            this.grpEmailScheduleSearch.TabIndex = 0;
            this.grpEmailScheduleSearch.TabStop = false;
            this.grpEmailScheduleSearch.Text = "Email Schedule Search";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageKey = "icons8-search-16.png";
            this.btnSearch.ImageList = this.imgCollection16x16;
            this.btnSearch.Location = new System.Drawing.Point(593, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // imgCollection16x16
            // 
            this.imgCollection16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCollection16x16.ImageStream")));
            this.imgCollection16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCollection16x16.Images.SetKeyName(0, "Add-Action.png");
            this.imgCollection16x16.Images.SetKeyName(1, "delete.png");
            this.imgCollection16x16.Images.SetKeyName(2, "deleteline.png");
            this.imgCollection16x16.Images.SetKeyName(3, "drop-add.gif");
            this.imgCollection16x16.Images.SetKeyName(4, "Edit.png");
            this.imgCollection16x16.Images.SetKeyName(5, "icons8-search-16.png");
            this.imgCollection16x16.Images.SetKeyName(6, "icons8-cancel-16.png");
            this.imgCollection16x16.Images.SetKeyName(7, "icons8-save-close-16.png");
            this.imgCollection16x16.Images.SetKeyName(8, "icons8-magazine-30.png");
            this.imgCollection16x16.Images.SetKeyName(9, "icons8-automation-30.png");
            this.imgCollection16x16.Images.SetKeyName(10, "Run-1.png");
            this.imgCollection16x16.Images.SetKeyName(11, "icons8-calendar-plus-16.png");
            this.imgCollection16x16.Images.SetKeyName(12, "icons8-week-view-16.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Title",
            "Schedule Type",
            "Article Group"});
            this.cmbSearchBy.Location = new System.Drawing.Point(81, 27);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(187, 21);
            this.cmbSearchBy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By:";
            // 
            // dataGridEmailScheduler
            // 
            this.dataGridEmailScheduler.AllowUserToAddRows = false;
            this.dataGridEmailScheduler.AllowUserToDeleteRows = false;
            this.dataGridEmailScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmailScheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmailScheduler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeImg});
            this.dataGridEmailScheduler.Location = new System.Drawing.Point(12, 86);
            this.dataGridEmailScheduler.Name = "dataGridEmailScheduler";
            this.dataGridEmailScheduler.ReadOnly = true;
            this.dataGridEmailScheduler.Size = new System.Drawing.Size(1062, 280);
            this.dataGridEmailScheduler.TabIndex = 1;
            this.dataGridEmailScheduler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridEmailScheduler_CellFormatting);
            // 
            // TypeImg
            // 
            this.TypeImg.Frozen = true;
            this.TypeImg.HeaderText = "";
            this.TypeImg.Name = "TypeImg";
            this.TypeImg.ReadOnly = true;
            // 
            // grpActionControls
            // 
            this.grpActionControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActionControls.Controls.Add(this.btnDeleteArticleInfo);
            this.grpActionControls.Controls.Add(this.btnAddArticleInfo);
            this.grpActionControls.Controls.Add(this.btnEditArticleInfo);
            this.grpActionControls.Location = new System.Drawing.Point(963, 372);
            this.grpActionControls.Name = "grpActionControls";
            this.grpActionControls.Size = new System.Drawing.Size(111, 38);
            this.grpActionControls.TabIndex = 8;
            this.grpActionControls.TabStop = false;
            // 
            // btnDeleteArticleInfo
            // 
            this.btnDeleteArticleInfo.ImageIndex = 1;
            this.btnDeleteArticleInfo.ImageList = this.imgCollection16x16;
            this.btnDeleteArticleInfo.Location = new System.Drawing.Point(76, 10);
            this.btnDeleteArticleInfo.Name = "btnDeleteArticleInfo";
            this.btnDeleteArticleInfo.Size = new System.Drawing.Size(29, 24);
            this.btnDeleteArticleInfo.TabIndex = 4;
            this.btnDeleteArticleInfo.UseVisualStyleBackColor = true;
            this.btnDeleteArticleInfo.Click += new System.EventHandler(this.btnDeleteArticleInfo_Click);
            // 
            // btnAddArticleInfo
            // 
            this.btnAddArticleInfo.ImageIndex = 3;
            this.btnAddArticleInfo.ImageList = this.imgCollection16x16;
            this.btnAddArticleInfo.Location = new System.Drawing.Point(6, 10);
            this.btnAddArticleInfo.Name = "btnAddArticleInfo";
            this.btnAddArticleInfo.Size = new System.Drawing.Size(29, 24);
            this.btnAddArticleInfo.TabIndex = 2;
            this.btnAddArticleInfo.UseVisualStyleBackColor = true;
            this.btnAddArticleInfo.Click += new System.EventHandler(this.btnAddArticleInfo_Click);
            // 
            // btnEditArticleInfo
            // 
            this.btnEditArticleInfo.ImageIndex = 4;
            this.btnEditArticleInfo.ImageList = this.imgCollection16x16;
            this.btnEditArticleInfo.Location = new System.Drawing.Point(41, 10);
            this.btnEditArticleInfo.Name = "btnEditArticleInfo";
            this.btnEditArticleInfo.Size = new System.Drawing.Size(29, 24);
            this.btnEditArticleInfo.TabIndex = 3;
            this.btnEditArticleInfo.UseVisualStyleBackColor = true;
            this.btnEditArticleInfo.Click += new System.EventHandler(this.btnEditArticleInfo_Click);
            // 
            // EmailScheduleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 416);
            this.Controls.Add(this.grpActionControls);
            this.Controls.Add(this.dataGridEmailScheduler);
            this.Controls.Add(this.grpEmailScheduleSearch);
            this.Name = "EmailScheduleList";
            this.Text = "Email Schedules";
            this.Load += new System.EventHandler(this.EmailScheduleList_Load);
            this.grpEmailScheduleSearch.ResumeLayout(false);
            this.grpEmailScheduleSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmailScheduler)).EndInit();
            this.grpActionControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmailScheduleSearch;
        private System.Windows.Forms.DataGridView dataGridEmailScheduler;
        private System.Windows.Forms.GroupBox grpActionControls;
        private System.Windows.Forms.Button btnDeleteArticleInfo;
        private System.Windows.Forms.Button btnAddArticleInfo;
        private System.Windows.Forms.Button btnEditArticleInfo;
        private System.Windows.Forms.ImageList imgCollection16x16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewImageColumn TypeImg;
    }
}