using Gestion_MTS.Clases;
using Gestion_MTS.DTOs;
using Gestion_MTS.Vistas;
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

        public void Add(Factura ado)
        {
            throw new NotImplementedException();
        }

        public int AddFactura(Factura factura)
        {
            string query = @"
                DECLARE @newFacturaID INT;

                EXEC InsertarFactura 
                    @fecha, 
                    @id_empleado, 
                    @id_tipo_pago, 
                    @id_cliente, 
                    @newFacturaID OUTPUT;

                SELECT @newFacturaID;
            ";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@fecha", (object)factura.Fecha ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_empleado", factura.IdEmpleado);
                command.Parameters.AddWithValue("@id_tipo_pago", factura.IdTipoPago);
                command.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

                try
                {
                    connection.Open();
                    int facturaId =  Convert.ToInt32(command.ExecuteScalar());

                    return facturaId;
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar la factura: " + e.Message);
                }
            }
        }

        public void AddFacturaDetails(Tuple<List<DetalleProductoDto>, List<DetalleServicioDto>> details, int idFactura)
        {
            (var productsDetails, var servicesDetails) = details;

            DetalleProductoRepository detalleProductoRepository = new DetalleProductoRepository(_connectionString);
            DetalleServicioRepository detalleServicioRepository = new DetalleServicioRepository(_connectionString);
            DetalleFacturaProductoRepository detalleFacturaProductoRepository = new DetalleFacturaProductoRepository(_connectionString);
            DetalleFacturaServicioRepository detalleFacturaServicioRepository = new DetalleFacturaServicioRepository(_connectionString);

            // CREANDO DATATABLES PARA LOS DETALLES

            var productsDetailsTable = new DataTable();
            var servicesDetailsTable = new DataTable();

            // ASIGNANDO COLUMNAS A LAS TABLAS

            productsDetailsTable.Columns.Add("id_producto", typeof(int));
            productsDetailsTable.Columns.Add("cantidad", typeof(int));

            servicesDetailsTable.Columns.Add("id_empleado", typeof(int));
            servicesDetailsTable.Columns.Add("id_servicio", typeof(int));


            // LLENANDO LAS TABLAS
            foreach (var product in productsDetails) {
                productsDetailsTable.Rows.Add(product.IdProducto, product.Cantidad);
            }

            foreach (var service in servicesDetails) {
                servicesDetailsTable.Rows.Add(service.IdEmpleado, service.IdServicio);
            }

            List<int>? detailProductsIds = detalleProductoRepository.MultipleInsert(productsDetailsTable);

            List<int>? detailServicesIds = detalleServicioRepository.MultipleInsert(servicesDetailsTable);

            if(detailProductsIds == null || detailServicesIds == null)
            {
                MessageBox.Show("No se pudo agregar los detalles a la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var facturaProductsDetailsTable = new DataTable();
            var facturaServicesDetailsTable = new DataTable();

            facturaProductsDetailsTable.Columns.Add("id_detalle_producto", typeof(int));
            facturaProductsDetailsTable.Columns.Add("id_factura", typeof(int));

            facturaServicesDetailsTable.Columns.Add("id_detalle_servicio", typeof(int));
            facturaServicesDetailsTable.Columns.Add("id_factura", typeof(int));
            facturaServicesDetailsTable.Columns.Add("monto", typeof(decimal));

            foreach (var (product, idx) in productsDetails.Select((product, idx) => (product, idx)))
            {
                facturaProductsDetailsTable.Rows.Add(
                    detailProductsIds[idx],
                    idFactura
                );
            }

            foreach (var (service, idx) in servicesDetails.Select((service, idx) => (service, idx)))
            {
                facturaServicesDetailsTable.Rows.Add(
                    detailServicesIds[idx],
                    idFactura,
                    service.Amount
                );
            }

            detalleFacturaProductoRepository.MultipleInsert(facturaProductsDetailsTable);
            detalleFacturaServicioRepository.MultipleInsert(facturaServicesDetailsTable);
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

        public FacturaInfo? GetFacturaInfo(int idFactura)
        {
            string query = "SELECT * FROM getFacturaInfo(@id_factura)";
            FacturaInfo factura;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@id_factura", idFactura);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader()) { 
                        
                        if(reader.Read())
                        {
                            factura = new FacturaInfo
                            {
                                numeroFactura = reader.GetInt32(0),
                                fecha = reader.GetDateTime(1),
                                empleado = reader.GetString(2),
                                tipoPago = reader.GetString(3),
                                cliente = reader.GetString(4)
                            };

                            return factura;
                        }
                        return null;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public List<FacturaProductInfo> GetFacturaProducts(int idFactura)
        {
            string query = "SELECT * FROM getFacturaProducts(@id_factura)";
            List<FacturaProductInfo> facturaProducts = new List<FacturaProductInfo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@id_factura", idFactura);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while(reader.Read())
                        {
                            FacturaProductInfo factura = new FacturaProductInfo
                            {
                                nombre = reader.GetString(0),
                                precioUnitario = reader.GetDecimal(1),
                                cantidad = reader.GetInt32(2),
                                monto = reader.GetDecimal(3)
                            };

                            facturaProducts.Add(factura);
                        }
                        return facturaProducts;
                    }
                }
                catch (Exception e)
                {
                    return facturaProducts;
                }
            }
        }

        public List<FacturaServicesInfo> GetFacturaServices(int idFactura)
        {
            string query = "SELECT * FROM getFacturaServices(@id_factura)";
            List<FacturaServicesInfo> facturaServices = new List<FacturaServicesInfo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Agregar parámetros
                command.Parameters.AddWithValue("@id_factura", idFactura);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            FacturaServicesInfo factura = new FacturaServicesInfo
                            {
                                nombre = reader.GetString(0),
                                monto = reader.GetDecimal(1)
                            };

                            facturaServices.Add(factura);
                        }
                        return facturaServices;
                    }
                }
                catch (Exception e)
                {
                    return facturaServices;
                }
            }
        }
    }
}
