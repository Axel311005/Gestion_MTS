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
    public class CategoriaProductoRepository : IRepository<CategoriaProducto>
    {
        private readonly string _connectionString;

        public CategoriaProductoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(CategoriaProducto ado)
        {
            string query = "Insert into categoriasProducto(nombre, descripcion) values(@nombre , @descripcion)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.Nombre);
                command.Parameters.AddWithValue("@descripcion", ado.Descripcion);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    throw new Exception("Error "+ e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from categoriasProducto where id_categoriaProducto = @id_categoriaProducto";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_categoriaProducto", id);

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
            DataTable categorias = new DataTable();

            string query = "Select nombre, descripcion from categoriasProducto";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(categorias);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return categorias;
        }

        public void Update(CategoriaProducto ado)
        {
            string query = "Update categoriasProducto SET nombre = @nombre , descripcion = @descripcion";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.Nombre);
                command.Parameters.AddWithValue("@descripcion", ado.Descripcion);


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

        public List<string> GetCategoria()
        {
            List<string> categorias = new List<string>();
            string query = "SELECT nombre FROM categoriasProducto";

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
                            categorias.Add(reader["nombre"].ToString());
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


        public int? GetIdCategoria(string categoria)
        {

            string query = "Select TOP 1 id_categoriaProducto from categoriasProducto where nombre = @categoria";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@categoria", categoria);

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

    }
}
