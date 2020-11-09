
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class LabourA40Controller : Controller
    {
        // GET: LabourA40
        A40Entities _db;
        public LabourA40Controller()
        {
            _db = new A40Entities();
        }
        // GET: LabourA40
        public ActionResult Index()
        {
            var test = _db.A40Labour.ToList();
            return View(test);
        }

        [HttpGet]

        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.A40Labour select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Position.Contains(searchString) || x.Company.Contains(searchString) || x.Comment.Contains(searchString) || x.Area.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }

        // GET: LabourA6
        public ActionResult AddOrEdit(int id = 0)
        {
            A40Labour usermodel = new A40Labour();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A40Labour userModel)
        {
            using (A40Entities model = new A40Entities())
            {
                model.A40Labour.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A40Labour());
        }
    }
}