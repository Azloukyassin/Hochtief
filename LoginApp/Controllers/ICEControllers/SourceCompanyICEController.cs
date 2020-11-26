using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceCompanyICEController : Controller
    {
        // GET: SourceCompanyICE
        ICEEntities _db;
        public SourceCompanyICEController()
        {
            _db = new ICEEntities();
        }
        // GET: SourceCompanyICE
        public ActionResult Index()
        {
            var test = _db.ICESourceCompany.ToList();
            return View(test);
        }
        // Filter With Functionalty 
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICESourceCompany select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Company.Contains(searchString) || x.De_Frima.Contains(searchString) || x.Code.Contains(searchString) || x.Pds01.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceCompanyICE
        public ActionResult AddOrEdit(int id = 0)
        {
            ICESourceCompany usermodel = new ICESourceCompany();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(ICESourceCompany userModel)
        {
            using (ICEEntities model = new ICEEntities())
            {
                model.ICESourceCompany.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new ICESourceCompany());
        }
    }
}