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
    public class LabourICEAdminController : Controller
    {
        ICEEntities _db;

        public LabourICEAdminController()
        {
            _db = new ICEEntities();
        }
        // GET: LabourICEAdmin
        public ActionResult Index()
        {
            var test = _db.ICELabour.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICELabour select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Area.Contains(searchString) || x.Comment.Contains(searchString) || x.Company.Contains(searchString) || x.Firstname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Position.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: LabourICEAdmin
        public ActionResult Update()
        {
            ICELabour model = new ICELabour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, ICELabour model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                if (model.Labour_id == id)
                {
                    entities.ICELabour.Add(model);
                    entities.SaveChanges();
                }
                return View("Update", new ICELabour());
            }
        }

        // GET: LabourICEAdmin
        public ActionResult Delete()
        {
            ICELabour model = new ICELabour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, ICELabour model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                if (model.Labour_id == id)
                {
                    entities.ICELabour.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new ICELabour());
            }
        }



    }
}