using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.DesenvolvimentoWeb.CadastroEventos.Controllers
{
    public class HomeController : Controller
    {
        public string Default()
        {
            return "ASP.NET";
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}