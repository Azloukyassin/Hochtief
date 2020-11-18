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
    public class SourceEquipmentMBDAdminController : Controller
    {
        MBDEntities _db;

        public SourceEquipmentMBDAdminController()
        {
            _db = new MBDEntities();
        }
        // GET: SourceEquipmentMBDAdmin
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
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.CodeCompany.Contains(searchString) || x.De_Equipment.Contains(searchString) || x.En_Equipment.Contains(searchString)); 
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceEquipmentMBDAdmin
        public ActionResult Update()
        {
            MDBSourceEquipment model = new MDBSourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, MDBSourceEquipment model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                if (model.SourceEquipment == id)
                {
                    entities.MDBSourceEquipment.Add(model);
                    entities.SaveChanges();
                }
                return View("Update", new MDBSourceEquipment());
            }
        }

        // GET: SourceEquipmentMBDAdmin
        public ActionResult Delete()
        {
            MDBSourceEquipment model = new MDBSourceEquipment();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, MDBSourceEquipment model)
        {
            using (MBDEntities entities = new MBDEntities())
            {
                if (model.SourceEquipment == id)
                {
                    entities.MDBSourceEquipment.Remove(model);
                    entities.SaveChanges();
                }
                return View("Delete", new MDBSourceEquipment());
            }
        }



    }
}
