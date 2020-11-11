using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceEquipmentU3AdminController : Controller
    {
        MohamedAzloukSandboxEntities10 _db;

        public SourceEquipmentU3AdminController()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: SourceEquipmentU3Admin
        public ActionResult Index()
        {
            var test = _db.U3SourceEquipment.ToList();
            return View(test);
        }
        // GET: SourceEquipmentAdmin
        public ActionResult Update()
        {
            U3SourceEquipment model = new U3SourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, U3SourceEquipment model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.SourceEquipment == id)
                {
                    entities.U3SourceEquipment.Add(model);
                    entities.SaveChanges();
                }
                return View("Update", new U3SourceEquipment());
            }
        }

        // GET: SourceEquipmentU3Admin
        public ActionResult Delete()
        {
            U3SourceEquipment model = new U3SourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, U3SourceEquipment model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.SourceEquipment == id)
                {
                    entities.U3SourceEquipment.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new U3SourceEquipment());
            }
        }



    }
}
