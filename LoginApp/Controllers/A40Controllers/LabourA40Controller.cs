using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A40Controllers
{
    public class LabourA40Controller : Controller
    {
        // GET: LabourA40
        MohamedAzloukSandboxEntities8 _db; 
        public LabourA40Controller()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: LabourA40
        public ActionResult Index()
        {
            var test = _db.A40Labour.ToList();
            return View(test); 
        }

        [HttpGet]
        public async  Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.A40Labour select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Position.Contains(searchString) || x.Company.Contains(searchString) || x.Comment.Contains(searchString) || x.Area.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET: LabourA40 
        public ActionResult AddOrEdit(int id=0)
        {
            A40Labour a40Labour = new A40Labour();
            return View(a40Labour); 
        }

        [HttpPost]

        public ActionResult AddOrEdit(A40Labour a40Labour)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.A40Labour.Add(a40Labour);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A40Labour());
        }
    }
}