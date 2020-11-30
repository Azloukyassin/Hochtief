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
    public class SourceCompanyICEAdminController : Controller
    {
        ICEEntities _db;
        public SourceCompanyICEAdminController()
        {
            _db = new ICEEntities();
        }
        // GET: SourceCompanyICEAdmin
        public ActionResult Index()
        {
            var test = _db.ICESourceCompany.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICESourceCompany select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Frima.Contains(searchString) || x.Pds01.Contains(searchString) || x.En_Company.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET: SourceCompanyICEAdmin 
        public ActionResult Create(int id=0)
        {
            ICESourceCompany iCESourceCompany = new ICESourceCompany();
            return View(iCESourceCompany); 
        }
        [HttpPost]
        public ActionResult Create(ICESourceCompany iCESourceCompany)
        {
            using(ICEEntities model = new ICEEntities())
            {
                model.ICESourceCompany.Add(iCESourceCompany);
                model.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Create", new ICESourceCompany());
        }
        // GET: SourceCompanyICEAdmin
        public ActionResult Update()
        {
           ICESourceCompany model = new ICESourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, ICESourceCompany model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var neumodel = entities.ICESourceCompany.Where(x => x.SourceCompany_id == id).FirstOrDefault();

                neumodel.SourceCompany_id = model.SourceCompany_id;
                neumodel.Code = model.Code;
                neumodel.De_Frima = model.De_Frima;
                neumodel.Pds01 = model.Pds01;
                neumodel.En_Company = model.En_Company;
                return View("Update", new ICESourceCompany());
            }
        }
        // GET: SourceCompanyICEAdmin
        public ActionResult Delete()
        {
            ICESourceCompany model = new ICESourceCompany();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, ICESourceCompany model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var data = (from x in entities.ICESourceCompany
                            where x.SourceCompany_id == id
                            select x).FirstOrDefault();
                entities.ICESourceCompany.Remove(data);
                entities.SaveChanges();
            }
                return View("Delete", new ICESourceCompany());
        }
    }
}
