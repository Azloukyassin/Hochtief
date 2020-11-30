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
    public class LabourMBDAdminController : Controller
    {
        MBDEntities _db;
        public LabourMBDAdminController()
        {
            _db = new MBDEntities();
        }
        // GET: LabourMBDAdmin
        public ActionResult Index()
        {
            var test = _db.MDBLabour.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
          {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.MDBLabour select x;
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Fullname.Contains(searchString) || x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Position.Contains(searchString) || x.Company.Contains(searchString) || x.Comment.Contains(searchString) || x.Area.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
          }  
        // GET: LabourMBDAdmin 
        public ActionResult Create(int id=0)
        {
            MDBLabour mDBLabour = new MDBLabour();
            return View(mDBLabour); 
        }
        [HttpPost]
        public ActionResult Create(MDBLabour mDBLabour)
        {
            using(MBDEntities entitie = new MBDEntities())
            {
                entitie.MDBLabour.Add(mDBLabour);
                entitie.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Create", new MDBLabour()); 
        }
        // GET: LabourMBDAdmin
        public ActionResult Update()
        {
            MDBLabour model = new MDBLabour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, MDBLabour model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                var neumodel = entities.MDBLabour.Where(x => x.Labour_id == id).FirstOrDefault();
                neumodel.Firstname = model.Firstname;
                neumodel.Lastname = model.Lastname;
                neumodel.Fullname = model.Fullname;
                neumodel.Labour_id = model.Labour_id;
                neumodel.Position = model.Position;
                neumodel.Comment = model.Comment;
                neumodel.Company = model.Company;
                return View("Update", new MDBLabour());
            }
        }
        // GET: LabourMBDAdmin
        public ActionResult Delete()
        {
            MDBLabour model = new MDBLabour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, MDBLabour model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                var data = (from x in entities.MDBLabour
                            where x.Labour_id == id
                            select x).FirstOrDefault();
                entities.MDBLabour.Remove(data);
                entities.SaveChanges();
            }
                return View("Delete", new MDBLabour());
            
        }
    }
}
