using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.DTOs
{
    public class DetalleProductoDto
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        public string NombreProducto { get; set; }
    }
}
