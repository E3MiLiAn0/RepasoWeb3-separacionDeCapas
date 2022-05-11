using System;
using System.Collections.Generic;
using ExamenWeb3.Entidades;

namespace ExamenWeb3.Servicio
{
    public interface IVentaServicio
    {
      public  String saludar(Venta nombre);
      public void RegistrarVenta(Venta venta);
      public List<Venta> ListaVenta();
        

    }
}
