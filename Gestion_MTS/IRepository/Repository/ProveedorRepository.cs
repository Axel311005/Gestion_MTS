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

            string query = "Select nombre, telefono, direccion from proveedores";
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
    }
}
