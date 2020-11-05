using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.ICEControllers
{
    public class SourceEquipmentICEController : Controller
    {

        MohamedAzloukSandboxEntities8 _db; 
        public SourceEquipmentICEController()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: SourceEquipmentICE
        public ActionResult Index()
        {
            var model = _db.ICESourceEquipment.ToList();
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICESourceEquipment select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.Code.Contains(searchString)); 
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
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
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