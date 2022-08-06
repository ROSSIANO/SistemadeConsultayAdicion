using ENTITY;
using LAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRSENTACION.Controllers
{
    public class TarjetaController : Controller
    {
        TarjetaServicio tarjetaS = new TarjetaServicio();
        public ActionResult CrearT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearT(TARJETA t)
        {
            tarjetaS.SetTarjeta(t);
            return RedirectToAction("MostrarT");
        }

        public ActionResult MostrarT()
        {
            var data = tarjetaS.Leer();
            return View(data);

        }
        public ActionResult ActualizarT(int id)
        {
            var model = tarjetaS.Busca(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult ActualizarT(TARJETA t)
        {
            tarjetaS.Actualizar(t);
            return RedirectToAction("MostrarT");
        }

        public ActionResult BorrarT(int id)
        {
            tarjetaS.Borrar(id);
            return RedirectToAction("MostrarT");
        }
    }
}