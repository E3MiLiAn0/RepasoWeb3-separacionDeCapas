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
            throw new NotImplementedException();
        }

        public string saludar(Venta nombre)

        {
            nombre.Name = "emiliano";
             String nn = nombre.Name;
            
            return nn;
        }
    }
}
