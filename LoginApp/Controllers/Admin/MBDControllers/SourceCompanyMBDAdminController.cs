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
    public class SourceCompanyMBDAdminController : Controller
    {
        MBDEntities _db;
        public SourceCompanyMBDAdminController()
        {
            _db = new MBDEntities();
        }
        // GET: SourceCompanyMBDAdmin
        public ActionResult Index()
        {
            var test = _db.MDBSourceCompany.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String seachString)
        {
            ViewData["GetDetails"] = seachString;
            var modelquery = from x in _db.MDBSourceCompany select x; 
            if(!String.IsNullOrEmpty(seachString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(seachString) || x.De_Frima.Contains(seachString) || x.En_Company.Contains(seachString) || x.Pds01.Contains(seachString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceCompanyMBDAdmin
        public ActionResult Update()
        {
            MDBSourceCompany model = new MDBSourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, MDBSourceCompany model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                var neumodel = entities.MDBSourceCompany.Where(x => x.SourceCompany_id == id).FirstOrDefault();

                neumodel.SourceCompany_id = model.SourceCompany_id;
                neumodel.Code = model.Code;
                neumodel.De_Frima = model.De_Frima;
                neumodel.Pds01 = model.Pds01;
                neumodel.En_Company = model.En_Company;
                return View("Update", new MDBSourceCompany());
            }
        }
        // GET: SourceCompanyMBDAdmin
        public ActionResult Delete()
        {
            MDBSourceCompany model = new MDBSourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, MDBSourceCompany model)
        {
            using (MBDEntities entitiesA6 = new MBDEntities())
            {
                if (model.SourceCompany_id == id)
                {
                    entitiesA6.MDBSourceCompany.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new MDBSourceCompany());
            }
        }
    }
}
