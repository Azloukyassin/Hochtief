using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace LoginApp.Controllers.Admin.U3Controlllers
{
    public class SourceCompanyU3AdminController : Controller
    {
        MohamedAzloukSandboxEntities10 _db;
        public SourceCompanyU3AdminController()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: SourceCompanyU3Admin
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
            if(!String.IsNullOrWhiteSpace(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Frima.Contains(searchString) || x.En_Company.Contains(searchString)|| x.Pds01.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceCompanyU3Admin 
        public ActionResult Create(int id=0)
        {
            U3SourceCompany u3SourceCompany = new U3SourceCompany();
            return View(u3SourceCompany); 
        }
        [HttpPost]
        public ActionResult Create(U3SourceCompany u3SourceCompany)
        {
            using(MohamedAzloukSandboxEntities10 entitie = new MohamedAzloukSandboxEntities10())
            {
                entitie.U3SourceCompany.Add(u3SourceCompany);
                entitie.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Create", new U3SourceCompany()); 
        }
        // GET: SourceCompanyU3Admin
        public ActionResult Update()
        {
            U3SourceCompany model = new U3SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, U3SourceCompany model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                var neumodel = entities.U3SourceCompany.Where(x => x.SourceCompany_id == id).FirstOrDefault();
                neumodel.SourceCompany_id = model.SourceCompany_id;
                neumodel.Code = model.Code;
                neumodel.De_Frima = model.De_Frima;
                neumodel.Pds01 = model.Pds01;
                neumodel.En_Company = model.En_Company;
                return View("Update", new U3SourceCompany());
            }
        }
        // GET: SourceCompanyU3Admin
        public ActionResult Delete()
        {
            U3SourceCompany model = new U3SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, U3SourceCompany model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                var data = (from x in entities.U3SourceCompany
                            where x.SourceCompany_id == id
                            select x).FirstOrDefault();
                entities.U3SourceCompany.Remove(data);
                entities.SaveChanges();
            }
                return View("Delete", new U3SourceCompany());
        }
    }
}