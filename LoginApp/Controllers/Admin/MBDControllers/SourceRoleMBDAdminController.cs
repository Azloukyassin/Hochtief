﻿using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceRoleMBDAdminController : Controller
    {
        MBDEntities _db;

        public SourceRoleMBDAdminController()
        {
            _db = new MBDEntities();
        }
        // GET: SourceRoleMBDAdmin
        public ActionResult Index()
        {
            var test = _db.MDBSourceRole.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.MDBSourceRole select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Role.Contains(searchString) || x.En_Role.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceRoleMBDAdmin
        public ActionResult Update()
        {
            MDBSourceRole model = new MDBSourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, MDBSourceRole model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                if (model.Source_id == id)
                {
                    entities.MDBSourceRole.Add(model);
                    entities.SaveChanges();
                }
                return View("Update", new MDBSourceRole());
            }
        }

        // GET: SourceRoleMBDAdmin
        public ActionResult Delete()
        {
            MDBSourceRole model = new MDBSourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, MDBSourceRole model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                if (model.Source_id == id)
                {
                    entities.MDBSourceRole.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new MDBSourceRole());
            }
        }



    }
}