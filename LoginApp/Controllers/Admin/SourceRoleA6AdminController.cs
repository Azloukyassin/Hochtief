using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceRoleA6AdminController : Controller
    {
        MohamedAzloukSandboxEntitiesA6 _db;

        public SourceRoleA6AdminController()
        {
            _db = new MohamedAzloukSandboxEntitiesA6();
        }
        // GET: SourceRoleA6Admin
        public ActionResult Index()
        {
            var test = _db.A6SourceRoletest.ToList();
            return View(test);
        }
        // GET: SourceRoleA6Admin
        public ActionResult Update()
        {
            A6SourceRoletest model = new A6SourceRoletest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A6SourceRoletest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if (model.source_id == id)
                {
                    entitiesA6.A6SourceRoletest.Add(model);
                    entitiesA6.SaveChanges();
                }
                return View("Update", new A6SourceRoletest());
            }
        }

        // GET: SourceRoleA6Admin
        public ActionResult Delete()
        {
            A6SourceRoletest model = new A6SourceRoletest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A6SourceRoletest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if (model.source_id== id)
                {
                    entitiesA6.A6SourceRoletest.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new A6SourceRoletest());
            }
        }



    }
}
