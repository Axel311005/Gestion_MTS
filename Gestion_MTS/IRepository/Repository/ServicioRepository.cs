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
    public class ServicioRepository : IRepository<Servicio>
    {
        private readonly string _connectionString;

        public ServicioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Servicio ado)
        {
            string query = "Insert into servicios(nombre, descripcion,id_categoriaServicio) values(@nombre , @descripcion, @id_categoriaServicio)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.Nombre);
                command.Parameters.AddWithValue("@descripcion", ado.Descripcion);
                command.Parameters.AddWithValue("@id_categoriaServicio", ado.IdCategoriaServicio);

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
            string query = "Delete from servicios where id_servicio = @id_servicio";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_servicio", id);

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
            DataTable servicios = new DataTable();

            string query = "Select * from ServiciosView";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(servicios);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return servicios;
        }

        public void Update(Servicio ado)
        {
            string query = "Update servicios SET nombre = @nombre , descripcion = @descripcion, id_categoriaServicio = @id_categoriaServicio";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.Nombre);
                command.Parameters.AddWithValue("@descripcion", ado.Descripcion);
                command.Parameters.AddWithValue("@id_categoriaServicio", ado.IdCategoriaServicio);


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
    }
}
