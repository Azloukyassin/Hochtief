using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace LoginApp.Controllers.A6Controllers
{
    public class SourceCompanyA40Controller : Controller
    {
        // GET: SourceCompanyA40
        A40Entities _db;
        public SourceCompanyA40Controller()
        {
            _db = new A40Entities();
        }
        // GET: SourceCompanyA40
        public ActionResult Index()
        {
            var test = _db.A40SourceCompany.ToList();
            return View(test);
        }
        // Filter With Functionalty 
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.A40SourceCompany select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Company.Contains(searchString) || x.De_Frima.Contains(searchString) ||  x.Code.Contains(searchString) || x.Pds01.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceCompanyA40
        public ActionResult AddOrEdit(int id = 0)
        {
            A40SourceCompany usermodel = new A40SourceCompany();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A40SourceCompany userModel)
        {
            using (A40Entities model = new A40Entities())
            {
                model.A40SourceCompany.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A40SourceCompany());
        }
    }
}