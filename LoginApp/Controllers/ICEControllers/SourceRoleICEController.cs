using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.ICEControllers
{
    public class SourceRoleICEController : Controller
    {
        MohamedAzloukSandboxEntities8 _db; 
        public SourceRoleICEController()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: SourceRoleICE
        public ActionResult Index()
        {
            var model = _db.ICESourceRole.ToList(); 
            return View(model);
        }
        [HttpGet]

        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICESourceRole select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.En_Role.Contains(searchString) || x.De_Role.Contains(searchString)); 
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }

        // GET: SourceRoleICE
        public ActionResult AddOrEdit(int id = 0)
        {
            ICESourceRole model = new ICESourceRole();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddOrEdit(ICESourceRole userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.ICESourceRole.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new ICESourceRole());
        }
    }
}