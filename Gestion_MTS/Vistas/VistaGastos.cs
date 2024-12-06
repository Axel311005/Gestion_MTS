using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Vistas
{
    public class VistaGastos
    {
        public int id_gasto {  get; set; }
        public string descripcion {  get; set; }
        public decimal monto { get; set; }
        public string sucursal { get; set; }
        public DateTime FechaGasto { get; set; }

    }
}
