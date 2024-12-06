using Gestion_MTS.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.IRepository.Repository
{
    public class ProveedorRepository : IRepository<Proveedor>
    {
        private readonly string _connectionString;

        public ProveedorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Proveedor proveedor)
        {
            string query = "EXEC InsertarProveedor @nombre, @telefono, @direccion";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                command.Parameters.AddWithValue("@telefono", proveedor.Telefono);
                command.Parameters.AddWithValue("@direccion", (object)proveedor.Direccion ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Proveedor insertado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar el proveedor: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from proveedores where id_proveedor = @id_proveedor";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_proveedor", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró el ID especificado.");
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error " + e.Message);
                }
            }
        }

        public DataTable GetAll()
        {
            DataTable tabla = new DataTable();

            string query = "Select id_proveedor, nombre, telefono, direccion from proveedores";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(tabla);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return tabla;
        }

        public void Update(Proveedor proveedor, int id)
        {
            string query = "EXEC ActualizarProveedor @id_proveedor, @nombre, @telefono, @direccion";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@id_proveedor", proveedor.IdProveedor);
                command.Parameters.AddWithValue("@nombre", (object)proveedor.Nombre ?? DBNull.Value);
                command.Parameters.AddWithValue("@telefono", (object)proveedor.Telefono ?? DBNull.Value);
                command.Parameters.AddWithValue("@direccion", (object)proveedor.Direccion ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Proveedor actualizado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar el proveedor: " + e.Message);
                }
            }
        }

        public int? GetIdProveedor(string nombreProveedor)
        {
            string query = "SELECT TOP 1 id_proveedor FROM proveedores WHERE nombre = @nombre";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombreProveedor);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int idProveedor))
                    {
                        return idProveedor;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al obtener el ID del proveedor: " + e.Message);
                }
            }
        }

        public List<string> GetNombresProveedores()
        {
            List<string> nombresProveedores = new List<string>();
            string query = "SELECT nombre FROM proveedores";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombresProveedores.Add(reader["nombre"].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al obtener los nombres de los proveedores: " + e.Message);
                }
            }

            return nombresProveedores;
        }


    }
}
