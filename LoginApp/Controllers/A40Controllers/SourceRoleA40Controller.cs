using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A40Controllers
{
    public class SourceRoleA40Controller : Controller
    {

        MohamedAzloukSandboxEntities8 _db; 
        public SourceRoleA40Controller()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: SourceRoleA40
        public ActionResult Index()
        {
            var model = _db.A40SourceRole.ToList();
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.A40SourceRole select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.De_Role.Contains(searchString) || x.En_Role.Contains(searchString) || x.Code.Contains(searchString)); 
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET: SourceRoleA40 
        public ActionResult AddOrEdit(int id=0)
        {
            A40SourceRole a40SourceRole = new A40SourceRole();
            return View(a40SourceRole); 
        }
        [HttpPost]
        public ActionResult AddOrEdit(A40SourceRole a40SourceRole)
        {
            using(MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.A40SourceRole.Add(a40SourceRole);
                model.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("AddOrEdit", new A40SourceRole()); 
        }
    }
}