using jm.entidade;
using jm.negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jm.web.Controllers
{
    public class ContasController : Controller
    {
        // GET: Contas
        public ActionResult Index()
        {
            return View("Contas");
        }

        public void Get() {
            List<Contas>lstContas = ContasBS.New().ListarContas();

        }
    }
}