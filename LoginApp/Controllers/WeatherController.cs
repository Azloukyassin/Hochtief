using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class WeatherController : Controller
    {
        MohamedAzloukSandboxEntities4 _db ; 
        public WeatherController()
        {
            _db = new MohamedAzloukSandboxEntities4(); 
        }
       
        // GET:Weather

        public ActionResult Index()
        {
            var test = _db.Weathertest.ToList() ;
            return View(test); 
        }
        // GET:Weather

        public ActionResult AddOrEdit(int id = 0)
        {
            Weathertest userModel = new Weathertest();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(Weathertest userModel)
        {
            using (MohamedAzloukSandboxEntities4 model = new MohamedAzloukSandboxEntities4())
            {
                model.Weathertest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new Weathertest());
        }
    }
}