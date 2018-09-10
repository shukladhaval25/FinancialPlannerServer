namespace FinancialPlannerServer.Security
{
    partial class RolesSecurity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesSecurity));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelRoles = new System.Windows.Forms.Button();
            this.btnSaveRoles = new System.Windows.Forms.Button();
            this.grpSecurity = new System.Windows.Forms.GroupBox();
            this.dataGridSecurity = new System.Windows.Forms.DataGridView();
            this.grpRoles = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.imgCollection = new System.Windows.Forms.ImageList(this.components);
            this.trvList = new System.Windows.Forms.TreeView();
            this.grpActionControls = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtRoleDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecurity)).BeginInit();
            this.grpRoles.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpActionControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.trvList);
            this.splitContainer1.Panel1.Controls.Add(this.grpActionControls);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelRoles);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveRoles);
            this.splitContainer1.Panel2.Controls.Add(this.grpSecurity);
            this.splitContainer1.Panel2.Controls.Add(this.grpRoles);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 518);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCancelRoles
            // 
            this.btnCancelRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelRoles.Enabled = false;
            this.btnCancelRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelRoles.ImageKey = "icons8-cancel-16.png";
            this.btnCancelRoles.Location = new System.Drawing.Point(756, 480);
            this.btnCancelRoles.Name = "btnCancelRoles";
            this.btnCancelRoles.Size = new System.Drawing.Size(86, 26);
            this.btnCancelRoles.TabIndex = 63;
            this.btnCancelRoles.Text = "Cancel";
            this.btnCancelRoles.UseVisualStyleBackColor = true;
            this.btnCancelRoles.Click += new System.EventHandler(this.btnCancelRoles_Click);
            // 
            // btnSaveRoles
            // 
            this.btnSaveRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveRoles.Enabled = false;
            this.btnSaveRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveRoles.ImageKey = "icons8-save-close-16.png";
            this.btnSaveRoles.Location = new System.Drawing.Point(664, 480);
            this.btnSaveRoles.Name = "btnSaveRoles";
            this.btnSaveRoles.Size = new System.Drawing.Size(86, 26);
            this.btnSaveRoles.TabIndex = 62;
            this.btnSaveRoles.Text = "Save";
            this.btnSaveRoles.UseVisualStyleBackColor = true;
            // 
            // grpSecurity
            // 
            this.grpSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSecurity.Controls.Add(this.dataGridSecurity);
            this.grpSecurity.Enabled = false;
            this.grpSecurity.Location = new System.Drawing.Point(3, 79);
            this.grpSecurity.Name = "grpSecurity";
            this.grpSecurity.Size = new System.Drawing.Size(839, 395);
            this.grpSecurity.TabIndex = 61;
            this.grpSecurity.TabStop = false;
            this.grpSecurity.Text = "Security";
            // 
            // dataGridSecurity
            // 
            this.dataGridSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSecurity.Location = new System.Drawing.Point(7, 20);
            this.dataGridSecurity.Name = "dataGridSecurity";
            this.dataGridSecurity.Size = new System.Drawing.Size(826, 366);
            this.dataGridSecurity.TabIndex = 0;
            // 
            // grpRoles
            // 
            this.grpRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRoles.Controls.Add(this.txtRoleDescription);
            this.grpRoles.Controls.Add(this.label1);
            this.grpRoles.Controls.Add(this.txtRoleName);
            this.grpRoles.Controls.Add(this.lblRoleName);
            this.grpRoles.Enabled = false;
            this.grpRoles.Location = new System.Drawing.Point(3, 3);
            this.grpRoles.Name = "grpRoles";
            this.grpRoles.Size = new System.Drawing.Size(839, 70);
            this.grpRoles.TabIndex = 60;
            this.grpRoles.TabStop = false;
            this.grpRoles.Text = "Role";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Location = new System.Drawing.Point(8, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(161, 50);
            this.grpSearch.TabIndex = 9;
            this.grpSearch.TabStop = false;
            this.grpSearch.Tag = "t";
            this.grpSearch.Text = "Search By";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(8, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(115, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 482);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 24);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ImageIndex = 8;
            this.btnSearch.ImageList = this.imgCollection;
            this.btnSearch.Location = new System.Drawing.Point(126, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // imgCollection
            // 
            this.imgCollection.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCollection.ImageStream")));
            this.imgCollection.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCollection.Images.SetKeyName(0, "Add-Action.png");
            this.imgCollection.Images.SetKeyName(1, "delete.png");
            this.imgCollection.Images.SetKeyName(2, "deleteline.png");
            this.imgCollection.Images.SetKeyName(3, "drop-add.gif");
            this.imgCollection.Images.SetKeyName(4, "Edit.png");
            this.imgCollection.Images.SetKeyName(5, "User.png");
            this.imgCollection.Images.SetKeyName(6, "VirtualUser.png");
            this.imgCollection.Images.SetKeyName(7, "icons8-circled-play-16.png");
            this.imgCollection.Images.SetKeyName(8, "icons8-search-16.png");
            this.imgCollection.Images.SetKeyName(9, "icons8-customer-16.png");
            // 
            // trvList
            // 
            this.trvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvList.FullRowSelect = true;
            this.trvList.ImageIndex = 0;
            this.trvList.ImageList = this.imgCollection;
            this.trvList.Location = new System.Drawing.Point(8, 68);
            this.trvList.Name = "trvList";
            this.trvList.SelectedImageIndex = 7;
            this.trvList.Size = new System.Drawing.Size(161, 407);
            this.trvList.StateImageList = this.imgCollection;
            this.trvList.TabIndex = 11;
            // 
            // grpActionControls
            // 
            this.grpActionControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActionControls.Controls.Add(this.btnDelete);
            this.grpActionControls.Controls.Add(this.btnAdd);
            this.grpActionControls.Controls.Add(this.btnEdit);
            this.grpActionControls.Location = new System.Drawing.Point(58, 471);
            this.grpActionControls.Name = "grpActionControls";
            this.grpActionControls.Size = new System.Drawing.Size(111, 38);
            this.grpActionControls.TabIndex = 12;
            this.grpActionControls.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.ImageIndex = 1;
            this.btnDelete.ImageList = this.imgCollection;
            this.btnDelete.Location = new System.Drawing.Point(76, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(29, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 3;
            this.btnAdd.ImageList = this.imgCollection;
            this.btnAdd.Location = new System.Drawing.Point(6, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 4;
            this.btnEdit.ImageList = this.imgCollection;
            this.btnEdit.Location = new System.Drawing.Point(41, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(29, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(6, 28);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(63, 13);
            this.lblRoleName.TabIndex = 0;
            this.lblRoleName.Text = "Role Name:";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(75, 25);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(188, 20);
            this.txtRoleName.TabIndex = 1;
            // 
            // txtRoleDescription
            // 
            this.txtRoleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoleDescription.Location = new System.Drawing.Point(340, 13);
            this.txtRoleDescription.Multiline = true;
            this.txtRoleDescription.Name = "txtRoleDescription";
            this.txtRoleDescription.Size = new System.Drawing.Size(497, 48);
            this.txtRoleDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description:";
            // 
            // RolesSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 518);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RolesSecurity";
            this.Text = "Roles & Security";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpSecurity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecurity)).EndInit();
            this.grpRoles.ResumeLayout(false);
            this.grpRoles.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpActionControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCancelRoles;
        private System.Windows.Forms.Button btnSaveRoles;
        private System.Windows.Forms.GroupBox grpSecurity;
        private System.Windows.Forms.DataGridView dataGridSecurity;
        private System.Windows.Forms.GroupBox grpRoles;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imgCollection;
        private System.Windows.Forms.TreeView trvList;
        private System.Windows.Forms.GroupBox grpActionControls;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtRoleDescription;
        private System.Windows.Forms.Label label1;
    }
}