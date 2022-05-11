using Microsoft.AspNetCore.Mvc;
using ExamenWeb3.Entidades;
using ExamenWeb3.Servicio;
using ExamenWeb3.Models;
using System.Collections.Generic;
namespace ExamenWeb3.Controllers
{
    public class VentaController : Controller
    {
        IVentaServicio _ventaServicio;

        public VentaController(IVentaServicio ventaServicio)
        {
            _ventaServicio = ventaServicio;
        }

      

        public IActionResult ListaVenta()
        {
            
            List<Venta> listcaDeVEntas = _ventaServicio.ListaVenta();
            return View(listcaDeVEntas);
        }
        public ActionResult RegistrarVenta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarVenta(Venta ventaCreada)
        {

            if (ModelState.IsValid)
            {
                _ventaServicio.RegistrarVenta(ventaCreada);
                return RedirectToAction("ListaVenta");
            }

            return RedirectToAction("Privacy","Home");

        }
    }
}
