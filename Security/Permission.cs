using FinancialPlanner.Common.DataConversion;
using FinancialPlanner.Common.Permission;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinancialPlannerServer.Security
{
    public partial class Permission : DevExpress.XtraEditors.XtraForm
    {
        IList<Role> roles;
        public Permission()
        {
            InitializeComponent();
        }

        private void Permission_Load(object sender, EventArgs e)
        {
            loadRole();
            loadFormsData();

        }

        private void loadRole()
        {
            roles = new RolesPermissionnfo().GetAll();
            gridControlRole.DataSource = roles;
        }

        private void loadFormsData()
        {
            IList<Forms> forms = new FormsInfo().GetAll();
            DataTable dtForms = ListtoDataTable.ToDataTable(forms.ToList());
            dtForms.Columns.Add("View", Type.GetType("System.Boolean"));
            dtForms.Columns.Add("Add", Type.GetType("System.Boolean"));
            dtForms.Columns.Add("Update", Type.GetType("System.Boolean"));
            dtForms.Columns.Add("Delete", Type.GetType("System.Boolean"));
            dtForms.Rows[0]["View"] = true;
            gridPermission.DataSource = dtForms;
        }

        private void gridViewPermission_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if ((e.Column.Caption.Equals("Add") || e.Column.Caption.Equals("Update") ||
                e.Column.Caption.Equals("Delete")) && e.Value != null &&
                e.Value.ToString().Equals("True"))
                gridViewPermission.SetRowCellValue(e.RowHandle, "View", true);

            if (e.Column.Caption.Equals("View") && e.Value != null &&
                e.Value.ToString().Equals("False"))
            {
                gridViewPermission.SetRowCellValue(e.RowHandle, "Add", false);
                gridViewPermission.SetRowCellValue(e.RowHandle, "Update", false);
                gridViewPermission.SetRowCellValue(e.RowHandle, "Delete", false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoleName.Text))
            {
                MessageBox.Show("Please enter role name.", "Requie Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<RolePermission> rolePermissions = new List<RolePermission>();
            Role role = new Role();
            role.Name = txtRoleName.Text;
            role.CreatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            role.CreatedBy = Program.CurrentUser.Id;
            role.UpdatedOn = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            role.UpdatedBy = Program.CurrentUser.Id;
            role.UpdatedByUserName = Program.CurrentUser.UserName;
            role.MachineName = Environment.MachineName;
            getRolePermission(rolePermissions);
            role.Permissions = rolePermissions;
            role.Id = int.Parse(txtRoleName.Tag.ToString());
            RolesPermissionnfo rolesPermissionnfo = new RolesPermissionnfo();
            if (txtRoleName.Tag.ToString() == "0")
            {
                if (rolesPermissionnfo.Add(role) > 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Record Save Successfully");
                    loadRole();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unable to save record.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (rolesPermissionnfo.Update(role))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Record Save Successfully");
                    loadRole();
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unable to save record.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void getRolePermission(List<RolePermission> rolePermissions)
        {
            for (int rowIndex = 0; rowIndex < gridViewPermission.RowCount; rowIndex++)
            {
                bool isView, isAdd, isUpdate, isDelete = false;

                isView = gridViewPermission.GetRowCellValue(rowIndex, "View") == DBNull.Value ? false :
                        (bool)gridViewPermission.GetRowCellValue(rowIndex, "View");
                if (isView)
                {
                    RolePermission rolePermission = new RolePermission();
                    rolePermission.FormId = int.Parse(gridViewPermission.GetRowCellValue(rowIndex, "Id").ToString());
                    rolePermission.IsView = isView;

                    isAdd = gridViewPermission.GetRowCellValue(rowIndex, "Add") == DBNull.Value ? false :
                        (bool)gridViewPermission.GetRowCellValue(rowIndex, "Add");
                    isUpdate = gridViewPermission.GetRowCellValue(rowIndex, "Update") == DBNull.Value ? false :
                        (bool)gridViewPermission.GetRowCellValue(rowIndex, "Update");
                    isDelete = gridViewPermission.GetRowCellValue(rowIndex, "Delete") == DBNull.Value ? false :
                        (bool)gridViewPermission.GetRowCellValue(rowIndex, "Delete");
                    rolePermission.IsAdd = isAdd;
                    rolePermission.IsUpdate = isUpdate;
                    rolePermission.IsDelete = isDelete;
                    rolePermissions.Add(rolePermission);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void gridViewRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //displayPermission();
        }

        private void gridViewRole_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            displayPermission();
        }

        private void displayPermission()
        {
            if (gridViewRole.FocusedRowHandle >= 0)
            {
                txtRoleName.Text = gridViewRole.GetFocusedRowCellValue("Name").ToString();
                txtRoleName.Tag = gridViewRole.GetFocusedRowCellValue("Id").ToString();
                DataTable permissionsTable = (DataTable)gridPermission.DataSource;
                //setModeofPermissionGridBasedOnCustomRoleType((bool)gridViewRole.GetFocusedRowCellValue("IsCustomRole"));
                setModeofPermissionGridBasedOnCustomRoleType(false);
                if (txtRoleName.Text.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    setPermissionForAdminUser(permissionsTable);
                }
                else
                {
                    loadFormsData();
                    permissionsTable = (DataTable)gridPermission.DataSource;
                    setPrmissionForNonAdminRole(permissionsTable);
                }
            }
        }

        private void setModeofPermissionGridBasedOnCustomRoleType(bool isCustomRole)
        {
            if (isCustomRole)
            {
                gridViewPermission.OptionsBehavior.ReadOnly = false;
                txtRoleName.ReadOnly = false;
            }
            else
            {
                txtRoleName.ReadOnly = true;
                gridViewPermission.OptionsBehavior.ReadOnly = true;
            }
        }

        private void setPrmissionForNonAdminRole(DataTable permissionsTable)
        {
            int roleId = (int)gridViewRole.GetFocusedRowCellValue("Id");
            Role role = roles.FirstOrDefault(i => i.Id == roleId);
            foreach (RolePermission rolePermission in role.Permissions)
            {
                DataRow[] drPermission = permissionsTable.Select("Id = '" + rolePermission.FormId + "'");
                drPermission[0]["View"] = rolePermission.IsView;
                drPermission[0]["Add"] = rolePermission.IsAdd;
                drPermission[0]["Update"] = rolePermission.IsUpdate;
                drPermission[0]["Delete"] = rolePermission.IsDelete;
            }
        }

        private void setPermissionForAdminUser(DataTable permissionsTable)
        {
            foreach (DataRow dr in permissionsTable.Rows)
            {
                dr["View"] = true;
                dr["Add"] = true;
                dr["Update"] = true;
                dr["Delete"] = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRoleName.Text = "";
            txtRoleName.Tag = "0";
            loadFormsData();
            setModeofPermissionGridBasedOnCustomRoleType(true);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ((bool)gridViewRole.GetFocusedRowCellValue("IsCustomRole"))
            {
                setModeofPermissionGridBasedOnCustomRoleType(true);
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
            else
            {
                MessageBox.Show("You can not change system role.", "System Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setModeofPermissionGridBasedOnCustomRoleType(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((bool)gridViewRole.GetFocusedRowCellValue("IsCustomRole"))
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int roleId = (int)gridViewRole.GetFocusedRowCellValue("Id");
                    Role role = roles.FirstOrDefault(i => i.Id == roleId);
                    RolesPermissionnfo rolesPermissionnfo = new RolesPermissionnfo();
                    if (rolesPermissionnfo.Delete(role))
                        loadRole();
                }
            }
            else
            {
                MessageBox.Show("You can not delete system role.", "System Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setModeofPermissionGridBasedOnCustomRoleType(false);
            }
        }
    }
}