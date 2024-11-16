using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.ConsultasAdo.Net
{
    public class ConsultasProductos
    {
        public DataTable GetProductos()
        {
            DataTable productos = new DataTable();
            string query = "SELECT * FROM VistaProductos";

            using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(productos);
                }
                catch (Exception e)
                {

                    throw new Exception("Error:" + e.Message);
                }
            }
            return productos;
        }
    }
}
