using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico

        [Authorize]
        public ActionResult PerdasMes()
        {
            return View();
        }

        [Authorize]
        public ActionResult EntradasSaidaMes()
        {
            return View();
        }
    }
}