using LoginApp.Models.Repostories;
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
                if (model.Labour_id == id)
                {
                    entities.MDBLabour.Add(model);
                    entities.SaveChanges();
                }
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
                if (model.Labour_id == id)
                {
                    entities.MDBLabour.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new MDBLabour());
            }
        }
    }
}
