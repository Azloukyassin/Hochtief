using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceCompanyA6Controller : Controller
    {
        // GET: SourceCompanyA6
        MohamedAzloukSandboxEntitiesA6 _db;
        public SourceCompanyA6Controller()
        {
            _db = new MohamedAzloukSandboxEntitiesA6();
        }
        // GET: SourceCompanyA6
        public ActionResult Index()
        {
            var test = _db.A6SourceCompanytest.ToList();
            return View(test);
        }

        // GET: SourceCompanyA6
        public ActionResult AddOrEdit(int id = 0)
        {
            A6SourceCompanytest usermodel = new A6SourceCompanytest();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A6SourceCompanytest userModel)
        {
            using (MohamedAzloukSandboxEntitiesA6 model = new MohamedAzloukSandboxEntitiesA6())
            {
                model.A6SourceCompanytest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A6SourceCompanytest());
        }
    }
}