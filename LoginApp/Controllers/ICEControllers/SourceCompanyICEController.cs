using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace LoginApp.Controllers.ICEControllers
{
    public class SourceCompanyICEController : Controller
    {
        MohamedAzloukSandboxEntities8 _db; 
        public SourceCompanyICEController()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: SourceCompanyICE
        public ActionResult Index()
        {
            var model = _db.ICESourceCompany.ToList(); 
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Index(string searchString)
        {

            ViewData["Getdetais"] = searchString;
            var modelquery = from x in _db.ICESourceCompany select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.De_Frima.Contains(searchString) || x.En_Company.Contains(searchString) || x.Code.Contains(searchString) || x.Pds01.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }

        // GET: SourceCompanyICE 
        public ActionResult AddOrEdit()
        {
            ICESourceCompany usermodel = new ICESourceCompany();
            return View(usermodel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(ICESourceCompany userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.ICESourceCompany.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A6SourceRoletest());
        }
    }
}