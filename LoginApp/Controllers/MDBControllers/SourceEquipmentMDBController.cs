using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.MDBControllers
{
    public class SourceEquipmentMDBController : Controller
    {
        MohamedAzloukSandboxEntities8 _db;
        public SourceEquipmentMDBController()
        {
            _db = new MohamedAzloukSandboxEntities8();
        }

        // GET: SourceEquipmentMDB
        public ActionResult Index()
        {
            var test = _db.MDBSourceEquipment.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.MDBSourceEquipment select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }

        // GET: SourceEquipmentMDB
        public ActionResult AddOrEdit(int id = 0)
        {
            MDBSourceEquipment usermodel = new MDBSourceEquipment();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBSourceEquipment userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.MDBSourceEquipment.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new MDBSourceEquipment());
        }
    }
}