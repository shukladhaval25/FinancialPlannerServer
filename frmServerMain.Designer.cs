namespace FinancialPlannerServer
{
    partial class frmServerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerMain));
            this.diagramControl = new DevExpress.XtraDiagram.DiagramControl();
            this.pnlServerMenu = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpCompanyDetails = new System.Windows.Forms.GroupBox();
            this.grpDeskboard = new System.Windows.Forms.GroupBox();
            this.toolBarMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.diagramOrgChartController1 = new DevExpress.XtraDiagram.DiagramOrgChartController(this.components);
            this.diagramContainer1 = new DevExpress.XtraDiagram.DiagramContainer();
            this.diagramShape1 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape2 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramShape4 = new DevExpress.XtraDiagram.DiagramShape();
            this.diagramConnector1 = new DevExpress.XtraDiagram.DiagramConnector();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.diagramShape3 = new DevExpress.XtraDiagram.DiagramShape();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbtnUser = new System.Windows.Forms.ToolStripButton();
            this.tbtnRoles = new System.Windows.Forms.ToolStripButton();
            this.tbtnSecurity = new System.Windows.Forms.ToolStripButton();
            this.tbtnEmail = new System.Windows.Forms.ToolStripButton();
            this.tbtnAuditTrail = new System.Windows.Forms.ToolStripButton();
            this.tbtnReports = new System.Windows.Forms.ToolStripSplitButton();
            this.quaterlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSystemSetting = new System.Windows.Forms.ToolStripSplitButton();
            this.SystemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.companyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuarterlyReviewSheetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnnualReviewSheetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnNotification = new System.Windows.Forms.ToolStripButton();
            this.tbtnProcesses = new System.Windows.Forms.ToolStripButton();
            this.tbtnDepartmentHierarchy = new System.Windows.Forms.ToolStripButton();
            this.tbtbScopeSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.scoreMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbtnRiskProfile = new System.Windows.Forms.ToolStripButton();
            this.tbtnLogout = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSystemSetting = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAuditTrailList = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).BeginInit();
            this.pnlServerMenu.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpCompanyDetails.SuspendLayout();
            this.grpDeskboard.SuspendLayout();
            this.toolBarMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1.TemplateDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // diagramControl
            // 
            this.diagramControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagramControl.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape3});
            this.diagramControl.Location = new System.Drawing.Point(3, 40);
            this.diagramControl.Name = "diagramControl";
            this.diagramControl.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes"});
            this.diagramControl.OptionsBehavior.SnapToGrid = false;
            this.diagramControl.OptionsBehavior.SnapToItems = false;
            this.diagramControl.OptionsView.BringIntoViewMargin = 5F;
            this.diagramControl.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramControl.OptionsView.PageMargin = new System.Windows.Forms.Padding(10);
            this.diagramControl.OptionsView.PageSize = new System.Drawing.SizeF(308F, 188F);
            this.diagramControl.OptionsView.ScrollMargin = new System.Windows.Forms.Padding(10);
            this.diagramControl.OptionsView.ShowGrid = false;
            this.diagramControl.OptionsView.ShowPageBreaks = false;
            this.diagramControl.OptionsView.ShowRulers = false;
            this.diagramControl.Size = new System.Drawing.Size(890, 332);
            this.diagramControl.TabIndex = 1;
            this.diagramControl.Click += new System.EventHandler(this.diagramControl_Click);
            // 
            // pnlServerMenu
            // 
            this.pnlServerMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlServerMenu.Controls.Add(this.btnLogout);
            this.pnlServerMenu.Controls.Add(this.btnSystemSetting);
            this.pnlServerMenu.Controls.Add(this.button7);
            this.pnlServerMenu.Controls.Add(this.button6);
            this.pnlServerMenu.Controls.Add(this.btnAuditTrailList);
            this.pnlServerMenu.Controls.Add(this.button4);
            this.pnlServerMenu.Controls.Add(this.button3);
            this.pnlServerMenu.Controls.Add(this.button2);
            this.pnlServerMenu.Controls.Add(this.btnUser);
            this.pnlServerMenu.Location = new System.Drawing.Point(0, 85);
            this.pnlServerMenu.Name = "pnlServerMenu";
            this.pnlServerMenu.Size = new System.Drawing.Size(10, 462);
            this.pnlServerMenu.TabIndex = 0;
            this.pnlServerMenu.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "81RTZvc5q5L._SL1500_.jpg");
            this.imageList1.Images.SetKeyName(1, "Notification globe enable.png");
            this.imageList1.Images.SetKeyName(2, "Email_Suggestion_Link.png");
            this.imageList1.Images.SetKeyName(3, "Setting.png");
            this.imageList1.Images.SetKeyName(4, "client_icon_group64.png");
            this.imageList1.Images.SetKeyName(5, "AdministrativeTool_30.png");
            this.imageList1.Images.SetKeyName(6, "shutdown-30.png");
            this.imageList1.Images.SetKeyName(7, "AuditTrail-30.png");
            this.imageList1.Images.SetKeyName(8, "Roles - 30.png");
            this.imageList1.Images.SetKeyName(9, "SecurityAccess-30.png");
            this.imageList1.Images.SetKeyName(10, "icons8-access-30.png");
            this.imageList1.Images.SetKeyName(11, "icons8-group-message-30.png");
            this.imageList1.Images.SetKeyName(12, "icons8-select-users-30.png");
            this.imageList1.Images.SetKeyName(13, "icons8-new-document-30.png");
            this.imageList1.Images.SetKeyName(14, "icons8-notification-30.png");
            this.imageList1.Images.SetKeyName(15, "icons8-double-right-16.png");
            this.imageList1.Images.SetKeyName(16, "icons8-double-left-16.png");
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.grpCompanyDetails);
            this.pnlContainer.Controls.Add(this.grpDeskboard);
            this.pnlContainer.Location = new System.Drawing.Point(3, 85);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(907, 462);
            this.pnlContainer.TabIndex = 1;
            this.pnlContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlContainer_ControlAdded);
            this.pnlContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlContainer_ControlRemoved);
            // 
            // grpCompanyDetails
            // 
            this.grpCompanyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCompanyDetails.Controls.Add(this.pictureBox1);
            this.grpCompanyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCompanyDetails.Location = new System.Drawing.Point(3, 3);
            this.grpCompanyDetails.Name = "grpCompanyDetails";
            this.grpCompanyDetails.Size = new System.Drawing.Size(889, 74);
            this.grpCompanyDetails.TabIndex = 0;
            this.grpCompanyDetails.TabStop = false;
            // 
            // grpDeskboard
            // 
            this.grpDeskboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDeskboard.Controls.Add(this.labelControl1);
            this.grpDeskboard.Controls.Add(this.diagramControl);
            this.grpDeskboard.Location = new System.Drawing.Point(6, 80);
            this.grpDeskboard.Name = "grpDeskboard";
            this.grpDeskboard.Size = new System.Drawing.Size(896, 375);
            this.grpDeskboard.TabIndex = 0;
            this.grpDeskboard.TabStop = false;
            // 
            // toolBarMain
            // 
            this.toolBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnUser,
            this.tbtnRoles,
            this.tbtnSecurity,
            this.toolStripSeparator1,
            this.tbtnEmail,
            this.tbtnAuditTrail,
            this.toolStripSeparator2,
            this.tbtnReports,
            this.toolStripSystemSetting,
            this.tbtnNotification,
            this.tbtnProcesses,
            this.tbtnDepartmentHierarchy,
            this.toolStripSeparator3,
            this.tbtbScopeSetting,
            this.tbtnRiskProfile,
            this.tbtnLogout});
            this.toolBarMain.Location = new System.Drawing.Point(0, 0);
            this.toolBarMain.Name = "toolBarMain";
            this.toolBarMain.Size = new System.Drawing.Size(912, 82);
            this.toolBarMain.TabIndex = 3;
            this.toolBarMain.Text = "MainToolBar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 82);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 82);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 82);
            // 
            // diagramOrgChartController1
            // 
            this.diagramOrgChartController1.Diagram = this.diagramControl;
            this.diagramOrgChartController1.KeyMember = "Id";
            this.diagramOrgChartController1.ParentMember = "ReportToId";
            // 
            // 
            // 
            this.diagramOrgChartController1.TemplateDiagram.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramContainer1,
            this.diagramConnector1});
            this.diagramOrgChartController1.TemplateDiagram.Location = new System.Drawing.Point(0, 0);
            this.diagramOrgChartController1.TemplateDiagram.Name = "";
            this.diagramOrgChartController1.TemplateDiagram.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "TemplateDesigner"});
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.CanvasSizeMode = DevExpress.Diagram.Core.CanvasSizeMode.Fill;
            this.diagramOrgChartController1.TemplateDiagram.OptionsView.ShowPageBreaks = false;
            this.diagramOrgChartController1.TemplateDiagram.TabIndex = 0;
            // 
            // diagramContainer1
            // 
            this.diagramContainer1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.diagramContainer1.BackgroundId = DevExpress.Diagram.Core.DiagramThemeColorId.White;
            this.diagramContainer1.CanAddItems = false;
            this.diagramContainer1.CanCopyWithoutParent = true;
            this.diagramContainer1.ConnectionPoints = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(0.5F, 0F),
            new DevExpress.Utils.PointFloat(1F, 0.5F),
            new DevExpress.Utils.PointFloat(0.5F, 1F),
            new DevExpress.Utils.PointFloat(0F, 0.5F)});
            this.diagramContainer1.DragMode = DevExpress.Diagram.Core.ContainerDragMode.ByAnyPoint;
            this.diagramContainer1.Items.AddRange(new DevExpress.XtraDiagram.DiagramItem[] {
            this.diagramShape1,
            this.diagramShape2,
            this.diagramShape4});
            this.diagramContainer1.ItemsCanAttachConnectorBeginPoint = false;
            this.diagramContainer1.ItemsCanAttachConnectorEndPoint = false;
            this.diagramContainer1.ItemsCanChangeParent = false;
            this.diagramContainer1.ItemsCanCopyWithoutParent = false;
            this.diagramContainer1.ItemsCanDeleteWithoutParent = false;
            this.diagramContainer1.ItemsCanEdit = false;
            this.diagramContainer1.ItemsCanMove = false;
            this.diagramContainer1.ItemsCanResize = false;
            this.diagramContainer1.ItemsCanRotate = false;
            this.diagramContainer1.ItemsCanSelect = false;
            this.diagramContainer1.ItemsCanSnapToOtherItems = false;
            this.diagramContainer1.ItemsCanSnapToThisItem = false;
            this.diagramContainer1.Size = new System.Drawing.SizeF(440F, 170F);
            this.diagramContainer1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Variant2;
            // 
            // diagramShape1
            // 
            this.diagramShape1.Anchors = ((DevExpress.Diagram.Core.Sides)((DevExpress.Diagram.Core.Sides.Top | DevExpress.Diagram.Core.Sides.Right)));
            this.diagramShape1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.diagramShape1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape1.Appearance.BorderSize = 0;
            this.diagramShape1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.diagramShape1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.diagramShape1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.diagramShape1.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "DesignationId"));
            this.diagramShape1.CanCopy = false;
            this.diagramShape1.CanCopyWithoutParent = false;
            this.diagramShape1.CanEdit = false;
            this.diagramShape1.CanMove = false;
            this.diagramShape1.CanResize = false;
            this.diagramShape1.CanRotate = false;
            this.diagramShape1.CanSelect = false;
            this.diagramShape1.CanSnapToOtherItems = false;
            this.diagramShape1.CanSnapToThisItem = false;
            this.diagramShape1.Position = new DevExpress.Utils.PointFloat(20F, 20F);
            this.diagramShape1.Size = new System.Drawing.SizeF(170F, 40F);
            this.diagramShape1.ThemeStyleId = DevExpress.Diagram.Core.DiagramShapeStyleId.Subtle1;
            // 
            // diagramShape2
            // 
            this.diagramShape2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape2.Appearance.BorderSize = 0;
            this.diagramShape2.Appearance.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.diagramShape2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape2.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "FirstName"));
            this.diagramShape2.CanAttachConnectorBeginPoint = false;
            this.diagramShape2.CanAttachConnectorEndPoint = false;
            this.diagramShape2.CanChangeParent = false;
            this.diagramShape2.CanCopyWithoutParent = false;
            this.diagramShape2.CanDeleteWithoutParent = false;
            this.diagramShape2.CanEdit = false;
            this.diagramShape2.CanMove = false;
            this.diagramShape2.CanResize = false;
            this.diagramShape2.CanRotate = false;
            this.diagramShape2.CanSelect = false;
            this.diagramShape2.Position = new DevExpress.Utils.PointFloat(0F, 65F);
            this.diagramShape2.Size = new System.Drawing.SizeF(440F, 50F);
            // 
            // diagramShape4
            // 
            this.diagramShape4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diagramShape4.Appearance.BorderSize = 0;
            this.diagramShape4.Appearance.Font = new System.Drawing.Font("Tahoma", 28F);
            this.diagramShape4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.diagramShape4.Bindings.Add(new DevExpress.Diagram.Core.DiagramBinding("Content", "LastName"));
            this.diagramShape4.CanAttachConnectorBeginPoint = false;
            this.diagramShape4.CanAttachConnectorEndPoint = false;
            this.diagramShape4.CanChangeParent = false;
            this.diagramShape4.CanCopyWithoutParent = false;
            this.diagramShape4.CanDeleteWithoutParent = false;
            this.diagramShape4.CanEdit = false;
            this.diagramShape4.CanMove = false;
            this.diagramShape4.CanResize = false;
            this.diagramShape4.CanRotate = false;
            this.diagramShape4.CanSelect = false;
            this.diagramShape4.Position = new DevExpress.Utils.PointFloat(0F, 120F);
            this.diagramShape4.Size = new System.Drawing.SizeF(440F, 50F);
            // 
            // diagramConnector1
            // 
            this.diagramConnector1.Appearance.ContentBackground = System.Drawing.Color.White;
            this.diagramConnector1.BeginPoint = new DevExpress.Utils.PointFloat(440F, 80F);
            this.diagramConnector1.CanChangeRoute = false;
            this.diagramConnector1.CanDragBeginPoint = false;
            this.diagramConnector1.CanDragEndPoint = false;
            this.diagramConnector1.EndPoint = new DevExpress.Utils.PointFloat(530F, 170F);
            this.diagramConnector1.Points = new DevExpress.XtraDiagram.PointCollection(new DevExpress.Utils.PointFloat[] {
            new DevExpress.Utils.PointFloat(530F, 80F)});
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(0, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(893, 23);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Organisation Hierachy Chart";
            // 
            // diagramShape3
            // 
            this.diagramShape3.Position = new DevExpress.Utils.PointFloat(24F, 24F);
            this.diagramShape3.Shape = DevExpress.Diagram.Core.BasicShapes.SnipCornerRectangle;
            this.diagramShape3.Size = new System.Drawing.SizeF(260F, 140F);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.ImageKey = "shutdown-30.png";
            this.btnLogout.ImageList = this.imageList1;
            this.btnLogout.Location = new System.Drawing.Point(3, 372);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 43);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbtnUser
            // 
            this.tbtnUser.Image = ((System.Drawing.Image)(resources.GetObject("tbtnUser.Image")));
            this.tbtnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUser.Name = "tbtnUser";
            this.tbtnUser.Size = new System.Drawing.Size(64, 79);
            this.tbtnUser.Text = "User";
            this.tbtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnUser.ToolTipText = "User Inforamtion";
            this.tbtnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // tbtnRoles
            // 
            this.tbtnRoles.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRoles.Image")));
            this.tbtnRoles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnRoles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRoles.Name = "tbtnRoles";
            this.tbtnRoles.Size = new System.Drawing.Size(64, 79);
            this.tbtnRoles.Text = "Roles";
            this.tbtnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnRoles.ToolTipText = "Roles";
            this.tbtnRoles.Click += new System.EventHandler(this.tbtnRoles_Click);
            // 
            // tbtnSecurity
            // 
            this.tbtnSecurity.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSecurity.Image")));
            this.tbtnSecurity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnSecurity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSecurity.Name = "tbtnSecurity";
            this.tbtnSecurity.Size = new System.Drawing.Size(64, 79);
            this.tbtnSecurity.Text = "Security";
            this.tbtnSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnSecurity.ToolTipText = "Security";
            this.tbtnSecurity.Visible = false;
            this.tbtnSecurity.Click += new System.EventHandler(this.tbtnSecurity_Click);
            // 
            // tbtnEmail
            // 
            this.tbtnEmail.Image = ((System.Drawing.Image)(resources.GetObject("tbtnEmail.Image")));
            this.tbtnEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnEmail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEmail.Name = "tbtnEmail";
            this.tbtnEmail.Size = new System.Drawing.Size(80, 79);
            this.tbtnEmail.Text = "Email Setting";
            this.tbtnEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnEmail.ToolTipText = "Email";
            this.tbtnEmail.Click += new System.EventHandler(this.tbtnEmail_Click);
            // 
            // tbtnAuditTrail
            // 
            this.tbtnAuditTrail.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAuditTrail.Image")));
            this.tbtnAuditTrail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnAuditTrail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAuditTrail.Name = "tbtnAuditTrail";
            this.tbtnAuditTrail.Size = new System.Drawing.Size(64, 79);
            this.tbtnAuditTrail.Text = "Audit Trail";
            this.tbtnAuditTrail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnAuditTrail.ToolTipText = "Audit Trail";
            this.tbtnAuditTrail.Click += new System.EventHandler(this.btnAuditTrailList_Click);
            // 
            // tbtnReports
            // 
            this.tbtnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quaterlyReportToolStripMenuItem});
            this.tbtnReports.Image = ((System.Drawing.Image)(resources.GetObject("tbtnReports.Image")));
            this.tbtnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnReports.Name = "tbtnReports";
            this.tbtnReports.Size = new System.Drawing.Size(76, 79);
            this.tbtnReports.Text = "Reports";
            this.tbtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // quaterlyReportToolStripMenuItem
            // 
            this.quaterlyReportToolStripMenuItem.Name = "quaterlyReportToolStripMenuItem";
            this.quaterlyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quaterlyReportToolStripMenuItem.Text = "Quaterly Report";
            this.quaterlyReportToolStripMenuItem.Click += new System.EventHandler(this.quaterlyReportToolStripMenuItem_Click);
            // 
            // toolStripSystemSetting
            // 
            this.toolStripSystemSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSystemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemSetting,
            this.companyInformationToolStripMenuItem,
            this.QuarterlyReviewSheetMenuItem,
            this.AnnualReviewSheetMenuItem});
            this.toolStripSystemSetting.Image = global::FinancialPlannerServer.Properties.Resources.AdministrativeTool_60;
            this.toolStripSystemSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSystemSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSystemSetting.Name = "toolStripSystemSetting";
            this.toolStripSystemSetting.Size = new System.Drawing.Size(76, 79);
            this.toolStripSystemSetting.Text = "Setting";
            this.toolStripSystemSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SystemSetting
            // 
            this.SystemSetting.Image = global::FinancialPlannerServer.Properties.Resources.AdministrativeTool_30;
            this.SystemSetting.Name = "SystemSetting";
            this.SystemSetting.Size = new System.Drawing.Size(192, 22);
            this.SystemSetting.Text = "System Setting";
            this.SystemSetting.Click += new System.EventHandler(this.btnSystemSetting_Click);
            // 
            // companyInformationToolStripMenuItem
            // 
            this.companyInformationToolStripMenuItem.Image = global::FinancialPlannerServer.Properties.Resources.icons8_new_company_30;
            this.companyInformationToolStripMenuItem.Name = "companyInformationToolStripMenuItem";
            this.companyInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.companyInformationToolStripMenuItem.Text = "Company Information";
            this.companyInformationToolStripMenuItem.Click += new System.EventHandler(this.companyInformationToolStripMenuItem_Click);
            // 
            // QuarterlyReviewSheetMenuItem
            // 
            this.QuarterlyReviewSheetMenuItem.Name = "QuarterlyReviewSheetMenuItem";
            this.QuarterlyReviewSheetMenuItem.Size = new System.Drawing.Size(192, 22);
            this.QuarterlyReviewSheetMenuItem.Text = "Quaterly Review Sheet";
            this.QuarterlyReviewSheetMenuItem.Click += new System.EventHandler(this.QuarterlyReviewSheetMenuItem_Click);
            // 
            // AnnualReviewSheetMenuItem
            // 
            this.AnnualReviewSheetMenuItem.Name = "AnnualReviewSheetMenuItem";
            this.AnnualReviewSheetMenuItem.Size = new System.Drawing.Size(192, 22);
            this.AnnualReviewSheetMenuItem.Text = "Annual Review Sheet";
            this.AnnualReviewSheetMenuItem.Click += new System.EventHandler(this.AnnualReviewSheetMenuItem_Click);
            // 
            // tbtnNotification
            // 
            this.tbtnNotification.Image = ((System.Drawing.Image)(resources.GetObject("tbtnNotification.Image")));
            this.tbtnNotification.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnNotification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNotification.Name = "tbtnNotification";
            this.tbtnNotification.Size = new System.Drawing.Size(74, 79);
            this.tbtnNotification.Text = "Notification";
            this.tbtnNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnNotification.ToolTipText = "Notification";
            this.tbtnNotification.Visible = false;
            // 
            // tbtnProcesses
            // 
            this.tbtnProcesses.Image = global::FinancialPlannerServer.Properties.Resources.work_process;
            this.tbtnProcesses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnProcesses.ImageTransparentColor = System.Drawing.Color.White;
            this.tbtnProcesses.Name = "tbtnProcesses";
            this.tbtnProcesses.Size = new System.Drawing.Size(64, 79);
            this.tbtnProcesses.Text = "Processes";
            this.tbtnProcesses.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tbtnProcesses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnProcesses.Click += new System.EventHandler(this.tbtnProcesses_Click);
            // 
            // tbtnDepartmentHierarchy
            // 
            this.tbtnDepartmentHierarchy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDepartmentHierarchy.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDepartmentHierarchy.Image")));
            this.tbtnDepartmentHierarchy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnDepartmentHierarchy.ImageTransparentColor = System.Drawing.Color.White;
            this.tbtnDepartmentHierarchy.Name = "tbtnDepartmentHierarchy";
            this.tbtnDepartmentHierarchy.Size = new System.Drawing.Size(64, 79);
            this.tbtnDepartmentHierarchy.Text = "Department Hierarchy";
            this.tbtnDepartmentHierarchy.Click += new System.EventHandler(this.tbtnDepartmentHierarchy_Click);
            // 
            // tbtbScopeSetting
            // 
            this.tbtbScopeSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreMasterToolStripMenuItem,
            this.scoreEntryToolStripMenuItem});
            this.tbtbScopeSetting.Image = global::FinancialPlannerServer.Properties.Resources.pie_chart;
            this.tbtbScopeSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtbScopeSetting.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tbtbScopeSetting.Name = "tbtbScopeSetting";
            this.tbtbScopeSetting.Size = new System.Drawing.Size(149, 79);
            this.tbtbScopeSetting.Text = "Score Setting";
            this.tbtbScopeSetting.Click += new System.EventHandler(this.tbtbScopeSetting_Click);
            // 
            // scoreMasterToolStripMenuItem
            // 
            this.scoreMasterToolStripMenuItem.Name = "scoreMasterToolStripMenuItem";
            this.scoreMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scoreMasterToolStripMenuItem.Text = "Score Master";
            this.scoreMasterToolStripMenuItem.Click += new System.EventHandler(this.scoreMasterToolStripMenuItem_Click);
            // 
            // scoreEntryToolStripMenuItem
            // 
            this.scoreEntryToolStripMenuItem.Name = "scoreEntryToolStripMenuItem";
            this.scoreEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scoreEntryToolStripMenuItem.Text = "Score Entry";
            this.scoreEntryToolStripMenuItem.Click += new System.EventHandler(this.scoreEntryToolStripMenuItem_Click);
            // 
            // tbtnRiskProfile
            // 
            this.tbtnRiskProfile.Image = global::FinancialPlannerServer.Properties.Resources.risk1;
            this.tbtnRiskProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tbtnRiskProfile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnRiskProfile.ImageTransparentColor = System.Drawing.Color.White;
            this.tbtnRiskProfile.Name = "tbtnRiskProfile";
            this.tbtnRiskProfile.Size = new System.Drawing.Size(129, 79);
            this.tbtnRiskProfile.Text = "Risk Profile";
            this.tbtnRiskProfile.Click += new System.EventHandler(this.tbtnRiskProfile_Click);
            // 
            // tbtnLogout
            // 
            this.tbtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("tbtnLogout.Image")));
            this.tbtnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnLogout.Name = "tbtnLogout";
            this.tbtnLogout.Size = new System.Drawing.Size(64, 79);
            this.tbtnLogout.Text = "Logout";
            this.tbtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSystemSetting
            // 
            this.btnSystemSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemSetting.ImageKey = "AdministrativeTool_30.png";
            this.btnSystemSetting.ImageList = this.imageList1;
            this.btnSystemSetting.Location = new System.Drawing.Point(3, 325);
            this.btnSystemSetting.Name = "btnSystemSetting";
            this.btnSystemSetting.Size = new System.Drawing.Size(137, 43);
            this.btnSystemSetting.TabIndex = 7;
            this.btnSystemSetting.Text = "System Setting";
            this.btnSystemSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystemSetting.UseVisualStyleBackColor = true;
            this.btnSystemSetting.Click += new System.EventHandler(this.btnSystemSetting_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.ImageKey = "icons8-notification-30.png";
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(3, 279);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 43);
            this.button7.TabIndex = 6;
            this.button7.Text = "Notification";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.ImageKey = "icons8-new-document-30.png";
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(3, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Reports";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnAuditTrailList
            // 
            this.btnAuditTrailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditTrailList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditTrailList.ImageKey = "AuditTrail-30.png";
            this.btnAuditTrailList.ImageList = this.imageList1;
            this.btnAuditTrailList.Location = new System.Drawing.Point(3, 187);
            this.btnAuditTrailList.Name = "btnAuditTrailList";
            this.btnAuditTrailList.Size = new System.Drawing.Size(137, 43);
            this.btnAuditTrailList.TabIndex = 4;
            this.btnAuditTrailList.Text = "Audit Trail";
            this.btnAuditTrailList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditTrailList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuditTrailList.UseVisualStyleBackColor = true;
            this.btnAuditTrailList.Click += new System.EventHandler(this.btnAuditTrailList_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "icons8-group-message-30.png";
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(3, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Email Setting";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.tbtnEmail_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "icons8-access-30.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(3, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Security";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "Roles - 30.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(3, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Roles";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.ImageKey = "icons8-select-users-30.png";
            this.btnUser.ImageList = this.imageList1;
            this.btnUser.Location = new System.Drawing.Point(3, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(137, 43);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // frmServerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(912, 548);
            this.Controls.Add(this.toolBarMain);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlServerMenu);
            this.IsMdiContainer = true;
            this.Name = "frmServerMain";
            this.Text = "Fiancial Planner (Server Appolication)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServerMain_FormClosing);
            this.Load += new System.EventHandler(this.frmServerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl)).EndInit();
            this.pnlServerMenu.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.grpCompanyDetails.ResumeLayout(false);
            this.grpDeskboard.ResumeLayout(false);
            this.toolBarMain.ResumeLayout(false);
            this.toolBarMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1.TemplateDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramOrgChartController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDiagram.DiagramControl diagramControl;
        private System.Windows.Forms.Panel pnlServerMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSystemSetting;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnAuditTrailList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.GroupBox grpDeskboard;
        private System.Windows.Forms.GroupBox grpCompanyDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolBarMain;
        private System.Windows.Forms.ToolStripButton tbtnUser;
        private System.Windows.Forms.ToolStripButton tbtnRoles;
        private System.Windows.Forms.ToolStripButton tbtnSecurity;
        private System.Windows.Forms.ToolStripButton tbtnEmail;
        private System.Windows.Forms.ToolStripButton tbtnAuditTrail;
        private System.Windows.Forms.ToolStripButton tbtnNotification;
        private System.Windows.Forms.ToolStripButton tbtnLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSystemSetting;
        private System.Windows.Forms.ToolStripMenuItem SystemSetting;
        private System.Windows.Forms.ToolStripMenuItem companyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tbtnReports;
        private System.Windows.Forms.ToolStripMenuItem quaterlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuarterlyReviewSheetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnnualReviewSheetMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tbtbScopeSetting;
        private System.Windows.Forms.ToolStripMenuItem scoreMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tbtnRiskProfile;
        private System.Windows.Forms.ToolStripButton tbtnProcesses;
        private System.Windows.Forms.ToolStripButton tbtnDepartmentHierarchy;
        private DevExpress.XtraDiagram.DiagramOrgChartController diagramOrgChartController1;
        private DevExpress.XtraDiagram.DiagramContainer diagramContainer1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape2;
        private DevExpress.XtraDiagram.DiagramShape diagramShape4;
        private DevExpress.XtraDiagram.DiagramConnector diagramConnector1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraDiagram.DiagramShape diagramShape3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}