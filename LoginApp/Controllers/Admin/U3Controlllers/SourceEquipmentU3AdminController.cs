using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceEquipmentU3AdminController : Controller
    {
        MohamedAzloukSandboxEntities10 _db;
        public SourceEquipmentU3AdminController()
        {
            _db = new MohamedAzloukSandboxEntities10();
        }
        // GET: SourceEquipmentU3Admin
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
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceEquipmentAdmin
        public ActionResult Update()
        {
            U3SourceEquipment model = new U3SourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, U3SourceEquipment model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                var neumodel = entities.U3SourceEquipment.Where(x => x.SourceEquipment == id).FirstOrDefault();
                neumodel.SourceEquipment = model.SourceEquipment;
                neumodel.Code = model.Code;
                neumodel.De_Equipment = model.De_Equipment;
                neumodel.En_Equipment = model.En_Equipment;
                return View("Update", new U3SourceEquipment());
            }
        }
        // GET: SourceEquipmentU3Admin
        public ActionResult Delete()
        {
            U3SourceEquipment model = new U3SourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, U3SourceEquipment model)
        {
            using (MohamedAzloukSandboxEntities10 entities = new MohamedAzloukSandboxEntities10())
            {
                var data = (from x in entities.U3SourceEquipment
                            where x.SourceEquipment == id
                            select x).FirstOrDefault();
                entities.U3SourceEquipment.Remove(data);
                entities.SaveChanges();
            }
                return View("Delete", new U3SourceEquipment());
        }
    }
}
