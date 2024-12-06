using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Vistas
{
    public class FacturaInfo
    {
        public int numeroFactura { get; set; }

        public DateTime fecha { get; set; }

        public string empleado { get; set; }   

        public string tipoPago { get; set; }   

        public string cliente { get; set; }
    }
}
