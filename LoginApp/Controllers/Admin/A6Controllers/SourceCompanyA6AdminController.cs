using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceCompanyA6AdminController : Controller
    {
        MohamedAzloukSandboxEntitiesA6 _db; 
        public SourceCompanyA6AdminController()
        {
            _db = new MohamedAzloukSandboxEntitiesA6(); 
        }
        // GET: SourceCompanyA6Admin
        public ActionResult Index()
        {
            var test = _db.A6SourceCompanytest.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.A6SourceCompanytest select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.De_Firma.Contains(searchString) || x.En_Company.Contains(searchString) || x.Code.Contains(searchString) || x.Company_type.Contains(searchString) || x.pds01.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceCompanyA6Admin
        public ActionResult Create(int id=0)
        {
            A6SourceCompanytest a6SourceCompanytest = new A6SourceCompanytest();
            return View(a6SourceCompanytest);
        }
        [HttpPost]
        public ActionResult Create(A6SourceCompanytest a6SourceCompanytest)
        {
            using (MohamedAzloukSandboxEntitiesA6 model = new MohamedAzloukSandboxEntitiesA6())
            {
                model.A6SourceCompanytest.Add(a6SourceCompanytest);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("Create", new A6SourceCompanytest());
        }
        // GET: SourceCompanyA6Admin
        public ActionResult Update()
        {
            A6SourceCompanytest model = new A6SourceCompanytest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id ,A6SourceCompanytest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                var neumodel = entitiesA6.A6SourceCompanytest.Where(x => x.sourceCompany_id == id).FirstOrDefault();
                neumodel.sourceCompany_id = model.sourceCompany_id;
                neumodel.Code = model.Code;
                neumodel.De_Firma= model.De_Firma;
                neumodel.pds01 = model.pds01;
                neumodel.En_Company = model.En_Company;
                return View("Update", new A6SourceCompanytest()); 
            }
        }
        // GET: SourceCompanyA6Admin
        public ActionResult Delete()
        {
            A6SourceCompanytest model = new A6SourceCompanytest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A6SourceCompanytest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                var data = (from x in entitiesA6.A6SourceCompanytest
                            where x.sourceCompany_id == id
                            select x).FirstOrDefault();
                entitiesA6.A6SourceCompanytest.Remove(data);
                entitiesA6.SaveChanges();
            }
                return View("Delete", new A6SourceCompanytest());
            
        }
    }
}
