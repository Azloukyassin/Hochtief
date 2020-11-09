using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceEquipmentMBDController : Controller
    {
        // GET: SourceEquipmentMBD
        MBDEntities _db;
        public SourceEquipmentMBDController()
        {
            _db = new MBDEntities();
        }
        // GET: SourceEquipmentMBD
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
        // GET: SourceEquipmentMBD
        public ActionResult AddOrEdit(int id = 0)
        {
            MDBSourceEquipment usermodel = new MDBSourceEquipment();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBSourceEquipment userModel)
        {
            using (MBDEntities model = new MBDEntities())
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