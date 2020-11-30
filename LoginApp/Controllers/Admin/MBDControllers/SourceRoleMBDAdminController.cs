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
    public class SourceRoleMBDAdminController : Controller
    {
        MBDEntities _db;
        public SourceRoleMBDAdminController()
        {
            _db = new MBDEntities();
        }
        // GET: SourceRoleMBDAdmin
        public ActionResult Index()
        {
            var test = _db.MDBSourceRole.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.MDBSourceRole select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Role.Contains(searchString) || x.En_Role.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceRoleMBDAdmin 
        public ActionResult Create(int id=0)
        {
            MDBSourceRole mDBSourceRole = new MDBSourceRole();
            return View(mDBSourceRole); 
        }
        [HttpPost]
        public ActionResult Create(MDBSourceRole mDBSourceRole)
        {
            using(MBDEntities entitie = new MBDEntities())
            {
                entitie.MDBSourceRole.Add(mDBSourceRole);
                entitie.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Create", new MDBSourceRole()); 
        }
        // GET: SourceRoleMBDAdmin
        public ActionResult Update()
        {
            MDBSourceRole model = new MDBSourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, MDBSourceRole model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                var neumodel = entities.MDBSourceRole.Where(x => x.Source_id == id).FirstOrDefault();
                neumodel.Source_id = model.Source_id;
                neumodel.Code = model.Code;
                neumodel.De_Role = model.De_Role;
                neumodel.En_Role = model.En_Role;
                return View("Update", new MDBSourceRole());
            }
        }
        // GET: SourceRoleMBDAdmin
        public ActionResult Delete()
        {
            MDBSourceRole model = new MDBSourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, MDBSourceRole model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                var data = (from x in entities.MDBSourceRole
                            where x.Source_id == id
                            select x).FirstOrDefault();
                entities.MDBSourceRole.Remove(data);
                entities.SaveChanges(); 
                return View("Delete", new MDBSourceRole());
            }
        }
    }
}
