using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string? Contraseña { get; set; } = string.Empty;
        public int IdEmpleado { get; set; }
    }
}
