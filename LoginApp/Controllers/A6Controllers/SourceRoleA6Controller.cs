using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceRoleA6Controller : Controller
    {

        MohamedAzloukSandboxEntitiesA6 _db; 
        public SourceRoleA6Controller()
        {
            _db = new MohamedAzloukSandboxEntitiesA6(); 
        }
        // GET: SourceRoleA6
        public ActionResult Index()
        {
            var test = _db.A6SourceRoletest.ToList();
            return View(test); 
        }

        // GET: SourceRoleA6
        public ActionResult AddOrEdit(int id=0)
        {
            A6SourceRoletest usermodel = new A6SourceRoletest();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A6SourceRoletest userModel)
        {
            using (MohamedAzloukSandboxEntitiesA6 model = new MohamedAzloukSandboxEntitiesA6())
            {
                model.A6SourceRoletest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A6SourceRoletest());
        }
    }
}