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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Cumpleaños { get; set; }
        public string Identificación { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public string Rol { get; set; }
        public string Sucursal { get; set; }
    }
}
