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
    public class SourceEquipmentICEAdminController : Controller
    {
        ICEEntities _db;
        public SourceEquipmentICEAdminController()
        {
            _db = new ICEEntities();
        }
        // GET: SourceEquipmentICEAdmin
        public ActionResult Index()
        {
            var test = _db.ICESourceCompany.ToList();
            return View(test);
        }
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["GetDetails"] = searchString;
            var modelquery = from x in _db.ICESourceEquipment select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceEquipmentICEAdmin
        public ActionResult Update()
        {
            ICESourceEquipment model = new ICESourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, ICESourceEquipment model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var neumodel = entities.ICESourceEquipment.Where(x => x.SourceEquipment == id).FirstOrDefault();

                neumodel.SourceEquipment = model.SourceEquipment;
                neumodel.Code = model.Code;
                neumodel.De_Equipment = model.De_Equipment;
                neumodel.En_Equipment = model.En_Equipment;
                return View("Update", new ICESourceEquipment());
            }
        }
        // GET: SourceEquipmentICEAdmin
        public ActionResult Delete()
        {
            ICESourceEquipment model = new ICESourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, ICESourceEquipment model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var data = (from x in entities.ICESourceEquipment
                            where x.SourceEquipment == id
                            select x).FirstOrDefault();
                entities.ICESourceEquipment.Remove(data);
                entities.SaveChanges();

                return View("Delete", new ICESourceEquipment());
            }
        }
    }
}
