using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class SourceRoleController : Controller
    {
        // GET: SourceRole
        public ActionResult AddOrEdit(int id = 0)
        {
            SourceRolTest userModel = new SourceRolTest();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(SourceRolTest userModel)
        {
            using (MohamedAzloukSandboxTest model = new MohamedAzloukSandboxTest())
            {
                model.SourceRolTest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new SourceRolTest());
        }
    }
}