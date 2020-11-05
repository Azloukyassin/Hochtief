using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A40Controllers
{
    public class SourceCompanyA40Controller : Controller
    {

        MohamedAzloukSandboxEntities8 _db; 
        public SourceCompanyA40Controller()
        {
            _db = new MohamedAzloukSandboxEntities8();
        }
        // GET: SourceCompanyA40
        public ActionResult Index()
        {
            var model = _db.A40SourceCompany.ToList(); 
            return View(model);
        }
        
        [HttpGet]

        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.A40SourceCompany select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Company.Contains(searchString) || x.De_Frima.Contains(searchString) || x.Code.Contains(searchString) || x.Pds01.Contains(searchString)); 
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET: SourceCompanyA40 

        public ActionResult AddOrEdit(int id=0)
        {
            A40SourceCompany a40SourceCompany = new A40SourceCompany();
            return View(a40SourceCompany); 
        }

        [HttpPost]
        public ActionResult AddOrEdit(A40SourceCompany a40SourceCompany)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.A40SourceCompany.Add(a40SourceCompany);
                model.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("AddOrEdit", new A40SourceCompany()); 
        }
    }
}