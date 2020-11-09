﻿
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class LabourMBDController : Controller
    {
        // GET: LabourMBD
        MBDEntities _db;
        public LabourMBDController()
        {
            _db = new MBDEntities();
        }
        // GET: LabourMBD
        public ActionResult Index()
        {
            var test = _db.MDBLabour.ToList();
            return View(test);
        }

        [HttpGet]

        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.MDBLabour select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Position.Contains(searchString) || x.Company.Contains(searchString) || x.Comment.Contains(searchString) || x.Area.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }

        // GET: LabourMBD
        public ActionResult AddOrEdit(int id = 0)
        {
            MDBLabour usermodel = new MDBLabour();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBLabour userModel)
        {
            using (MBDEntities model = new MBDEntities())
            {
                model.MDBLabour.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new MDBLabour());
        }
    }
}