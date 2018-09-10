using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlannerServer.Security
{
    internal class RolesSecurityInfo
    {
        DataTable _dtRolesSecurity;
        public DataTable getRolesAllRoles()
        {

            return _dtRolesSecurity;
        }
    }
}
