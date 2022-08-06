using ENTITY;
using LAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRSENTACION.Controllers
{
    public class PrestamoController : Controller
    {
        PrestamoServicio prestamoS = new PrestamoServicio();
        public ActionResult CrearP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearP(PRESTAMO p)
        {
            prestamoS.SetPrestamo(p);
            return RedirectToAction("MostrarP"); ;
        }

        public ActionResult MostrarP()
        {
            var data = prestamoS.Leer();
            return View(data);

        }
        public ActionResult ActualizarP(int id)
        {
            var model = prestamoS.Busca(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult ActualizarC(PRESTAMO p)
        {
            prestamoS.Actualizar(p);
            return RedirectToAction("MostrarP");
        }

        public ActionResult BorrarC(int id)
        {
            prestamoS.Borrar(id);
            return RedirectToAction("MostrarP");
        }
    }
}