using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Vistas
{
    public class FacturaProductInfo
    {
        public string nombre {  get; set; }

        public decimal precioUnitario { get; set; }

        public int cantidad {  get; set; }

        public decimal monto { get; set; }
    }
}
