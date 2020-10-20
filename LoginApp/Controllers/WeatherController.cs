﻿using LoginApp.Models;
using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class WeatherController : Controller
    {
        
        private readonly IRepostory<Weathertest> Repostory;
        public WeatherController(IRepostory<Weathertest> repostory)
        {
            this.Repostory = repostory;
        }
       
        // GET:Weather
        public ActionResult Index()
        {
            var test = Repostory.List(); ;
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