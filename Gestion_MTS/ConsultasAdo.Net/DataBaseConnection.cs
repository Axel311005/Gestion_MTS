using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Gestion_MTS.Vistas;
using System.Data;
using Gestion_MTS.Clases;

namespace Gestion_MTS
{
    public class DataBaseConnection
    {
        public static string connectionString { get; } = "Server=DESKTOP-G25OVJH\\SQLEXPRESS;Database=MTS_Terry;Integrated Security=True;";


    }
}
