using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Vistas
{
    public class ComprasView
    {
        public int id_compra {  get; set; }
        public int NumeroFactura { get; set; }
        public DateTime fecha { get; set; }
        public int id_detalle_compra { get; set; }
        public string TipoPago { get; set; }
        public string proveedor { get; set; }
        public string producto { get; set; }
        public int cantidad { get; set; }
        public decimal monto { get; set; }
    }
}
