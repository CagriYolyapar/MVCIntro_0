using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro_0.Controllers
{
    public class RazorVController : Controller
    {
        // GET: RazorV
        public ActionResult Index()
        {
            return View();
        }
    }
}