using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceEquipmentICEController : Controller
    {
        // GET: SourceEquipmentICE
        ICEEntities _db;
        public SourceEquipmentICEController()
        {
            _db = new ICEEntities();
        }
        // GET: SourceEquipmentICE
        public ActionResult Index()
        {
            var test = _db.ICESourceEquipment.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICESourceEquipment select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceEquipmentICE
        public ActionResult AddOrEdit(int id = 0)
        {
            ICESourceEquipment usermodel = new ICESourceEquipment();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(ICESourceEquipment userModel)
        {
            using (ICEEntities model = new ICEEntities())
            {
                model.ICESourceEquipment.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new ICESourceEquipment());
        }
    }
}