using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int NumeroCompra { get; set; }
        public DateTime Fecha { get; set; } 
        public int IdTipoPago { get; set; }
    }
}
