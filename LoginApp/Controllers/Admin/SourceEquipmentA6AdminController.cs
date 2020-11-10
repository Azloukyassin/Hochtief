﻿using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceEquipmentA6AdminController : Controller
    {
        MohamedAzloukSandboxEntitiesA6 _db;

        public SourceEquipmentA6AdminController()
        {
            _db = new MohamedAzloukSandboxEntitiesA6();
        }
        // GET: SourceEquipmentA6Admin
        public ActionResult Index()
        {
            var test = _db.A6SourceEquipmenttest.ToList();
            return View(test);
        }
        // GET: SourceEquipmentAdmin
        public ActionResult Update()
        {
            A6SourceEquipmenttest model = new A6SourceEquipmenttest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A6SourceEquipmenttest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if (model.sourceEq_id == id)
                {
                    entitiesA6.A6SourceEquipmenttest.Add(model);
                    entitiesA6.SaveChanges();
                }
                return View("Update", new A6SourceEquipmenttest());
            }
        }

        // GET: SourceEquipmentA6Admin
        public ActionResult Delete()
        {
            A6SourceEquipmenttest model = new A6SourceEquipmenttest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A6SourceEquipmenttest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if (model.sourceEq_id == id)
                {
                    entitiesA6.A6SourceEquipmenttest.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new A6SourceEquipmenttest());
            }
        }



    }
}