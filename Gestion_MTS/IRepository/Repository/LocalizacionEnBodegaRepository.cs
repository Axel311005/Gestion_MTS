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
    public class LocalizacionEnBodegaRepository : IRepository<LocalizacionEnBodega>
    {

        private readonly string _connectionString;

        public LocalizacionEnBodegaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Add(LocalizacionEnBodega ado)
        {
            string query = "Insert into localizacionesBodega(descripcion,id_bodega) values(@descripcion , @id_bodega)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@descripcion", ado.descripcion);
                command.Parameters.AddWithValue("@id_bodega", ado.id_bodega);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    throw new Exception("Error " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from localizacionesBodega where id_localizacionBodega = @id_localizacionBodega";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_localizacionBodega", id);

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
            DataTable local = new DataTable();

            string query = "Select * from localizacionesBodegaView";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(local);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return local;
        }

        public void Update(LocalizacionEnBodega ado, int id)
        {
            string query = "Update localizacionesBodega SET descripcion = @descripcion, id_bodega = @id_bodega " +
                "WHERE id_localizacionBodega = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@descripcion", ado.descripcion);
                command.Parameters.AddWithValue("@id_bodega", ado.id_bodega);
                command.Parameters.AddWithValue("@id", id);

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

        public int? GetId(string localizacion)
        {

            string query = "Select TOP 1 id_localizacionBodega from localizacionesBodega where descripcion = @descripcion";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@descripcion", localizacion);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    // Si el resultado no es nulo, convierte el valor a int y devuélvelo
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        return id;
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

        public List<string> GetLocalizacion()
        {
            List<string> categorias = new List<string>();
            string query = "SELECT descripcion FROM localizacionesBodega";

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
                            categorias.Add(reader["descripcion"].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }

            return categorias;
        }
    }
}
