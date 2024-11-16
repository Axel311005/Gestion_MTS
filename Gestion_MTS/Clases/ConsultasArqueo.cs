using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class ConsultasArqueo
    {
        public List<Gastos> GetGastosPorSucursalYFecha(string sucursal, DateTime fecha)
        {
            List<Gastos> listaGastos = new List<Gastos>();
            string query = "SELECT descripcion, monto FROM dbo.GetGastosxSucursalxDia(@sucursal, @fecha)";

            using (SqlConnection connection = new SqlConnection(DataBaseConnection.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);


                // Agregar parámetros a la consulta
                command.Parameters.AddWithValue("@sucursal", sucursal);
                command.Parameters.AddWithValue("@fecha", fecha);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Leer los resultados
                    while (reader.Read())
                    {
                        Gastos gasto = new Gastos
                        {
                            descripcion = reader["descripcion"].ToString(),
                            monto = Convert.ToDecimal(reader["monto"])
                        };

                        listaGastos.Add(gasto);
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }

            return listaGastos;
        }
    }
}
