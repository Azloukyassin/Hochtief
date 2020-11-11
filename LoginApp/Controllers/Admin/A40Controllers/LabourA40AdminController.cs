using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LoginApp.Controllers.Admin
{
    public class LabourA40AdminController : Controller
    {
        A40Entities _db;
        public LabourA40AdminController()
        {
            _db = new A40Entities();
        }
        // GET: LabourA40Admin
        public ActionResult Index()
        {
            var test = _db.A40Labour.ToList();
            return View(test);
        }
        // GET: LabourA40Admin
        public ActionResult Update()
        {
            A40Labour model = new A40Labour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A40Labour model)
        {
            using (A40Entities entitiesA6 = new A40Entities())
            {
                if (model.Labour_id == id)
                {
                    entitiesA6.A40Labour.Add(model);
                    entitiesA6.SaveChanges();
                }
                return View("Update", new A40Labour());
            }
        }
        // GET: LabourA40Admin
        public ActionResult Delete()
        {
            A40Labour model = new A40Labour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A40Labour model)
        {
            using (A40Entities entities = new A40Entities())
            {
                if (model.Labour_id == id)
                {
                    entities.A40Labour.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new A40Labour());
            }
        }



    }
}
