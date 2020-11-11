using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceRoleA40AdminController : Controller
    {
        A40Entities _db;

        public SourceRoleA40AdminController()
        {
            _db = new A40Entities();
        }
        // GET: SourceRoleA40Admin
        public ActionResult Index()
        {
            var test = _db.A40SourceRole.ToList();
            return View(test);
        }
        // GET: SourceRoleA40Admin
        public ActionResult Update()
        {
            A40SourceRole model = new A40SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A40SourceRole model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                if (model.Source_id == id)
                {
                    entitiesA40.A40SourceRole.Add(model);
                    entitiesA40.SaveChanges();
                }
                return View("Update", new A40SourceRole());
            }
        }

        // GET: SourceRoleA40Admin
        public ActionResult Delete()
        {
            A40SourceRole model = new A40SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A40SourceRole model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                if (model.Source_id == id)
                {
                    entitiesA40.A40SourceRole.Remove(model);
                    entitiesA40.SaveChanges();
                }
                return View("Delete", new A40SourceRole());
            }
        }



    }
}
