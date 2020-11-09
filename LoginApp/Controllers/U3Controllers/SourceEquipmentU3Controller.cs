using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceEquipmentU3Controller : Controller
    {
        // GET: SourceEquipmentU3
        MohamedAzloukSandboxEntities10 _db;
        public SourceEquipmentU3Controller()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: SourceEquipmentU3
        public ActionResult Index()
        {
            var test = _db.U3SourceEquipment.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.U3SourceEquipment select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceEquipmentU3
        public ActionResult AddOrEdit(int id = 0)
        {
            U3SourceEquipment usermodel = new U3SourceEquipment();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(U3SourceEquipment userModel)
        {
            using (MohamedAzloukSandboxEntities10 model = new MohamedAzloukSandboxEntities10())
            {
                model.U3SourceEquipment.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new U3SourceEquipment());
        }
    }
}