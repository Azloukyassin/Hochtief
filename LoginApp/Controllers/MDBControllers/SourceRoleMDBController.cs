using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.MDBControllers
{
    public class SourceRoleMDBController : Controller
    {
        
        MohamedAzloukSandboxEntities8 _db;
        public SourceRoleMDBController()
        {
            _db = new MohamedAzloukSandboxEntities8();
        }
        // GET: SourceRoleMDB
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
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Role.Contains(searchString) || x.De_Role.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceRoleMDB
        public ActionResult AddOrEdit(int id = 0)
        {
            MDBSourceRole usermodel = new MDBSourceRole();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBSourceRole userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.MDBSourceRole.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new MDBSourceRole());
        }
    }
}