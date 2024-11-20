using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class DetalleServicio
    {
        public int IdDetalleServicio { get; set; }
        public int? IdEmpleado { get; set; } // Opcional si el empleado no siempre está presente
        public int IdServicio { get; set; }
    }
}
