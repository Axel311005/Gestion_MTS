using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.DTOs
{
    public class DetalleServicioDto
    {
        public int IdEmpleado { get; set; } 
        public int IdServicio { get; set; }

        public int Quantity { get; set;}
    }
}
