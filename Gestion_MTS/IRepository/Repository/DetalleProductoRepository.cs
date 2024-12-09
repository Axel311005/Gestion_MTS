using Gestion_MTS.Clases;
using System;
using System.Collections;
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

        public List<int>? MultipleInsert(DataTable productsDetails)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {

                    connection.Open();

                    //TABLA TEMPORAL 
                    string createTmpTable = @"
                        CREATE TABLE #TempProductDetails (
                            id_producto INT,
                            cantidad INT
                        );
                    ";

                    using (SqlCommand cmd = new SqlCommand(createTmpTable, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (var bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = "#TempProductDetails";
                        bulkCopy.WriteToServer(productsDetails);
                    }

                    string insertWithOutputSql = @"
                        INSERT INTO detalle_producto (id_producto, cantidad)
                        OUTPUT INSERTED.id_detalle_producto INTO #InsertedIds
                        SELECT id_producto, cantidad FROM #TempProductDetails;
                    ";

                    string createInsertedIdsTmp = "CREATE TABLE #InsertedIds (id INT)";

                    using (SqlCommand cmd = new SqlCommand(createInsertedIdsTmp, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand cmd = new SqlCommand(insertWithOutputSql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    List<int> insertedIds = new List<int>();
                    string selectIdsSql = "SELECT id FROM #InsertedIds";
                    using (SqlCommand cmd = new SqlCommand(selectIdsSql, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            insertedIds.Add(reader.GetInt32(0));
                        }
                    }

                    return insertedIds;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(
                    $"Ocurrio un error : {e.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }
        }
    }
}
