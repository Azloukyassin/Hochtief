﻿using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace LoginApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddOrEdit(int id=0)
        {
            UserTab userModel = new UserTab(); 
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(UserTab userModel)
        {
            using (MohamedAzloukSandboxEntities1 model = new MohamedAzloukSandboxEntities1())
            {
                model.UserTab.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new UserTab()); 
        }
    }
}