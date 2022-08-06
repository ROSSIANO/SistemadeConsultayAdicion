using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAYER;
using ENTITY;

namespace PRSENTACION.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoServico empleadoS = new EmpleadoServico();
        public ActionResult CrearE()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearE(EMPLEADO e)
        {
            empleadoS.SetEmpleado(e);
            empleadoS.GuardarFoto(e);
            return RedirectToAction("MostrarE");
        }

        public ActionResult MostrarE()
        {
            var data = empleadoS.Leer();
            return View(data);

        }
        public ActionResult ActualizarE(int id)
        {
            var model = empleadoS.Busca(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult ActualizarE(EMPLEADO e)
        {
            empleadoS.Actualizar(e);
            return RedirectToAction("MostrarE"); 
        }

        public ActionResult Borrar(int id)
        {
            empleadoS.Borrar(id);
            return RedirectToAction("MostrarE");
        }


      
        public ActionResult Buscar(int id)
        {
            id = int.Parse(Request.Form["id"]);
            var model = empleadoS.Busca(id);
            return View(model);
        }

    }
}