using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Gestion_MTS.Vistas;

namespace Gestion_MTS
{
    public class MTS_TerryDB
    {
        private string connectionString = "Server=DESKTOP-G25OVJH\\SQLEXPRESS;Database=MTS_Terry;Integrated Security=True;";


        public List<VistaEmpleados> GetEmpleados()
        {
            List<VistaEmpleados> empleados = new List<VistaEmpleados>();

            string query = "SELECT * FROM VistaEmpleados";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        VistaEmpleados emp = new VistaEmpleados();
                        
                        emp.nombre = reader.GetString(0);
                        emp.apellido = reader.GetString(1);
                        emp.fecha_nacimiento = DateOnly.FromDateTime(reader.GetDateTime(2));
                        emp.cedula = reader.GetString(3);
                        emp.celular = reader.GetString(4);
                        emp.direccion = reader.GetString(5);
                        emp.rol = reader.GetString(6);
                        emp.sucursal = reader.GetString(7);

                        empleados.Add(emp);

                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Error" + e.Message);
                }
            }
            return empleados;
        }
        

        

    }
}
