using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace LoginApp.Controllers.A6Controllers
{
    public class SourceCompanyMBDController : Controller
    {
        // GET: SourceCompanyMBD
        MBDEntities _db;
        public SourceCompanyMBDController()
        {
            _db = new MBDEntities();
        }
        // GET: SourceCompanyMBD
        public ActionResult Index()
        {
            var test = _db.MDBSourceCompany.ToList();
            return View(test);
        }
        // Filter With Functionalty 
        [HttpGet]

        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.MDBSourceCompany select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Company.Contains(searchString) || x.De_Frima.Contains(searchString) || x.Code.Contains(searchString) || x.Pds01.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceCompanyMBD
        public ActionResult AddOrEdit(int id = 0)
        {
            MDBSourceCompany usermodel = new MDBSourceCompany();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBSourceCompany userModel)
        {
            using (MBDEntities model = new MBDEntities())
            {
                model.MDBSourceCompany.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new MDBSourceCompany());
        }
    }
}