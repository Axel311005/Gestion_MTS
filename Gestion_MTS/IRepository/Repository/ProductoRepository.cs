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
    public class ProductoRepository : IRepository<Producto>
    {
        private readonly string _connectionString;

        public ProductoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Producto producto)
        {
            string query = "EXEC InsertarProducto @codigo, @estado, @descripcion, @nombre, @precio_unitario, @stock, @stock_minimo, @id_categoriaProducto, @id_localizacionBodega";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                
                command.Parameters.AddWithValue("@codigo", producto.Codigo);
                command.Parameters.AddWithValue("@estado", producto.Estado);
                command.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("@nombre", producto.Nombre);
                command.Parameters.AddWithValue("@precio_unitario", producto.PrecioUnitario);
                command.Parameters.AddWithValue("@stock", producto.Stock);
                command.Parameters.AddWithValue("@stock_minimo", (object)producto.StockMinimo ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_categoriaProducto", producto.IdCategoriaProducto);
                command.Parameters.AddWithValue("@id_localizacionBodega", producto.IdLocalizacionBodega);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Producto insertado exitosamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar el producto: " + e.Message);
                }
            }
        }

        public void Delete(int id)
        {
            string query = "Delete from productos where id_producto = @id_producto";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_producto", id);

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

            string query = "Select * from VistaProductos";
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

        public void Update(Producto producto, int id)
        {
            string query = "EXEC spActualizarProducto @id_producto, @codigo, @estado, @descripcion, @nombre, @precio_unitario, @stock, @stock_minimo, @id_categoriaProducto, @id_localizacionBodega";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                
                command.Parameters.AddWithValue("@id_producto", producto.IdProducto);
                command.Parameters.AddWithValue("@codigo", (object)producto.Codigo ?? DBNull.Value);
                command.Parameters.AddWithValue("@estado", (object)producto.Estado ?? DBNull.Value);
                command.Parameters.AddWithValue("@descripcion", (object)producto.Descripcion ?? DBNull.Value);
                command.Parameters.AddWithValue("@nombre", (object)producto.Nombre ?? DBNull.Value);
                command.Parameters.AddWithValue("@precio_unitario", (object)producto.PrecioUnitario ?? DBNull.Value);
                command.Parameters.AddWithValue("@stock", (object)producto.Stock ?? DBNull.Value);
                command.Parameters.AddWithValue("@stock_minimo", (object)producto.StockMinimo ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_categoriaProducto", (object)producto.IdCategoriaProducto ?? DBNull.Value);
                command.Parameters.AddWithValue("@id_localizacionBodega", (object)producto.IdLocalizacionBodega ?? DBNull.Value);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Producto actualizado correctamente.");
                }
                catch (Exception e)
                {
                    throw new Exception("Error al actualizar el producto: " + e.Message);
                }
            }
        }

        public int ObtenerIdProductoPorNombre(string nombreProducto)
        {
            int idProducto = -1; // Valor predeterminado si no se encuentra el producto
            
            string query = "SELECT id_producto FROM productos WHERE nombre = @nombre";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombreProducto);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar(); // Obtiene un solo valor (el ID)

                    if (result != null && result != DBNull.Value)
                    {
                        idProducto = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el ID del producto: " + ex.Message);
                }
            }

            return idProducto;
        }

    }
}
