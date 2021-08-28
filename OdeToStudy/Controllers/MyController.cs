using OdeToStudy.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToStudy.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index(string name)
        {
            var x = new MyViewModel();
            x.Display2 = name ?? " ";
            x.Display = ConfigurationManager.AppSettings["greet"];
            return View(x);
        }
    }
}