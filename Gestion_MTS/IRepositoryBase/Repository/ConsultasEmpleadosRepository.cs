using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.ConsultasAdo.Net
{
    public class ConsultasEmpleadosRepository
    {

        private readonly string _connectionString;

        public ConsultasEmpleadosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetEmpleados()
        {
            DataTable empleados = new DataTable();

            string query = "SELECT * FROM VistaEmpleados";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(empleados);
                }
                catch (Exception e)
                {

                    throw new Exception("Error:" + e.Message);
                }
            }
            return empleados;
        }

        public List<string> GetRoles()
        {
            List<string> lista = new List<string>();
            DataTable roles = new DataTable();
            string query = "SELECT nombre FROM roles";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(roles);

                    foreach (DataRow row in roles.Rows)
                    {
                        lista.Add(row["nombre"].ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return lista;
        }

        public int? GetIdRol(string rol)
        {

            string query = "Select TOP 1 id_rol from roles where nombre = @roles";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@roles", rol);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    // Si el resultado no es nulo, convierte el valor a int y devuélvelo
                    if (result != null && int.TryParse(result.ToString(), out int idSucursal))
                    {
                        return idSucursal;
                    }
                    else
                    {
                        return null; // Si no hay resultados, devuelve null
                    }



                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }

            }
                

        }

        public void AddEmpleado(string nombre, string apellido, decimal salario, DateTime nacimiento, string cedula,
        string celular, string direccion, int id_rol, int id_sucursal)
        {
            string query = "INSERT INTO empleados (nombre, apellido, salario, fecha_nacimiento, cedula, celular, direccion, id_rol, id_sucursal) VALUES(@nombre, @apellido, @salario, @nacimiento, @cedula, @celular, @direccion, @id_rol, @id_sucursal)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@salario", salario);
                command.Parameters.AddWithValue("@nacimiento", nacimiento);
                command.Parameters.AddWithValue("@cedula", cedula);
                command.Parameters.AddWithValue("@celular", celular);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@id_rol", id_rol);
                command.Parameters.AddWithValue("@id_sucursal", id_sucursal);


                connection.Open();
                command.ExecuteNonQuery();

                try
                {
                   
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
        }

    }
}
