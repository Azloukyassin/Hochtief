using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceCompanyA40AdminController : Controller
    {
        A40Entities _db;

        public SourceCompanyA40AdminController()
        {
            _db = new A40Entities();
        }
        // GET: SourceCompanyA40Admin
        public ActionResult Index()
        {
            var test = _db.A40SourceCompany.ToList();
            return View(test);
        }
        // GET: SourceCompanyA40Admin
        public ActionResult Update()
        {
            A40SourceCompany model = new A40SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A40SourceCompany model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                if (model.SourceCompany_id == id)
                {
                    entitiesA40.A40SourceCompany.Add(model);
                    entitiesA40.SaveChanges();
                }
                return View("Update", new A40SourceCompany());
            }
        }

        // GET: SourceCompanyA40Admin
        public ActionResult Delete()
        {
            A40SourceCompany model = new A40SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A40SourceCompany model)
        {
            using (A40Entities entitiesA6 = new A40Entities())
            {
                if (model.SourceCompany_id == id)
                {
                    entitiesA6.A40SourceCompany.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new A40SourceCompany());
            }
        }



    }
}
