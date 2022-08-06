using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ENTITY;
using LAYER;

namespace PRSENTACION.Controllers
{
    public class MenuController : Controller
    {
        EmpleadoServico es = new EmpleadoServico();
        ClienteServicio cs = new ClienteServicio();
        RepositorioServicio rs = new RepositorioServicio();
        public ActionResult MenuP()
        {
            return View();
        }

        public ActionResult ELogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ELogin(Validar validar)
        {
            var model = es.ValidarE(validar);
            if (model.Count == 1)
            {
                var modell = es.ValidarE2(validar);
                if (modell.Count == 1)
                {
                    return RedirectToAction("Menu2");
                }
                else
                {
                    return RedirectToAction("Probar");
                }
                    
            }
            else
            {
                return RedirectToAction("Probar");
            }


            
        }

        public ActionResult CLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CLogin(Validar validar)
        {
            var model = cs.ValidarC(validar);
            if (model.Count == 1)
            {
                var modell = cs.ValidarC2(validar);
                if (modell.Count == 1)
                {

                    rs.BuscarCliente(validar);

                    return RedirectToAction("MenuTransaccion", "Transacciones");
                }
                else
                {
                    return RedirectToAction("Probar");
                }

            }
            else
            {
                return RedirectToAction("Pobrar");
            }

        }
        public ActionResult Probar()
        {
            return View();
        }
        public ActionResult Menu2()
        {
            return View();
        }
        public ActionResult Menu3()
        {
            return View();
        }
    }
}