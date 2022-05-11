using Microsoft.AspNetCore.Mvc;
using ExamenWeb3.Entidades;
using ExamenWeb3.Servicio;
using ExamenWeb3.Models;

namespace ExamenWeb3.Controllers
{
    public class VentaController : Controller
    {
        IVentaServicio _ventaServicio;

        public VentaController(IVentaServicio ventaServicio)
        {
            _ventaServicio = ventaServicio;
        }

        public ActionResult VentaSaludo()
        {
            Venta venta = new Venta();
            
            VentaModelView ventaModelView = new VentaModelView();
            ventaModelView.nombre = _ventaServicio.saludar(venta);

            return View(ventaModelView);
        }
    }
}
