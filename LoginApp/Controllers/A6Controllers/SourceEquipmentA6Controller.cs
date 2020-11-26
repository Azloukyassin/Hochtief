using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceEquipmentA6Controller : Controller
    {
        // GET: SourceEquipmentA6
        MohamedAzloukSandboxEntitiesA6 _db;
        public SourceEquipmentA6Controller()
        {
            _db = new MohamedAzloukSandboxEntitiesA6();
        }
        // GET: SourceEquipmentA6
        public ActionResult Index()
        {
            var test = _db.A6SourceEquipmenttest.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.A6SourceEquipmenttest select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.codeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceEquipmentA6
        public ActionResult AddOrEdit(int id = 0)
        {
            A6SourceEquipmenttest usermodel = new A6SourceEquipmenttest();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A6SourceEquipmenttest userModel)
        {
            using (MohamedAzloukSandboxEntitiesA6 model = new MohamedAzloukSandboxEntitiesA6())
            {
                model.A6SourceEquipmenttest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A6SourceEquipmenttest());
        }
    }
}