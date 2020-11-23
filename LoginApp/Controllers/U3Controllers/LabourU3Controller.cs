using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class LabourU3Controller : Controller
    {
        // GET: LabourU3
        MohamedAzloukSandboxEntities10 _db;
        public LabourU3Controller()
        {
            _db = new MohamedAzloukSandboxEntities10();
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
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.U3Labour select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Position.Contains(searchString) || x.Company.Contains(searchString) || x.Comment.Contains(searchString) || x.Area.Contains(searchString));
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
            using (MohamedAzloukSandboxEntities10 model = new MohamedAzloukSandboxEntities10())
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