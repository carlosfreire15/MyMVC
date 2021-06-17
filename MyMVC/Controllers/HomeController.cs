using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyMVC.Models;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var usuario = new Usuario();
            return View(usuario);
        }
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}