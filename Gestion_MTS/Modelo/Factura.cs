using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int IdEmpleado { get; set; }
        public int IdTipoPago { get; set; }
        public int IdCliente { get; set; }
    }
}
