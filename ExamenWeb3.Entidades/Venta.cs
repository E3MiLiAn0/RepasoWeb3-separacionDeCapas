using System;
using System.Collections.Generic;


namespace ExamenWeb3.Entidades
{
    public class Venta
    {
        public string Name { get; set; }

        public int id { get; set; }
        public string Cliente { get; set; }
        public int CantitadTotal { get; set; }
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
