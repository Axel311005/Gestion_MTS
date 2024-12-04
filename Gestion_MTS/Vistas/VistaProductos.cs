using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Vistas
{
    public class VistaProductos
    {
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string categoria { get; set; }
        public string descripcion { get; set; } 
        public decimal precio { get; set; }   
        public int stock { get; set; }
        public int StockMinimo { get; set; }
        public string sucursal { get; set; }
        public string bodega { get; set; }
        public string localizacion { get; set; }
        public bool estado { get; set; }    


    }
}
