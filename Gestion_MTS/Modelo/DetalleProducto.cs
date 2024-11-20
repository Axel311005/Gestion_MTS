using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class DetalleProducto
    {
        public int IdDetalleProducto { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
