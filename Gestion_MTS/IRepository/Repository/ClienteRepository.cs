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
    public class ClienteRepository : IRepository<Cliente>
    {

        private readonly string _connectionString;

        public ClienteRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Cliente ado)
        {
            string query = "Insert into clientes(nombre, apellido , direccion) values(@nombre , @apellido,@direccion)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.Nombre);
                command.Parameters.AddWithValue("@descripcion", ado.Apellido);
                command.Parameters.AddWithValue("@direccion", ado.Direccion);


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
            string query = "Delete from clientes where id_cliente = @id_cliente";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_cliente", id);

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
            DataTable clientes = new DataTable();

            string query = "Select nombre, apellido, direccion from clientes";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(clientes);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return clientes;
        }

        public void Update(Cliente ado, int id)
        {
            string query = "Update clientes SET nombre = @nombre , apellido = @apellido , direccion = @direccion " +
                "WHERE id_cliente = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.Nombre);
                command.Parameters.AddWithValue("@apellido", ado.Apellido);
                command.Parameters.AddWithValue("@direccion", ado.Direccion);
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
    }
}
