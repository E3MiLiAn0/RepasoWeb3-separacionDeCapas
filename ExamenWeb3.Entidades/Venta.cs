using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenWeb3.Entidades
{
    public class Venta
    {
        public int id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Cliente es requerido")]
        [StringLength(maximumLength: 5, ErrorMessage ="Como maximo son 5 caracteres")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "CantitadTotal es requerido")]
        [Range(2, 250, ErrorMessage = "Fuera de rango")]
        public int CantitadTotal { get; set; }

        [Range(10, 999, ErrorMessage = "PrecioUnitario debe ser un valor entre 1-999")]
        [Required(ErrorMessage = "PrecioUnitario es requerido")]
        public double PrecioUnitario { get; set; }

        public double Total { get; set; }

        public static List<Venta> listaVentaa = new List<Venta>()
        {
            new Venta() { id =1, Cliente ="pepe", CantitadTotal=3, PrecioUnitario=15.0, Total=45.0  }
        };

        public List<Venta> GetVenta()
        {
            return listaVentaa;
        }

    }

   

    }
