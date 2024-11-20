using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_MTS.Clases
{
    public class Empleado
    {
        public int id_empleado { get; set; }
		public string nombre {  get; set; }
		public string apellido {  get; set; }
		public decimal salario {  get; set; }
		public DateTime fecha_nacimiento {  get; set; }
		public string cedula { get; set; }	
		public DateTime fecha_ingreso { get; set; }
		public bool estado { get; set; }
		public string celular {  get; set; }
		public string direccion { get; set; }	
		public int id_rol {  get; set; }
		public int id_sucursal {  get; set; }
    }
}
