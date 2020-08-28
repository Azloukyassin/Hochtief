
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistierung;


namespace UserReg.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddorEdit(int id=0)
        {
            UserTab usermodel = new UserTab(); 
            return View(usermodel);
        }    
        public ActionResult AddorEdit(UserTab userModel)
        {
            using (MohamedAzloukSandboxEntities model = new MohamedAzloukSandboxEntities())
            {
                model.UserTab.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("AddorEdit",new UserTab());
        }
    }
}