using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FinancialPlanner.Common.Permission;
using FinancialPlanner.Common.DataConversion;

namespace FinancialPlannerServer.Security
{
    public partial class Permission : DevExpress.XtraEditors.XtraForm
    {
        //DataTable dtForms;
        //DataTable dtRole;
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
            
            for(int rowIndex = 0; rowIndex < gridViewPermission.RowCount; rowIndex++)
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
                        (bool) gridViewPermission.GetRowCellValue(rowIndex, "Add");
                    isUpdate = gridViewPermission.GetRowCellValue(rowIndex, "Update") == DBNull.Value ? false :
                        (bool) gridViewPermission.GetRowCellValue(rowIndex, "Update");
                    isDelete = gridViewPermission.GetRowCellValue(rowIndex, "Delete") == DBNull.Value ? false :
                        (bool) gridViewPermission.GetRowCellValue(rowIndex, "Delete");
                    rolePermission.IsAdd = isAdd;
                    rolePermission.IsUpdate = isUpdate;
                    rolePermission.IsDelete = isDelete;
                    rolePermissions.Add(rolePermission);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void gridViewRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridViewRole_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridViewRole.FocusedRowHandle >= 0)
            {
                txtRoleName.Text = gridViewRole.GetFocusedRowCellValue("Name").ToString();
                int roleId = (int)gridViewRole.GetFocusedRowCellValue("Id");
                Role role = roles.FirstOrDefault(i => i.Id == roleId);
                DataTable permissionsTable = (DataTable) gridPermission.DataSource;
                foreach(RolePermission rolePermission in role.Permissions)
                {
                    DataRow[] drPermission = permissionsTable.Select("Id = '" + rolePermission.FormId + "'");
                    drPermission[0]["View"] = rolePermission.IsView;
                    drPermission[0]["Add"] = rolePermission.IsAdd;
                    drPermission[0]["Update"] = rolePermission.IsUpdate;
                    drPermission[0]["Delete"] = rolePermission.IsDelete;
                }
               
            }
        }
    }
}