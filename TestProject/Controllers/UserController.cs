using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddOrEdit(int id = 0)
        {
            Usertest userModel = new Usertest();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(Usertest userModel)
        {
            using (MohamedAzloukSandboxEntities model = new MohamedAzloukSandboxEntities())
            {
                model.Usertest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new Usertest());
        }
    }
}