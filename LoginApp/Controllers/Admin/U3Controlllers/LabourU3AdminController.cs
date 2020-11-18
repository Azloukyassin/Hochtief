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

        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.U3Labour select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Fullname.Contains(searchString) || x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Position.Contains(searchString) || x.Company.Contains(searchString) || x.Comment.Contains(searchString) || x.Area.Contains(searchString)); 
            }
            return View(modelquery.AsNoTracking().ToListAsync()); 
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
