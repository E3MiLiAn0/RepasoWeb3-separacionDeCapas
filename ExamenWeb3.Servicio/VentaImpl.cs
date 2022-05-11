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
        public string saludar(Venta nombre)

        {
            nombre.Name = "emiliano";
             String nn = nombre.Name;
            
            return nn;
        }
    }
}
