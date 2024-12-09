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
    public class DetalleServicioRepository : IRepository<DetalleServicio>
    {

        private readonly string _connectionString;

        public DetalleServicioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(DetalleServicio detalleServicio)
        {
            string query = "EXEC InsertarDetalleServicio @id_empleado, @id_servicio";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_empleado", detalleServicio.IdEmpleado);
                command.Parameters.AddWithValue("@id_servicio", detalleServicio.IdServicio);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Detalle de servicio insertado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar el detalle de servicio: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from detalle_servicio where id_detalle_servicio = @id_detalle_servicio";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_detalle_servicio", id);

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

            string query = "Select * from detalle_servicio";
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

        public void Update(DetalleServicio detalleServicio, int id)
        {
            string query = "EXEC ActualizarDetalleServicio @id_detalle_servicio, @id_empleado, @id_servicio";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_detalle_servicio", detalleServicio.IdDetalleServicio);
                command.Parameters.AddWithValue("@id_empleado", (object)detalleServicio.IdEmpleado ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_servicio", (object)detalleServicio.IdServicio ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Detalle de servicio actualizado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar el detalle de servicio: " + e.Message);
                }
            }
        }

        public List<int>? MultipleInsert(DataTable serviceDetails)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {

                    connection.Open();

                    //TABLA TEMPORAL 
                    string createTmpTable = @"
                        CREATE TABLE #TempServicesDetails (
                            id_servicio INT,
                            id_empleado INT
                        );
                    ";

                    using (SqlCommand cmd = new SqlCommand(createTmpTable, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (var bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = "#TempServicesDetails";
                        bulkCopy.WriteToServer(serviceDetails);
                    }

                    string insertWithOutputSql = @"
                        INSERT INTO detalle_servicio (id_empleado, id_servicio)
                        OUTPUT INSERTED.id_detalle_servicio INTO #InsertedIds
                        SELECT id_empleado, id_servicio FROM #TempServicesDetails;
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
                        while (reader.Read())
                        {
                            insertedIds.Add(reader.GetInt32(0));
                        }
                    }

                    return insertedIds;
                }
            }
            catch (Exception e)
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
