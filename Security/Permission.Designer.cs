namespace FinancialPlannerServer.Security
{
    partial class Permission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permission));
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            this.gridPermission = new DevExpress.XtraGrid.GridControl();
            this.gridViewPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnFormId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFormName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckView = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckAdd = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckDelete = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtRoleName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlRole = new DevExpress.XtraGrid.GridControl();
            this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIsCustomRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveBankAccount = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPermission
            // 
            this.gridPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPermission.Location = new System.Drawing.Point(5, 56);
            this.gridPermission.MainView = this.gridViewPermission;
            this.gridPermission.Name = "gridPermission";
            this.gridPermission.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckView,
            this.repositoryItemCheckAdd,
            this.repositoryItemCheckUpdate,
            this.repositoryItemCheckDelete});
            this.gridPermission.Size = new System.Drawing.Size(716, 360);
            this.gridPermission.TabIndex = 1;
            this.gridPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermission});
            // 
            // gridViewPermission
            // 
            this.gridViewPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnFormId,
            this.gridColumnFormName,
            this.gridColumnGroup,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewPermission.GridControl = this.gridPermission;
            this.gridViewPermission.GroupCount = 1;
            this.gridViewPermission.Name = "gridViewPermission";
            this.gridViewPermission.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.gridViewPermission.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPermission.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPermission_CellValueChanged);
            // 
            // gridColumnFormId
            // 
            this.gridColumnFormId.Caption = "Id";
            this.gridColumnFormId.FieldName = "ID";
            this.gridColumnFormId.Name = "gridColumnFormId";
            // 
            // gridColumnFormName
            // 
            this.gridColumnFormName.Caption = "Form";
            this.gridColumnFormName.FieldName = "FormName";
            this.gridColumnFormName.Name = "gridColumnFormName";
            this.gridColumnFormName.Visible = true;
            this.gridColumnFormName.VisibleIndex = 0;
            // 
            // gridColumnGroup
            // 
            this.gridColumnGroup.Caption = "Group Name";
            this.gridColumnGroup.FieldName = "GroupName";
            this.gridColumnGroup.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.gridColumnGroup.Name = "gridColumnGroup";
            this.gridColumnGroup.Visible = true;
            this.gridColumnGroup.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "View";
            this.gridColumn2.ColumnEdit = this.repositoryItemCheckView;
            this.gridColumn2.FieldName = "View";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemCheckView
            // 
            this.repositoryItemCheckView.AutoHeight = false;
            this.repositoryItemCheckView.Name = "repositoryItemCheckView";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Add";
            this.gridColumn3.ColumnEdit = this.repositoryItemCheckAdd;
            this.gridColumn3.FieldName = "Add";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemCheckAdd
            // 
            this.repositoryItemCheckAdd.AutoHeight = false;
            this.repositoryItemCheckAdd.Name = "repositoryItemCheckAdd";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Update";
            this.gridColumn4.ColumnEdit = this.repositoryItemCheckUpdate;
            this.gridColumn4.FieldName = "Update";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // repositoryItemCheckUpdate
            // 
            this.repositoryItemCheckUpdate.AutoHeight = false;
            this.repositoryItemCheckUpdate.Name = "repositoryItemCheckUpdate";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Delete";
            this.gridColumn5.ColumnEdit = this.repositoryItemCheckDelete;
            this.gridColumn5.FieldName = "Delete";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // repositoryItemCheckDelete
            // 
            this.repositoryItemCheckDelete.AutoHeight = false;
            this.repositoryItemCheckDelete.Name = "repositoryItemCheckDelete";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtRoleName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.gridPermission);
            this.groupControl1.Location = new System.Drawing.Point(298, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(727, 421);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Role && Permissions";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(59, 30);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(307, 20);
            this.txtRoleName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role :";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Controls.Add(this.btnEdit);
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Controls.Add(this.gridControlRole);
            this.groupControl2.Location = new System.Drawing.Point(2, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(290, 457);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Roles Info";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(260, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem6.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem6.Appearance.Options.UseImage = true;
            toolTipTitleItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem6.Image")));
            toolTipTitleItem6.Text = "Delete Client";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "To delete selected client record click here.";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            this.btnDelete.SuperTip = superToolTip6;
            this.btnDelete.TabIndex = 9;
            this.btnDelete.ToolTip = "Delete Client";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(229, 427);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem7.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipTitleItem7.Appearance.Options.UseImage = true;
            toolTipTitleItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem7.Image")));
            toolTipTitleItem7.Text = "Edit Customer";
            toolTipItem7.LeftIndent = 6;
            toolTipItem7.Text = "To modify selected client information click here.";
            superToolTip7.Items.Add(toolTipTitleItem7);
            superToolTip7.Items.Add(toolTipItem7);
            this.btnEdit.SuperTip = superToolTip7;
            this.btnEdit.TabIndex = 8;
            this.btnEdit.ToolTip = "Edit Client";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(198, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 23);
            toolTipTitleItem8.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            toolTipTitleItem8.Appearance.Options.UseImage = true;
            toolTipTitleItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem8.Image")));
            toolTipTitleItem8.Text = "New Client";
            toolTipItem8.LeftIndent = 6;
            toolTipItem8.Text = "To add new client inforamtion click here.";
            superToolTip8.Items.Add(toolTipTitleItem8);
            superToolTip8.Items.Add(toolTipItem8);
            this.btnAdd.SuperTip = superToolTip8;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.ToolTip = "Add new client";
            this.btnAdd.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
            this.btnAdd.ToolTipTitle = "New Client";
            // 
            // gridControlRole
            // 
            this.gridControlRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlRole.Location = new System.Drawing.Point(5, 23);
            this.gridControlRole.MainView = this.gridViewRole;
            this.gridControlRole.Name = "gridControlRole";
            this.gridControlRole.Size = new System.Drawing.Size(280, 398);
            this.gridControlRole.TabIndex = 0;
            this.gridControlRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
            // 
            // gridViewRole
            // 
            this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName,
            this.gridColumnIsCustomRole});
            this.gridViewRole.GridControl = this.gridControlRole;
            this.gridViewRole.Name = "gridViewRole";
            this.gridViewRole.OptionsFind.AlwaysVisible = true;
            this.gridViewRole.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewRole.OptionsView.ShowGroupPanel = false;
            this.gridViewRole.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewRole_RowClick);
            this.gridViewRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRole_FocusedRowChanged);
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnIsCustomRole
            // 
            this.gridColumnIsCustomRole.Caption = "IsCustomRole";
            this.gridColumnIsCustomRole.FieldName = "IsCutomRole";
            this.gridColumnIsCustomRole.Name = "gridColumnIsCustomRole";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(957, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            toolTipTitleItem9.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            toolTipTitleItem9.Appearance.Options.UseImage = true;
            toolTipTitleItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem9.Image")));
            toolTipTitleItem9.Text = "Cancel";
            toolTipItem9.LeftIndent = 6;
            toolTipItem9.Text = "To cancel changes click here.";
            superToolTip9.Items.Add(toolTipTitleItem9);
            superToolTip9.Items.Add(toolTipItem9);
            this.btnCancel.SuperTip = superToolTip9;
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveBankAccount
            // 
            this.btnSaveBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBankAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBankAccount.Image")));
            this.btnSaveBankAccount.Location = new System.Drawing.Point(894, 439);
            this.btnSaveBankAccount.Name = "btnSaveBankAccount";
            this.btnSaveBankAccount.Size = new System.Drawing.Size(57, 23);
            toolTipTitleItem10.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            toolTipTitleItem10.Appearance.Options.UseImage = true;
            toolTipTitleItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem10.Image")));
            toolTipTitleItem10.Text = "Save";
            toolTipItem10.LeftIndent = 6;
            toolTipItem10.Text = "To save role && permission click here.";
            superToolTip10.Items.Add(toolTipTitleItem10);
            superToolTip10.Items.Add(toolTipItem10);
            this.btnSaveBankAccount.SuperTip = superToolTip10;
            this.btnSaveBankAccount.TabIndex = 42;
            this.btnSaveBankAccount.Text = "Save";
            this.btnSaveBankAccount.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 473);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveBankAccount);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Permission";
            this.Text = "Permission";
            this.Load += new System.EventHandler(this.Permission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermission;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtRoleName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFormId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckDelete;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSaveBankAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsCustomRole;
    }
}