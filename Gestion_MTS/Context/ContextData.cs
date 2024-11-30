using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Context
{
    public class ContextData
    {
        public ContextData(int userId, int roleId)
        {
            this.userId = userId;
            this.roleId = roleId;
        }

        public int userId { get; set; }
        public int roleId { get; set; }
    }
}
