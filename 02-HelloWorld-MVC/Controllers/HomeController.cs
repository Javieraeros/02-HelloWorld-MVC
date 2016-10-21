using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _02_HelloWorld_MVC.Models;

namespace _02_HelloWorld_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["nombre"] = "Agapito";
            ViewBag.autor = "Fco Javier Ruiz Rodríguez";

            Persona miPersona = new Persona("Javier", "Ruiz", new DateTimeOffset());
            return View(miPersona);
        }

        public ActionResult listado()
        {
            ListadoPersona miListado=new ListadoPersona();

            return View(miListado.ListadoDefecto());
        }
    }
}