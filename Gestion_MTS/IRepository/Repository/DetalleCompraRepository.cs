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
    public class DetalleCompraRepository : IRepository<DetalleCompra>
    {
        private readonly string _connectionString;

        public DetalleCompraRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(DetalleCompra detalleCompra)
        {
            string query = "EXEC InsertarDetalleCompra @id_compra, @id_proveedor, @id_producto, @cantidad, @monto";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_compra", detalleCompra.IdCompra);
                command.Parameters.AddWithValue("@id_proveedor", detalleCompra.IdProveedor);
                command.Parameters.AddWithValue("@id_producto", detalleCompra.IdProducto);
                command.Parameters.AddWithValue("@cantidad", detalleCompra.Cantidad);
                command.Parameters.AddWithValue("@monto", detalleCompra.Monto);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Detalle de compra insertado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar el detalle de compra: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from detalle_compras where id_detalle_compra = @id_detalle_compra";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_detalle_compra", id);

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

            string query = "Select * from detalle_compras";
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

        public void Update(DetalleCompra detalleCompra, int id)
        {
            string query = "EXEC ActualizarDetalleCompra @id_detalle_compra, @id_compra, @id_proveedor, @id_producto, @cantidad, @monto";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_detalle_compra", detalleCompra.IdDetalleCompra);
                command.Parameters.AddWithValue("@id_compra", (object)detalleCompra.IdCompra ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_proveedor", (object)detalleCompra.IdProveedor ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_producto", (object)detalleCompra.IdProducto ?? DBNull.Value);
                command.Parameters.AddWithValue("@cantidad", (object)detalleCompra.Cantidad ?? DBNull.Value);
                command.Parameters.AddWithValue("@monto", (object)detalleCompra.Monto ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Detalle de compra actualizado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar el detalle de compra: " + e.Message);
                }
            }
        }
    }
}
