using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceRoleU3AdminController : Controller
    {
        MohamedAzloukSandboxEntities10 _db;

        public SourceRoleU3AdminController()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: SourceRoleU3Admin
        public ActionResult Index()
        {
            var test = _db.U3SourceRole.ToList();
            return View(test);
        }
        // GET: SourceRoleU3Admin
        public ActionResult Update()
        {
            U3SourceRole model = new U3SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, U3SourceRole model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.Source_id == id)
                {
                    entities.U3SourceRole.Add(model);
                    entities.SaveChanges();
                }
                return View("Update", new U3SourceRole());
            }
        }

        // GET: SourceRoleU3Admin
        public ActionResult Delete()
        {
            U3SourceRole model = new U3SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, U3SourceRole model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.Source_id == id)
                {
                    entities.U3SourceRole.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new U3SourceRole());
            }
        }



    }
}
