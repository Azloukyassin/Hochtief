
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class LabourA6Controller : Controller
    {
        // GET: LabourA6
        MohamedAzloukSandboxEntitiesA6 _db;
        public LabourA6Controller()
        {
            _db = new MohamedAzloukSandboxEntitiesA6();
        }
        // GET: LabourA6
        public ActionResult Index()
        {
            var test = _db.A6Labourtest.ToList();
            return View(test);
        }

        [HttpGet]

        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.A6Labourtest select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.fullname.Contains(searchString) || x.Position.Contains(searchString) || x.Company.Contains(searchString) || x.Comment.Contains(searchString) || x.area.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }

        // GET: LabourA6
        public ActionResult AddOrEdit(int id = 0)
        {
            A6Labourtest usermodel = new A6Labourtest();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A6Labourtest userModel)
        {
            using (MohamedAzloukSandboxEntitiesA6 model = new MohamedAzloukSandboxEntitiesA6())
            {
                model.A6Labourtest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A6Labourtest());
        }
    }
}