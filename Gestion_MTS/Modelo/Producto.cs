using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public bool Estado { get; set; } = true;
        public string Descripcion { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public decimal? PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public int? StockMinimo { get; set; }
        public int? IdCategoriaProducto { get; set; }
        public int? IdLocalizacionBodega { get; set; }
    }
}
