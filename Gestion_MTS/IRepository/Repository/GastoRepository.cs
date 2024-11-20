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
    public class GastoRepository : IRepository<Gasto>
    {
        private readonly string _connectionString;

        public GastoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public void Add(Gasto ado)
        {
            string query = "Insert into gastos(descripcion, monto, id_sucursal, FechaGasto) values(@descripcion, @monto, @id_sucursal, @fecha)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@descripcion", ado.descripcion);
                command.Parameters.AddWithValue("@monto", ado.monto);
                command.Parameters.AddWithValue("@id_sucursal", ado.IdSucursal);
                command.Parameters.AddWithValue("@fecha", ado.FechaGasto);

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
            string query = "Delete from gastos where id_gasto = @id_gasto";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_gasto", id);

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
            DataTable gastos = new DataTable();

            string query = "Select * from VistaGastos";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(gastos);
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
            return gastos;
        }

        public void Update(Gasto ado)
        {
            string query = "Update gastos SET descripcion = @descripcion , monto = @monto , id_sucursal = @id_sucursal, FechaGasto= @fecha";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@descripcion", ado.descripcion);
                command.Parameters.AddWithValue("@monto", ado.monto);
                command.Parameters.AddWithValue("@id_sucursal", ado.IdSucursal);
                command.Parameters.AddWithValue("@fecha", ado.FechaGasto);

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

        public decimal CalcularMontoTotalGastosPorSucursal(DateTime fechaInicio, DateTime fechaFin, int? idSucursal)
        {
            decimal montoTotal = 0;
            string query = "SELECT dbo.CalcularMontoTotalGastosPorSucursal(@fechaInicio, @fechaFin, @idSucursal)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                command.Parameters.AddWithValue("@idSucursal", idSucursal);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        montoTotal = Convert.ToDecimal(result);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al calcular el monto total de gastos: " + e.Message);
                }
            }

            return montoTotal;
        }

        public decimal CalcularMontoTotalGastos(DateTime fechaInicio, DateTime fechaFin)
        {
            decimal montoTotal = 0;
            string query = "SELECT dbo.CalcularMontoTotalGastos(@fechaInicio, @fechaFin)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);
           
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        montoTotal = Convert.ToDecimal(result);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al calcular el monto total de gastos: " + e.Message);
                }
            }

            return montoTotal;
        }

    }
}
