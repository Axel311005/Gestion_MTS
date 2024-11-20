using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class DetalleFacturaServicio
    {
        public int IdDetalleFacturaServicio { get; set; }
        public int IdDetalleServicio { get; set; }
        public int IdFactura { get; set; }
        public decimal Monto { get; set; }
    }
}
