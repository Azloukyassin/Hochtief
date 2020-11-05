using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.U3Controllers
{
    public class LabourU3Controller : Controller
    {
        // GET: LabourU3
        MohamedAzloukSandboxEntities8 _db;
        public LabourU3Controller()
        {
            _db = new MohamedAzloukSandboxEntities8();
        }
        // GET: LabourU3
        public ActionResult Index()
        {
            var test = _db.U3Labour.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.U3Labour select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Fullname.Contains(searchString) || x.Firstname.Contains(searchString) || x.Company.Contains(searchString) || x.Lastname.Contains(searchString) || x.Position.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: LabourU3
        public ActionResult AddOrEdit(int id = 0)
        {
            U3Labour usermodel = new U3Labour();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(U3Labour userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.U3Labour.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new U3Labour());
        }
    }
}