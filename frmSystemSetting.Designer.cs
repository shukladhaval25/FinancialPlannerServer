namespace FinancialPlannerServer
{
    partial class frmSystemSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemSetting));
            this.grpEmailSetting = new System.Windows.Forms.GroupBox();
            this.tabEmailSetting = new System.Windows.Forms.TabControl();
            this.tabpageSMTPSetting = new System.Windows.Forms.TabPage();
            this.lblSMTPTitle = new System.Windows.Forms.Label();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.btnSaveSMTPSetting = new System.Windows.Forms.Button();
            this.imgCollection16x16 = new System.Windows.Forms.ImageList();
            this.chkIsSSL = new System.Windows.Forms.CheckBox();
            this.btnRestoreDefault = new System.Windows.Forms.Button();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblSMTPHost = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSMTPPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tbtnEmailArticles = new System.Windows.Forms.TabPage();
            this.trvArticle = new System.Windows.Forms.TreeView();
            this.grpArticleInfo = new System.Windows.Forms.GroupBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelArticleInfo = new System.Windows.Forms.Button();
            this.btnSaveArticleInfo = new System.Windows.Forms.Button();
            this.txtArticleDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnArticleContentFile = new System.Windows.Forms.Button();
            this.txtArticleContentPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArticleTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpActionControls = new System.Windows.Forms.GroupBox();
            this.btnDeleteArticleInfo = new System.Windows.Forms.Button();
            this.btnAddArticleInfo = new System.Windows.Forms.Button();
            this.btnEditArticleInfo = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchEmailArticle = new System.Windows.Forms.TextBox();
            this.lblArticleTitle = new System.Windows.Forms.Label();
            this.imglist30x30 = new System.Windows.Forms.ImageList();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindfolder = new System.Windows.Forms.Button();
            this.btnAppPathSave = new System.Windows.Forms.Button();
            this.txtAppPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDiallog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPOP3Host = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPOP3Port = new System.Windows.Forms.TextBox();
            this.grpEmailSetting.SuspendLayout();
            this.tabEmailSetting.SuspendLayout();
            this.tabpageSMTPSetting.SuspendLayout();
            this.tbtnEmailArticles.SuspendLayout();
            this.grpArticleInfo.SuspendLayout();
            this.grpActionControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmailSetting
            // 
            this.grpEmailSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEmailSetting.Controls.Add(this.tabEmailSetting);
            this.grpEmailSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmailSetting.Location = new System.Drawing.Point(8, 11);
            this.grpEmailSetting.Name = "grpEmailSetting";
            this.grpEmailSetting.Size = new System.Drawing.Size(868, 348);
            this.grpEmailSetting.TabIndex = 0;
            this.grpEmailSetting.TabStop = false;
            this.grpEmailSetting.Text = "Email Configuration";
            // 
            // tabEmailSetting
            // 
            this.tabEmailSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEmailSetting.Controls.Add(this.tabpageSMTPSetting);
            this.tabEmailSetting.Controls.Add(this.tbtnEmailArticles);
            this.tabEmailSetting.ImageList = this.imglist30x30;
            this.tabEmailSetting.Location = new System.Drawing.Point(6, 20);
            this.tabEmailSetting.Name = "tabEmailSetting";
            this.tabEmailSetting.SelectedIndex = 0;
            this.tabEmailSetting.Size = new System.Drawing.Size(856, 322);
            this.tabEmailSetting.TabIndex = 13;
            this.tabEmailSetting.SelectedIndexChanged += new System.EventHandler(this.tabEmailSetting_SelectedIndexChanged);
            // 
            // tabpageSMTPSetting
            // 
            this.tabpageSMTPSetting.Controls.Add(this.txtPOP3Host);
            this.tabpageSMTPSetting.Controls.Add(this.label8);
            this.tabpageSMTPSetting.Controls.Add(this.label9);
            this.tabpageSMTPSetting.Controls.Add(this.txtPOP3Port);
            this.tabpageSMTPSetting.Controls.Add(this.lblSMTPTitle);
            this.tabpageSMTPSetting.Controls.Add(this.txtFromEmail);
            this.tabpageSMTPSetting.Controls.Add(this.btnSaveSMTPSetting);
            this.tabpageSMTPSetting.Controls.Add(this.chkIsSSL);
            this.tabpageSMTPSetting.Controls.Add(this.btnRestoreDefault);
            this.tabpageSMTPSetting.Controls.Add(this.lblFromEmail);
            this.tabpageSMTPSetting.Controls.Add(this.txtPassword);
            this.tabpageSMTPSetting.Controls.Add(this.label2);
            this.tabpageSMTPSetting.Controls.Add(this.txtHost);
            this.tabpageSMTPSetting.Controls.Add(this.lblSMTPHost);
            this.tabpageSMTPSetting.Controls.Add(this.txtUserName);
            this.tabpageSMTPSetting.Controls.Add(this.label1);
            this.tabpageSMTPSetting.Controls.Add(this.lblSMTPPort);
            this.tabpageSMTPSetting.Controls.Add(this.txtPort);
            this.tabpageSMTPSetting.ImageKey = "icons8-send-30.png";
            this.tabpageSMTPSetting.Location = new System.Drawing.Point(4, 37);
            this.tabpageSMTPSetting.Name = "tabpageSMTPSetting";
            this.tabpageSMTPSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSMTPSetting.Size = new System.Drawing.Size(848, 281);
            this.tabpageSMTPSetting.TabIndex = 0;
            this.tabpageSMTPSetting.Text = "Mail Server Setting";
            this.tabpageSMTPSetting.ToolTipText = "This is email setting for outgoing.";
            this.tabpageSMTPSetting.UseVisualStyleBackColor = true;
            // 
            // lblSMTPTitle
            // 
            this.lblSMTPTitle.AutoSize = true;
            this.lblSMTPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblSMTPTitle.Location = new System.Drawing.Point(12, 21);
            this.lblSMTPTitle.Name = "lblSMTPTitle";
            this.lblSMTPTitle.Size = new System.Drawing.Size(197, 15);
            this.lblSMTPTitle.TabIndex = 13;
            this.lblSMTPTitle.Text = "Set Mail Server Setting for sending ";
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromEmail.Location = new System.Drawing.Point(99, 57);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(489, 21);
            this.txtFromEmail.TabIndex = 1;
            // 
            // btnSaveSMTPSetting
            // 
            this.btnSaveSMTPSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSMTPSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSMTPSetting.ImageKey = "icons8-save-close-16.png";
            this.btnSaveSMTPSetting.ImageList = this.imgCollection16x16;
            this.btnSaveSMTPSetting.Location = new System.Drawing.Point(99, 226);
            this.btnSaveSMTPSetting.Name = "btnSaveSMTPSetting";
            this.btnSaveSMTPSetting.Size = new System.Drawing.Size(181, 32);
            this.btnSaveSMTPSetting.TabIndex = 7;
            this.btnSaveSMTPSetting.Text = "Save Change";
            this.btnSaveSMTPSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSMTPSetting.UseVisualStyleBackColor = true;
            this.btnSaveSMTPSetting.Click += new System.EventHandler(this.btnSaveSMTPSetting_Click);
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
            // 
            // chkIsSSL
            // 
            this.chkIsSSL.AutoSize = true;
            this.chkIsSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsSSL.Location = new System.Drawing.Point(99, 189);
            this.chkIsSSL.Name = "chkIsSSL";
            this.chkIsSSL.Size = new System.Drawing.Size(224, 19);
            this.chkIsSSL.TabIndex = 6;
            this.chkIsSSL.Text = "SMTP server requries authentication";
            this.chkIsSSL.UseVisualStyleBackColor = true;
            // 
            // btnRestoreDefault
            // 
            this.btnRestoreDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDefault.Location = new System.Drawing.Point(173, 111);
            this.btnRestoreDefault.Name = "btnRestoreDefault";
            this.btnRestoreDefault.Size = new System.Drawing.Size(107, 23);
            this.btnRestoreDefault.TabIndex = 12;
            this.btnRestoreDefault.Text = "Restore Default";
            this.btnRestoreDefault.UseVisualStyleBackColor = true;
            this.btnRestoreDefault.Click += new System.EventHandler(this.btnRestoreDefault_Click);
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromEmail.Location = new System.Drawing.Point(12, 60);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(74, 15);
            this.lblFromEmail.TabIndex = 4;
            this.lblFromEmail.Text = "From Email:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(99, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(99, 84);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(181, 21);
            this.txtHost.TabIndex = 2;
            // 
            // lblSMTPHost
            // 
            this.lblSMTPHost.AutoSize = true;
            this.lblSMTPHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPHost.Location = new System.Drawing.Point(12, 87);
            this.lblSMTPHost.Name = "lblSMTPHost";
            this.lblSMTPHost.Size = new System.Drawing.Size(72, 15);
            this.lblSMTPHost.TabIndex = 0;
            this.lblSMTPHost.Text = "SMTP Host:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(99, 138);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(181, 21);
            this.txtUserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name:";
            // 
            // lblSMTPPort
            // 
            this.lblSMTPPort.AutoSize = true;
            this.lblSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPPort.Location = new System.Drawing.Point(15, 114);
            this.lblSMTPPort.Name = "lblSMTPPort";
            this.lblSMTPPort.Size = new System.Drawing.Size(69, 15);
            this.lblSMTPPort.TabIndex = 2;
            this.lblSMTPPort.Text = "SMTP Port:";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(99, 111);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(67, 21);
            this.txtPort.TabIndex = 3;
            // 
            // tbtnEmailArticles
            // 
            this.tbtnEmailArticles.Controls.Add(this.trvArticle);
            this.tbtnEmailArticles.Controls.Add(this.grpArticleInfo);
            this.tbtnEmailArticles.Controls.Add(this.grpActionControls);
            this.tbtnEmailArticles.Controls.Add(this.btnSearch);
            this.tbtnEmailArticles.Controls.Add(this.txtSearchEmailArticle);
            this.tbtnEmailArticles.Controls.Add(this.lblArticleTitle);
            this.tbtnEmailArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnEmailArticles.ImageKey = "icons8-magazine-30.png";
            this.tbtnEmailArticles.Location = new System.Drawing.Point(4, 37);
            this.tbtnEmailArticles.Name = "tbtnEmailArticles";
            this.tbtnEmailArticles.Size = new System.Drawing.Size(848, 281);
            this.tbtnEmailArticles.TabIndex = 1;
            this.tbtnEmailArticles.Text = "Email Articles";
            this.tbtnEmailArticles.ToolTipText = "Email Articles details.";
            this.tbtnEmailArticles.UseVisualStyleBackColor = true;
            // 
            // trvArticle
            // 
            this.trvArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvArticle.ImageKey = "Run-1.png";
            this.trvArticle.ImageList = this.imgCollection16x16;
            this.trvArticle.Location = new System.Drawing.Point(12, 57);
            this.trvArticle.Name = "trvArticle";
            this.trvArticle.SelectedImageKey = "Run-1.png";
            this.trvArticle.Size = new System.Drawing.Size(264, 184);
            this.trvArticle.StateImageList = this.imgCollection16x16;
            this.trvArticle.TabIndex = 10;
            this.trvArticle.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvArticle_NodeMouseDoubleClick);
            // 
            // grpArticleInfo
            // 
            this.grpArticleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpArticleInfo.Controls.Add(this.cmbGroup);
            this.grpArticleInfo.Controls.Add(this.label7);
            this.grpArticleInfo.Controls.Add(this.btnCancelArticleInfo);
            this.grpArticleInfo.Controls.Add(this.btnSaveArticleInfo);
            this.grpArticleInfo.Controls.Add(this.txtArticleDesc);
            this.grpArticleInfo.Controls.Add(this.label6);
            this.grpArticleInfo.Controls.Add(this.btnArticleContentFile);
            this.grpArticleInfo.Controls.Add(this.txtArticleContentPath);
            this.grpArticleInfo.Controls.Add(this.label4);
            this.grpArticleInfo.Controls.Add(this.txtArticleTitle);
            this.grpArticleInfo.Controls.Add(this.label3);
            this.grpArticleInfo.Enabled = false;
            this.grpArticleInfo.Location = new System.Drawing.Point(282, 29);
            this.grpArticleInfo.Name = "grpArticleInfo";
            this.grpArticleInfo.Size = new System.Drawing.Size(563, 247);
            this.grpArticleInfo.TabIndex = 9;
            this.grpArticleInfo.TabStop = false;
            this.grpArticleInfo.Text = "Article Information";
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(128, 43);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(403, 23);
            this.cmbGroup.TabIndex = 4;
            this.cmbGroup.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGroup_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Group:";
            // 
            // btnCancelArticleInfo
            // 
            this.btnCancelArticleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelArticleInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelArticleInfo.ImageKey = "icons8-cancel-16.png";
            this.btnCancelArticleInfo.ImageList = this.imgCollection16x16;
            this.btnCancelArticleInfo.Location = new System.Drawing.Point(442, 212);
            this.btnCancelArticleInfo.Name = "btnCancelArticleInfo";
            this.btnCancelArticleInfo.Size = new System.Drawing.Size(89, 27);
            this.btnCancelArticleInfo.TabIndex = 16;
            this.btnCancelArticleInfo.Text = "Cancel";
            this.btnCancelArticleInfo.UseVisualStyleBackColor = true;
            this.btnCancelArticleInfo.Click += new System.EventHandler(this.btnCancelArticleInfo_Click);
            // 
            // btnSaveArticleInfo
            // 
            this.btnSaveArticleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveArticleInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveArticleInfo.ImageKey = "icons8-save-close-16.png";
            this.btnSaveArticleInfo.ImageList = this.imgCollection16x16;
            this.btnSaveArticleInfo.Location = new System.Drawing.Point(347, 212);
            this.btnSaveArticleInfo.Name = "btnSaveArticleInfo";
            this.btnSaveArticleInfo.Size = new System.Drawing.Size(89, 27);
            this.btnSaveArticleInfo.TabIndex = 15;
            this.btnSaveArticleInfo.Text = "Save";
            this.btnSaveArticleInfo.UseVisualStyleBackColor = true;
            this.btnSaveArticleInfo.Click += new System.EventHandler(this.btnSaveArticleInfo_Click);
            // 
            // txtArticleDesc
            // 
            this.txtArticleDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleDesc.Location = new System.Drawing.Point(129, 123);
            this.txtArticleDesc.Multiline = true;
            this.txtArticleDesc.Name = "txtArticleDesc";
            this.txtArticleDesc.Size = new System.Drawing.Size(402, 77);
            this.txtArticleDesc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description:";
            // 
            // btnArticleContentFile
            // 
            this.btnArticleContentFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArticleContentFile.Location = new System.Drawing.Point(493, 97);
            this.btnArticleContentFile.Name = "btnArticleContentFile";
            this.btnArticleContentFile.Size = new System.Drawing.Size(38, 21);
            this.btnArticleContentFile.TabIndex = 12;
            this.btnArticleContentFile.Text = "...";
            this.btnArticleContentFile.UseVisualStyleBackColor = true;
            this.btnArticleContentFile.Click += new System.EventHandler(this.btnArticleContentFile_Click);
            // 
            // txtArticleContentPath
            // 
            this.txtArticleContentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArticleContentPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleContentPath.Location = new System.Drawing.Point(129, 97);
            this.txtArticleContentPath.Name = "txtArticleContentPath";
            this.txtArticleContentPath.Size = new System.Drawing.Size(361, 21);
            this.txtArticleContentPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Article File Path:";
            // 
            // txtArticleTitle
            // 
            this.txtArticleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticleTitle.Location = new System.Drawing.Point(129, 71);
            this.txtArticleTitle.Name = "txtArticleTitle";
            this.txtArticleTitle.Size = new System.Drawing.Size(402, 21);
            this.txtArticleTitle.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title:";
            // 
            // grpActionControls
            // 
            this.grpActionControls.Controls.Add(this.btnDeleteArticleInfo);
            this.grpActionControls.Controls.Add(this.btnAddArticleInfo);
            this.grpActionControls.Controls.Add(this.btnEditArticleInfo);
            this.grpActionControls.Location = new System.Drawing.Point(165, 239);
            this.grpActionControls.Name = "grpActionControls";
            this.grpActionControls.Size = new System.Drawing.Size(111, 38);
            this.grpActionControls.TabIndex = 7;
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
            // btnSearch
            // 
            this.btnSearch.ImageKey = "icons8-search-16.png";
            this.btnSearch.ImageList = this.imgCollection16x16;
            this.btnSearch.Location = new System.Drawing.Point(246, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchEmailArticle
            // 
            this.txtSearchEmailArticle.Location = new System.Drawing.Point(11, 30);
            this.txtSearchEmailArticle.Name = "txtSearchEmailArticle";
            this.txtSearchEmailArticle.Size = new System.Drawing.Size(229, 21);
            this.txtSearchEmailArticle.TabIndex = 2;
            // 
            // lblArticleTitle
            // 
            this.lblArticleTitle.AutoSize = true;
            this.lblArticleTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblArticleTitle.Location = new System.Drawing.Point(67, 11);
            this.lblArticleTitle.Name = "lblArticleTitle";
            this.lblArticleTitle.Size = new System.Drawing.Size(81, 15);
            this.lblArticleTitle.TabIndex = 0;
            this.lblArticleTitle.Text = "Articles List";
            // 
            // imglist30x30
            // 
            this.imglist30x30.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist30x30.ImageStream")));
            this.imglist30x30.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist30x30.Images.SetKeyName(0, "icons8-magazine-30.png");
            this.imglist30x30.Images.SetKeyName(1, "icons8-send-30.png");
            this.imglist30x30.Images.SetKeyName(2, "icons8-automation-30.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFindfolder);
            this.groupBox1.Controls.Add(this.btnAppPathSave);
            this.groupBox1.Controls.Add(this.txtAppPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application ";
            // 
            // btnFindfolder
            // 
            this.btnFindfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindfolder.Location = new System.Drawing.Point(694, 33);
            this.btnFindfolder.Name = "btnFindfolder";
            this.btnFindfolder.Size = new System.Drawing.Size(38, 21);
            this.btnFindfolder.TabIndex = 11;
            this.btnFindfolder.Text = "...";
            this.btnFindfolder.UseVisualStyleBackColor = true;
            this.btnFindfolder.Click += new System.EventHandler(this.btnFindfolder_Click);
            // 
            // btnAppPathSave
            // 
            this.btnAppPathSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppPathSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppPathSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppPathSave.ImageKey = "icons8-save-close-16.png";
            this.btnAppPathSave.ImageList = this.imgCollection16x16;
            this.btnAppPathSave.Location = new System.Drawing.Point(751, 23);
            this.btnAppPathSave.Name = "btnAppPathSave";
            this.btnAppPathSave.Size = new System.Drawing.Size(107, 31);
            this.btnAppPathSave.TabIndex = 10;
            this.btnAppPathSave.Text = "Save Change";
            this.btnAppPathSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppPathSave.UseVisualStyleBackColor = true;
            this.btnAppPathSave.Click += new System.EventHandler(this.btnAppPathSave_Click);
            // 
            // txtAppPath
            // 
            this.txtAppPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPath.Location = new System.Drawing.Point(109, 33);
            this.txtAppPath.Name = "txtAppPath";
            this.txtAppPath.Size = new System.Drawing.Size(583, 21);
            this.txtAppPath.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Application Path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPOP3Host
            // 
            this.txtPOP3Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOP3Host.Location = new System.Drawing.Point(407, 84);
            this.txtPOP3Host.Name = "txtPOP3Host";
            this.txtPOP3Host.Size = new System.Drawing.Size(181, 21);
            this.txtPOP3Host.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(298, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "POP3/IMPS Host:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(298, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "POP3/IPMS Port:";
            // 
            // txtPOP3Port
            // 
            this.txtPOP3Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOP3Port.Location = new System.Drawing.Point(407, 111);
            this.txtPOP3Port.Name = "txtPOP3Port";
            this.txtPOP3Port.Size = new System.Drawing.Size(181, 21);
            this.txtPOP3Port.TabIndex = 8;
            // 
            // frmSystemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEmailSetting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSystemSetting";
            this.Text = "System Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSystemSetting_FormClosing);
            this.Load += new System.EventHandler(this.frmSystemSetting_Load);
            this.grpEmailSetting.ResumeLayout(false);
            this.tabEmailSetting.ResumeLayout(false);
            this.tabpageSMTPSetting.ResumeLayout(false);
            this.tabpageSMTPSetting.PerformLayout();
            this.tbtnEmailArticles.ResumeLayout(false);
            this.tbtnEmailArticles.PerformLayout();
            this.grpArticleInfo.ResumeLayout(false);
            this.grpArticleInfo.PerformLayout();
            this.grpActionControls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmailSetting;
        private System.Windows.Forms.Button btnSaveSMTPSetting;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblSMTPPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblSMTPHost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindfolder;
        private System.Windows.Forms.Button btnAppPathSave;
        private System.Windows.Forms.TextBox txtAppPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDiallog;
        private System.Windows.Forms.TabControl tabEmailSetting;
        private System.Windows.Forms.TabPage tabpageSMTPSetting;
        private System.Windows.Forms.CheckBox chkIsSSL;
        private System.Windows.Forms.Button btnRestoreDefault;
        private System.Windows.Forms.ImageList imglist30x30;
        private System.Windows.Forms.Label lblSMTPTitle;
        private System.Windows.Forms.TabPage tbtnEmailArticles;
        private System.Windows.Forms.Label lblArticleTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchEmailArticle;
        private System.Windows.Forms.GroupBox grpActionControls;
        private System.Windows.Forms.Button btnDeleteArticleInfo;
        private System.Windows.Forms.Button btnAddArticleInfo;
        private System.Windows.Forms.Button btnEditArticleInfo;
        private System.Windows.Forms.ImageList imgCollection16x16;
        private System.Windows.Forms.GroupBox grpArticleInfo;
        private System.Windows.Forms.TextBox txtArticleDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnArticleContentFile;
        private System.Windows.Forms.TextBox txtArticleContentPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArticleTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelArticleInfo;
        private System.Windows.Forms.Button btnSaveArticleInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TreeView trvArticle;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPOP3Host;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPOP3Port;
    }
}