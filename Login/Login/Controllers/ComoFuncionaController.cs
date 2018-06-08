using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class ComoFuncionaController : Controller
    {
        // GET: ComoFunciona
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PageComoFunciona()
        {
       
            return RedirectToAction("Index", "ComoFunciona");

        }

    }
}