using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class DetalleFacturaProducto
    {
        public int IdDetalleFacturaProducto { get; set; }
        public int IdDetalleProducto { get; set; }
        public int IdFactura { get; set; }
        public decimal Monto { get; set; }
    }
}
