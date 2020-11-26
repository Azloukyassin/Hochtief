using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class SourceCompanyController : Controller
    {
        // GET: SourceCompany
        public ActionResult AddOrEdit(int id = 0)
        {
            SourceCompanyTest userModel = new SourceCompanyTest();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(SourceCompanyTest userModel)
        {
            using (MohamedAzloukSandboxTest model = new MohamedAzloukSandboxTest())
            {
                model.SourceCompanyTest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("AddOrEdit", new SourceCompanyTest());
        }
    }
}