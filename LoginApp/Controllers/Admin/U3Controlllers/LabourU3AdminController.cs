using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class LabourU3AdminController : Controller
    {
        MohamedAzloukSandboxEntities10 _db;

        public LabourU3AdminController()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: LabourU3Admin
        public ActionResult Index()
        {
            var test = _db.U3Labour.ToList();
            return View(test);
        }
        // GET: LabourU3Admin
        public ActionResult Update()
        {
            U3Labour model = new U3Labour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, U3Labour model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.Labour_id == id)
                {
                    entities.U3Labour.Add(model);
                    entities.SaveChanges();
                }
                return View("Update", new U3Labour());
            }
        }

        // GET: LabourU3Admin
        public ActionResult Delete()
        {
            U3Labour model = new U3Labour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, U3Labour model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.Labour_id == id)
                {
                    entities.U3Labour.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new U3Labour());
            }
        }



    }
}
