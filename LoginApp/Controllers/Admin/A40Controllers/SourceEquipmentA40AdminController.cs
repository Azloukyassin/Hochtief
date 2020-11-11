using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceEquipmentA40AdminController : Controller
    {
        A40Entities _db;

        public SourceEquipmentA40AdminController()
        {
            _db = new A40Entities();
        }
        // GET: SourceEquipmentA40Admin
        public ActionResult Index()
        {
            var test = _db.A40SourceEquipment.ToList();
            return View(test);
        }
        // GET: SourceEquipmentA40Admin
        public ActionResult Update()
        {
            A40SourceEquipment model = new A40SourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A40SourceEquipment model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                if (model.SourceEquipment == id)
                {
                    entitiesA40.A40SourceEquipment.Add(model);
                    entitiesA40.SaveChanges();
                }
                return View("Update", new A40SourceEquipment());
            }
        }

        // GET: SourceEquipmentA40Admin
        public ActionResult Delete()
        {
            A40SourceEquipment model = new A40SourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A40SourceEquipment model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                if (model.SourceEquipment == id)
                {
                    entitiesA40.A40SourceEquipment.Remove(model);
                    entitiesA40.SaveChanges();
                }
                return View("Delete", new A40SourceEquipment());
            }
        }



    }
}
