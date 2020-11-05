using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.MDBControllers
{
    public class SourceCompanyMDBController : Controller
    {
        MohamedAzloukSandboxEntities8 _db; 
        public SourceCompanyMDBController()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: SourceCompanyMDB
        public ActionResult Index()
        {
            var model = _db.MDBSourceCompany.ToList(); 
            return View(model);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
            {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.MDBSourceCompany select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Frima.Contains(searchString) || x.En_Company.Contains(searchString) || x.Pds01.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
            }

        // GET: SourceCompanyMDB 
        public ActionResult AddOrEdit(int id = 0)
        {
            MDBSourceCompany usermodel = new MDBSourceCompany();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBSourceCompany userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
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