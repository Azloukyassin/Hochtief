using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A40Controllers
{
    public class SourceEquipmentA40Controller : Controller
    {

        MohamedAzloukSandboxEntities8 _db; 
        public SourceEquipmentA40Controller()
        {
            _db = new MohamedAzloukSandboxEntities8();
        }
        // GET: SourceEquipmentA40
        public ActionResult Index()
        {
            var model = _db.A40SourceEquipment.ToList();
            return View(model);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.A40SourceEquipment select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Equipment.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.Code.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET. SourceEquipmentA40 
        public ActionResult AddOrEdit(int id=0)
        {
            A40SourceEquipment a40SourceEquipment = new A40SourceEquipment();
            return View(a40SourceEquipment); 
        }

        [HttpPost]
        public ActionResult AddOrEdit(A40SourceEquipment a40SourceEquipment)
        {
            using(MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.A40SourceEquipment.Add(a40SourceEquipment);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = " Registration Successful"; 
            return View("AddOrEdit" , new A40SourceEquipment()); 
        }
    }
}