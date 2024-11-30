using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Vistas
{
    public class VistaVentasEmpleados
    {
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public decimal TotalVentas { get; set; }
        public int AñoVenta { get; set; }
        public int MesVenta { get; set; }
    }
}
