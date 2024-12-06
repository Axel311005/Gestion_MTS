using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class Gasto
    {
        public int IdGasto { get; set; }
        public string descripcion {  get; set; }
        public decimal monto { get; set; }
        public int IdSucursal { get; set; }
        public DateTime? FechaGasto { get; set; }
    }
}
