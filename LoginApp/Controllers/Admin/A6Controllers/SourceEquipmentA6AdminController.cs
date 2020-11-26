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
    public class SourceEquipmentA6AdminController : Controller
    {
        MohamedAzloukSandboxEntitiesA6 _db;
        public SourceEquipmentA6AdminController()
        {
            _db = new MohamedAzloukSandboxEntitiesA6();
        }
        // GET: SourceEquipmentA6Admin
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
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.codeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceEquipmentAdmin
        public ActionResult Update()
        {
            A6SourceEquipmenttest model = new A6SourceEquipmenttest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A6SourceEquipmenttest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                var neumodel = entitiesA6.A6SourceEquipmenttest.Where(x => x.sourceEq_id == id).FirstOrDefault();
                neumodel.sourceEq_id = model.sourceEq_id;
                neumodel.Code = model.Code;
                neumodel.De_Equipment = model.De_Equipment;
                neumodel.En_Equipment = model.En_Equipment;
                return View("Update", new A6SourceEquipmenttest());
            }
        }
        // GET: SourceEquipmentA6Admin
        public ActionResult Delete()
        {
            A6SourceEquipmenttest model = new A6SourceEquipmenttest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A6SourceEquipmenttest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                var data = (from x in entitiesA6.A6SourceEquipmenttest
                            where x.sourceEq_id == id
                            select x).FirstOrDefault();
                entitiesA6.A6SourceEquipmenttest.Remove(data);
                entitiesA6.SaveChanges();
            }
                return View("Delete", new A6SourceEquipmenttest());
            
        }
    }
}
