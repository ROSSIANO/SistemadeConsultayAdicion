using ENTITY;
using LAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRSENTACION.Controllers
{
    public class RegistrarController : Controller
    {
        RegistrarServicio registrarS = new RegistrarServicio();
        public ActionResult RegistarE()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistarE(REGISTRARE c)
        {
            registrarS.SetRegistarE(c);
            return RedirectToAction("MenuP", "Menu");
        }
        public ActionResult RegistarC()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistarC(REGISTRARC c)
        {
            registrarS.SetRegistarC(c);
            return RedirectToAction("MenuP", "Menu");
        }


    }
}