using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_MTS.Vistas
{
    public class VistaEmpleados
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateOnly fecha_nacimiento { get; set; }
        public string cedula { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public string rol { get; set; }
        public string sucursal { get; set; }
    }
}
