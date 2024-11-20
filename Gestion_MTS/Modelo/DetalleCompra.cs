using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
    }
}
