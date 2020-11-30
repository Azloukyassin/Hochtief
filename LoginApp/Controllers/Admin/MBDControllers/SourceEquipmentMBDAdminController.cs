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
        // GET: SourceEquimentMBDAdmin 
        public ActionResult Create(int id =0)
        {
            MDBSourceEquipment mDBSourceEquipment = new MDBSourceEquipment();
            return View(mDBSourceEquipment); 
        }
        [HttpPost]
        public ActionResult Create(MDBSourceEquipment mDBSourceEquipment)
        {
            using(MBDEntities entitie = new MBDEntities())
            {
                entitie.MDBSourceEquipment.Add(mDBSourceEquipment);
                entitie.SaveChanges(); 
            }
            ModelState.Clear();
            ViewBag.SucessMessage = "Registration Successful";
            return View("Create", new MDBSourceEquipment()); 
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
                var neumodel = entities.MDBSourceEquipment.Where(x => x.SourceEquipment == id).FirstOrDefault();

                neumodel.SourceEquipment = model.SourceEquipment;
                neumodel.Code = model.Code;
                neumodel.De_Equipment = model.De_Equipment;
                neumodel.En_Equipment = model.En_Equipment;
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
                var data = (from x in entities.MDBSourceEquipment
                            where x.SourceEquipment == id
                            select x).FirstOrDefault();
                entities.MDBSourceEquipment.Remove(data);
                entities.SaveChanges();
            }
                return View("Delete", new MDBSourceEquipment());   
        }
    }
}
