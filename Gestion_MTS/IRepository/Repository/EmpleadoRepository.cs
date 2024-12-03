using Gestion_MTS.Clases;
using Gestion_MTS.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_MTS.IRepository.Repository
{
    public class EmpleadoRepository: IRepository<Empleado>
    {

        private readonly string _connectionString;

        public EmpleadoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Empleado ado)
        {
            string query = "INSERT INTO empleados (nombre, apellido, salario, fecha_nacimiento, cedula, celular, direccion, id_rol, id_sucursal) VALUES(@nombre, @apellido, @salario, @nacimiento, @cedula, @celular, @direccion, @id_rol, @id_sucursal)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.nombre);
                command.Parameters.AddWithValue("@apellido",ado.apellido );
                command.Parameters.AddWithValue("@salario", ado.salario);
                command.Parameters.AddWithValue("@nacimiento",ado.fecha_nacimiento );
                command.Parameters.AddWithValue("@cedula", ado.cedula);
                command.Parameters.AddWithValue("@celular",ado.celular );
                command.Parameters.AddWithValue("@direccion", ado.direccion);
                command.Parameters.AddWithValue("@id_rol", ado.id_rol);
                command.Parameters.AddWithValue("@id_sucursal",ado.id_sucursal );
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM empleados WHERE id_empleado = @id_empleado";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Asignación de parámetros
                command.Parameters.AddWithValue("@id_empleado", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se encontró ID especificado.");
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
            DataTable empleados = new DataTable();

            string query = "SELECT * FROM VistaEmpleados";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(empleados);
                }
                catch (Exception e)
                {

                    throw new Exception("Error:" + e.Message);
                }
            }
            return empleados;
        }


        public DataTable GetEmployeesSimplified()
        {
            DataTable empleados = new DataTable();

            string query = "SELECT * FROM EmployeesSimplified";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(empleados);
                }
                catch (Exception e)
                {

                    throw new Exception("Error:" + e.Message);
                }
            }
            return empleados;
        }

        public DataTable GetMechanicEmployees()
        {
            DataTable mecanicos = new DataTable();

            string query = "SELECT * FROM MechanicEmployees";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                try
                {
                    connection.Open();
                    adapter.Fill(mecanicos);
                }
                catch (Exception e)
                {

                    throw new Exception("Error:" + e.Message);
                }
            }
            return mecanicos;
        }

        public List<VistaVentasEmpleados> GetEmployeeSells()
        {
            List<VistaVentasEmpleados> employeeSells = new List<VistaVentasEmpleados>();

            string query = "SELECT * FROM VentasEmpleado";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    
                    SqlDataReader reader =  command.ExecuteReader();

                    while(reader.Read())
                    {
                        employeeSells.Add(
                            new VistaVentasEmpleados
                            {
                                id_empleado = reader.GetInt32(0),
                                nombre = reader.GetString(1),
                                apellido = reader.GetString(2),
                                TotalVentas = reader.GetDecimal(3),
                                AñoVenta = reader.GetInt32(4),
                                MesVenta = reader.GetInt32(5)
                            }
                        );
                    }

                    return employeeSells;
                }
                catch (Exception e)
                {
                    throw new Exception("Error:" + e.Message);
                }
            }
        }

        public void Update(Empleado ado, int id)
        {
            string query = "Update empleados SET nombre = @nombre , apellido = @apellido,salario = @salario,fecha_nacimiento=@nacimiento,cedula=@cedula,celular =@celular, direccion=@direccion," +
                "id_rol = @id_rol, id_sucursal = @id_sucursal WHERE id_empleado = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@nombre", ado.nombre);
                command.Parameters.AddWithValue("@apellido", ado.apellido);
                command.Parameters.AddWithValue("@salario", ado.salario);
                command.Parameters.AddWithValue("@nacimiento", ado.fecha_nacimiento);
                command.Parameters.AddWithValue("@cedula", ado.cedula);
                command.Parameters.AddWithValue("@celular", ado.celular);
                command.Parameters.AddWithValue("@direccion", ado.direccion);
                command.Parameters.AddWithValue("@id_rol", ado.id_rol);
                command.Parameters.AddWithValue("@id_sucursal", ado.id_sucursal);
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
