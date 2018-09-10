using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerServer.Security
{
    public partial class RolesSecurity : Form
    {
        public RolesSecurity()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setEnableDisableControlrs(true);
            txtRoleName.Tag = "0";
            txtRoleName.Focus();
        }
        private void setEnableDisableControlrs(bool enabled)
        {
            grpRoles.Enabled = enabled;
            grpSecurity.Enabled = enabled;
            btnSaveRoles.Enabled = enabled;
            btnCancelRoles.Enabled = enabled;
        }

        private void btnCancelRoles_Click(object sender, EventArgs e)
        {
            setEnableDisableControlrs(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            setEnableDisableControlrs(true);
        }
    }
}
