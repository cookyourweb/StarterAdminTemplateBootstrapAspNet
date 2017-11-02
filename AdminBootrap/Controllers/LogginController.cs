using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminBootrap.Controllers
{
    public class LogginController : Controller
    {
        // GET: Loggin
        public ActionResult Entrar()
        {
            return View();
        }
    }
}