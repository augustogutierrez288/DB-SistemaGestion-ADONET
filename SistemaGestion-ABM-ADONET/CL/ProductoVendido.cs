﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion_ABM_ADONET.CL
{
    public class ProductoVendido
    {
        public int Id { get; set; }
        public int Stock {  get; set; }
        public int IdProducto { get; set;}
        public int IdVenta { get; set; }
    }
}
