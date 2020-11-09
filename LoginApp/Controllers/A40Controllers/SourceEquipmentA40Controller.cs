using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceEquipmentA40Controller : Controller
    {
        // GET: SourceEquipmentA40
        A40Entities _db;
        public SourceEquipmentA40Controller()
        {
            _db = new A40Entities();
        }
        // GET: SourceEquipmentA40
        public ActionResult Index()
        {
            var test = _db.A40SourceEquipment.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.A40SourceEquipment select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceEquipmentA40
        public ActionResult AddOrEdit(int id = 0)
        {
            A40SourceEquipment usermodel = new A40SourceEquipment();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A40SourceEquipment userModel)
        {
            using (A40Entities model = new A40Entities())
            {
                model.A40SourceEquipment.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A40SourceEquipment());
        }
    }
}