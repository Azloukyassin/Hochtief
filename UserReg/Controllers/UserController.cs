using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserReg.Models; 

namespace UserReg.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddorEdit(int id=0)
        {
            User usermodel = new User(); 
            return View(usermodel);
        }
        // Muss nachschauen 
        [HttpPost]
        public ActionResult AddorEdit(User userModel)
        {
            using ()
            {

            }
        }
    }
}