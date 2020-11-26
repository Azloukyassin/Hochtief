using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class LabourController : Controller
    {
        // GET: Labour
        public ActionResult AddOrEdit(int id = 0)
        {
           Labourtest userModel = new Labourtest();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(Labourtest userModel)
        {
            using (MohamedAzloukSandboxTest model = new MohamedAzloukSandboxTest())
            {
                model.Labourtest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("AddOrEdit", new Labourtest());
        }
    }
}