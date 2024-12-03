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
    public class FacturaRepository : IRepository<Factura>
    {

        private readonly string _connectionString;

        public FacturaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Factura factura)
        {
            string query = "EXEC InsertarFactura @numero_factura, @fecha, @id_empleado, @id_tipo_pago, @id_cliente";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@numero_factura", (object)factura.NumeroFactura ?? DBNull.Value);
                command.Parameters.AddWithValue("@fecha", (object)factura.Fecha ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_empleado", factura.IdEmpleado);
                command.Parameters.AddWithValue("@id_tipo_pago", factura.IdTipoPago);
                command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Factura insertada exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar la factura: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from facturas where id_factura = @id_factura";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_factura", id);

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

            string query = "Select * from ViewFacturas";
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

        public void Update(Factura factura, int id)
        {
            string query = "EXEC ActualizarFactura @id_factura, @numero_factura, @fecha, @id_empleado, @id_tipo_pago, @id_cliente";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@id_factura", factura.IdFactura);
                command.Parameters.AddWithValue("@numero_factura", (object)factura.NumeroFactura ?? DBNull.Value);
                command.Parameters.AddWithValue("@fecha", (object)factura.Fecha ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_empleado", (object)factura.IdEmpleado ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_tipo_pago", (object)factura.IdTipoPago ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_cliente", (object)factura.IdCliente ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Factura actualizada exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar la factura: " + e.Message);
                }
            }
        }
    }
}
