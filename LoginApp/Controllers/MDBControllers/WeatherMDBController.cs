using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.MDBControllers
{
    public class WeatherMDBController : Controller
    {
        // GET: WeatherMDB
        public ActionResult Index()
        {
            return View();
        }
    }
}