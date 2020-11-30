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
    public class LabourICEAdminController : Controller
    {
        ICEEntities _db;
        public LabourICEAdminController()
        {
            _db = new ICEEntities();
        }
        // GET: LabourICEAdmin
        public ActionResult Index()
        {
            var test = _db.ICELabour.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICELabour select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Area.Contains(searchString) || x.Comment.Contains(searchString) || x.Company.Contains(searchString) || x.Firstname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Position.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // Fonction Create is Done ! 
        // GET: LabourICEAdmin 
        public ActionResult Create(int id=0)
        {
            ICELabour iCELabour = new ICELabour();
            return View(iCELabour); 
        }
        [HttpPost]
        public ActionResult Create(ICELabour iCELabour)
        {
            using(ICEEntities entities = new ICEEntities())
            {
                entities.ICELabour.Add(iCELabour);
                entities.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Create", new ICELabour()); 
        }
        // GET: LabourICEAdmin
        public ActionResult Update()
        {
            ICELabour model = new ICELabour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, ICELabour model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var neumodel = entities.ICELabour.Where(x => x.Labour_id == id).FirstOrDefault();
                neumodel.Firstname = model.Firstname;
                neumodel.Lastname = model.Lastname;
                neumodel.Fullname = model.Fullname;
                neumodel.Labour_id = model.Labour_id;
                neumodel.Position = model.Position;
                neumodel.Comment = model.Comment;
                neumodel.Company = model.Company;
                return View("Update", new ICELabour());
            }
        }
        // GET: LabourICEAdmin
        public ActionResult Delete()
        {
            ICELabour model = new ICELabour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, ICELabour model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var data = (from x in entities.ICELabour
                            where x.Labour_id == id
                            select x).FirstOrDefault();
                entities.ICELabour.Remove(data);
                entities.SaveChanges();
            }
                return View("Delete", new ICELabour());
        }
    }
}

