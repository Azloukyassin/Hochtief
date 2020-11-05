using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.U3Controllers
{
    public class SourceCompanyU3Controller : Controller
    {
        // GET: SourceCompanyU3
        MohamedAzloukSandboxEntities8 _db;
        public SourceCompanyU3Controller()
        {
            _db = new MohamedAzloukSandboxEntities8();
        }
        // GET: SourceCompanyU3
        public ActionResult Index()
        {
            var test = _db.U3SourceCompany.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.U3SourceCompany select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Frima.Contains(searchString) || x.En_Company.Contains(searchString) || x.Pds01.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceCompanyU3
        public ActionResult AddOrEdit(int id = 0)
        {
            U3SourceCompany usermodel = new U3SourceCompany();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(U3SourceCompany userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.U3SourceCompany.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new U3SourceCompany());
        }
    }
}