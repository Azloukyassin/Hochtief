using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.U3Controllers
{
    public class SourceRoleU3Controller : Controller
    {
        // GET: SourceRoleU3
        MohamedAzloukSandboxEntities8 _db;
        public SourceRoleU3Controller()
        {
            _db = new MohamedAzloukSandboxEntities8();
        }
        // GET: SourceEquipmentA6
        public ActionResult Index()
        {
            var test = _db.U3SourceRole.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.U3SourceRole select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Role.Contains(searchString) || x.En_Role.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceEquipmentA6
        public ActionResult AddOrEdit(int id = 0)
        {
            U3SourceRole usermodel = new U3SourceRole();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(U3SourceRole userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.U3SourceRole.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new U3SourceRole());
        }
    }
}