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
    public class SourceRoleA40AdminController : Controller
    {
        A40Entities _db;
        public SourceRoleA40AdminController()
        {
            _db = new A40Entities();
        }
        // GET: SourceRoleA40Admin
        public ActionResult Index()
        {
            var test = _db.A40SourceRole.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.A40SourceRole select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.De_Role.Contains(searchString) || x.En_Role.Contains(searchString) || x.Code.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceRoleA40Admin
        public ActionResult Update()
        {
            A40SourceRole model = new A40SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A40SourceRole model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                var neumodel = entitiesA40.A40SourceRole.Where(x => x.Source_id == id).FirstOrDefault();

                neumodel.Source_id = model.Source_id;
                neumodel.Code = model.Code;
                neumodel.De_Role = model.De_Role;
                neumodel.En_Role = model.En_Role;

                return View("Update", new A40SourceRole());
            }
        }
        // GET: SourceRoleA40Admin
        public ActionResult Delete()
        {
            A40SourceRole model = new A40SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A40SourceRole model)
        {
            using (A40Entities entitiesA40 = new A40Entities())
            {
                if (model.Source_id == id)
                {
                    entitiesA40.A40SourceRole.Remove(model);
                    entitiesA40.SaveChanges();
                }
                return View("Delete", new A40SourceRole());
            }
        }
    }
}
