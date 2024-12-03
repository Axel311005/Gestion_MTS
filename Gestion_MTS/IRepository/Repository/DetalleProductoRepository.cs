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
    public class DetalleProductoRepository : IRepository<DetalleProducto>
    {
        private readonly string _connectionString;

        public DetalleProductoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(DetalleProducto detalleProducto)
        {
            string query = "EXEC InsertarDetalleProducto @id_producto, @cantidad";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@id_producto", detalleProducto.IdProducto);
                command.Parameters.AddWithValue("@cantidad", detalleProducto.Cantidad);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Detalle de producto insertado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar el detalle de producto: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from detalle_producto where id_detalle_producto = @id_detalle_producto";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_detalle_producto", id);

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
            DataTable productos = new DataTable();

            string query = "Select * from detalle_producto";
            using (SqlConnection connection = new SqlConnection(_connectionString))
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
                    throw new Exception("Error: " + e.Message);
                }
            }
            return productos;
        }

        public void Update(DetalleProducto detalleProducto, int id)
        {
            string query = "EXEC ActualizarDetalleProducto @id_detalle_producto, @id_producto, @cantidad";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@id_detalle_producto", detalleProducto.IdDetalleProducto);
                command.Parameters.AddWithValue("@id_producto", (object)detalleProducto.IdProducto ?? DBNull.Value);
                command.Parameters.AddWithValue("@cantidad", (object)detalleProducto.Cantidad ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Detalle de producto actualizado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar el detalle de producto: " + e.Message);
                }
            }
        }
    }
}
