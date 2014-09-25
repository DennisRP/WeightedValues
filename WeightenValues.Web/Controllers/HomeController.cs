using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeightedValues.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Redirect to the only page with real content for now - the administration page
            // (This is only temporary)
            return RedirectToAction("Index", "Administration");

            //return View();
        }
    }
}