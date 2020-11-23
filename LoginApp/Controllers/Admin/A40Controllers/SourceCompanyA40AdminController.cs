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
    public class SourceCompanyA40AdminController : Controller
    {
        A40Entities _db;
        public SourceCompanyA40AdminController()
        {
            _db = new A40Entities();
        }
        // GET: SourceCompanyA40Admin
        public ActionResult Index()
        {
            var test = _db.A40SourceCompany.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index (String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.A40SourceCompany select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Frima.Contains(searchString) || x.En_Company.Contains(searchString) || x.Pds01.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceCompanyA40Admin
        public ActionResult Update()
        {
            A40SourceCompany model = new A40SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A40SourceCompany model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                var neumodel = entitiesA40.A40SourceCompany.Where(x => x.SourceCompany_id == id).FirstOrDefault();

                neumodel.SourceCompany_id = model.SourceCompany_id;
                neumodel.Code = model.Code;
                neumodel.De_Frima = model.De_Frima;
                neumodel.Pds01 = model.Pds01;
                neumodel.En_Company= model.En_Company;
                
                entitiesA40.SaveChanges();
            
                return View("Update", new A40SourceCompany());
            }
        }
        // GET: SourceCompanyA40Admin
        public ActionResult Delete()
        {
            A40SourceCompany model = new A40SourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A40SourceCompany model)
        {
            using (A40Entities entitiesA6 = new A40Entities())
            {
                if (model.SourceCompany_id == id)
                {
                    entitiesA6.A40SourceCompany.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new A40SourceCompany());
            }
        }
    }
}
