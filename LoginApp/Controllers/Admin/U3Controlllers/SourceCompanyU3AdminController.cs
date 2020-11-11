﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin.U3Controlllers
{
    public class SourceCompanyU3AdminController : Controller
    {
        MohamedAzloukSandboxEntities10 _db;

        public SourceCompanyU3AdminController()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: SourceCompanyU3Admin
        public ActionResult Index()
        {
            var test = _db.U3SourceCompany.ToList();
            return View(test);
        }
        // GET: SourceCompanyU3Admin
        public ActionResult Update()
        {
            U3SourceCompany model = new U3SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, U3SourceCompany model)
        {
            using (MohamedAzloukSandboxEntities10 entitiesA6 = new MohamedAzloukSandboxEntities10())
            {
                if (model.SourceCompany_id == id)
                {
                    entitiesA6.U3SourceCompany.Add(model);
                    entitiesA6.SaveChanges();
                }
                return View("Update", new U3SourceCompany());
            }
        }
        // GET: SourceCompanyU3Admin

        public ActionResult Delete()
        {
            U3SourceCompany model = new U3SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, U3SourceCompany model)
        {
            using (MohamedAzloukSandboxEntities10 entitiesA6 = new MohamedAzloukSandboxEntities10())
            {
                if (model.SourceCompany_id == id)
                {
                    entitiesA6.U3SourceCompany.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new U3SourceCompany());
            }
        }
    }
}