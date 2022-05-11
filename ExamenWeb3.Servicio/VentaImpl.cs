using ExamenWeb3.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenWeb3.Servicio
{
    public class VentaImpl : IVentaServicio
    {

        static Venta venta = new Venta();
        List<Venta> listaVenta = venta.GetVenta();
        public List<Venta> ListaVenta()
            
        {
            return listaVenta;
        }

        public void RegistrarVenta(Venta venta)
        {
            if(venta != null)
            {
                int id = listaVenta.Count + 1;

                venta.id = id;
                venta.Total = (venta.PrecioUnitario * venta.CantitadTotal) * 1.21;

                listaVenta.Add(venta);
            }

        }

        public string saludar(Venta nombre)

        {
            nombre.Name = "emiliano";
             String nn = nombre.Name;
            
            return nn;
        }
    }
}
