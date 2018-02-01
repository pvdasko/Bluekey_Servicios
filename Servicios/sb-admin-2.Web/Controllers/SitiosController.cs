using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servicios.Web.Controllers
{
    public class SitiosController : Controller
    {
        // GET: Sitios
        public ActionResult Index()
        {
            return View();
        }
    }
}