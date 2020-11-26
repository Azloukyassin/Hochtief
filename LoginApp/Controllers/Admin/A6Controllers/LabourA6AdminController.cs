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
                var neumodel = entitiesA6.A6Labourtest.Where(x => x.labour_id == id).FirstOrDefault();

                neumodel.Firstname = model.Firstname;
                neumodel.Lastname = model.Lastname;
                neumodel.fullname = model.fullname;
                neumodel.labour_id = model.labour_id;
                neumodel.Position = model.Position;
                neumodel.Comment = model.Comment;
                neumodel.Company = model.Company;
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
                var data = (from x in entitiesA6.A6Labourtest
                            where x.labour_id == id
                            select x).FirstOrDefault();
                entitiesA6.A6Labourtest.Remove(data);
                entitiesA6.SaveChanges();
            }
                return View("Delete", new A6Labourtest());
            
        }
    }
}
