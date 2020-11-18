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
    public class LabourA6AdminController : Controller
    {
        MohamedAzloukSandboxEntitiesA6 _db;

        public LabourA6AdminController()
        {
            _db = new MohamedAzloukSandboxEntitiesA6();
        }
        // GET: LabourA6Admin
        public ActionResult Index()
        {
            var test = _db.A6Labourtest.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.A6Labourtest select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.fullname.Contains(searchString) || x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.area.Contains(searchString) || x.Comment.Contains(searchString) || x.Company.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: LabourA6Admin
        // Fonctionality is't not Done ! 
        public ActionResult Update()
        {
            A6Labourtest model = new A6Labourtest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A6Labourtest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if (model.labour_id == id)
                {
                    entitiesA6.A6Labourtest.Add(model);
                    entitiesA6.SaveChanges();
                }
                return View("Update", new A6Labourtest());
            }
        }

        // GET: LabourA6Admin
        public ActionResult Delete()
        {
            A6Labourtest model = new A6Labourtest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A6Labourtest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if (model.labour_id == id)
                {
                    entitiesA6.A6Labourtest.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new A6Labourtest());
            }
        }



    }
}
