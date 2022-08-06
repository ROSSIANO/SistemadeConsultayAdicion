using ENTITY;
using LAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRSENTACION.Controllers
{
    public class AhorroController : Controller
    {
        AhorroServicio ahorroS = new AhorroServicio();
        public ActionResult CrearA()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearA(AHORRO a)
        {
            ahorroS.SetAhorro(a);
            return RedirectToAction("MostrarA");
        }

        public ActionResult MostrarA()
        {
            var data = ahorroS.Leer();
            return View(data);

        }
        public ActionResult ActualizarA(int id)
        {
            var model = ahorroS.Busca(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult ActualizarA(AHORRO a)
        {
            ahorroS.Actualizar(a);
            return RedirectToAction("MostrarA");
        }

        public ActionResult BorrarA(int id)
        {
            ahorroS.Borrar(id);
            return RedirectToAction("MostrarA");
        }
    }
}