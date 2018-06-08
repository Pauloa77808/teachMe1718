using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class InscrisaoController : Controller
    {
        // GET: Inscrisao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageInscrisao()
        {
       
            return RedirectToAction("Index", "Inscrisao");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Cliente user) {

            if (ModelState.IsValid)
            {

                using (teachmeDB db = new teachmeDB())
                {
                    db.Cliente.Add(user);
                    db.SaveChanges();
                    ModelState.Clear();
                    ViewBag.Message = user.Nome + " " + "registado com sucesso";
                    user = null;
                    
                }

            }

            return RedirectToAction("Index", "Login"); ;

        }
    }
}