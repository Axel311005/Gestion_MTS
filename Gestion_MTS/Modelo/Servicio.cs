﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_MTS.Clases
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; } // Campo opcional
        public int? IdCategoriaServicio { get; set; }
    }
}