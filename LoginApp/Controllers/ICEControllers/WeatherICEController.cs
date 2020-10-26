using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.ICEControllers
{
    public class WeatherICEController : Controller
    {
        MohamedAzloukSandboxEntities26 _db;
        public WeatherICEController()
        {
            _db = new MohamedAzloukSandboxEntities26();
        }

        // GET:WeatherICE

       
        // GET: WeatherICE
        public ActionResult Index()
        {
            return View();
        }
    }
}