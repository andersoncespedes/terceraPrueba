using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto;

    public class ProductoDto
    {
        public string ? NombreProducto { get; set; }
        public string ? CodeProducto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
    }
