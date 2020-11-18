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
    public class SourceRoleU3AdminController : Controller
    {
        MohamedAzloukSandboxEntities10 _db;

        public SourceRoleU3AdminController()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: SourceRoleU3Admin
        public ActionResult Index()
        {
            var test = _db.U3SourceRole.ToList();
            return View(test);
        }
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString; 
            var modelquery = from x in _db.U3SourceRole select x ; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Role.Contains(searchString) || x.En_Role.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET: SourceRoleU3Admin
        public ActionResult Update()
        {
            U3SourceRole model = new U3SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, U3SourceRole model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.Source_id == id)
                {
                    entities.U3SourceRole.Add(model);
                    entities.SaveChanges();
                }
                return View("Update", new U3SourceRole());
            }
        }

        // GET: SourceRoleU3Admin
        public ActionResult Delete()
        {
            U3SourceRole model = new U3SourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, U3SourceRole model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                if (model.Source_id == id)
                {
                    entities.U3SourceRole.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new U3SourceRole());
            }
        }



    }
}
