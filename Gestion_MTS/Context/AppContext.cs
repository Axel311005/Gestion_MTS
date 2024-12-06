using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Context
{
    public class AppContext
    {
        public static ContextData? data { get; set; }

        public AppContext(ContextData contextData)
        {
            if (data != null)
            {
                return;
            }

            data = contextData;
        }

        public static void LogOut() {
            data = null;
        }

        public static ContextData GetContext()
        {
            return data;
        }
    }

}
