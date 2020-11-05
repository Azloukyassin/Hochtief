using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.ICEControllers
{
    public class LabourICEController : Controller
    {
        MohamedAzloukSandboxEntities8 _db; 

        public LabourICEController()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: LabourICE
        public ActionResult Index()
        {
            var model = _db.ICELabour.ToList(); 
            return View(model);
        }
        [HttpGet]
        public async Task <ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
           var  modelquery = from x in _db.ICELabour select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Area.Contains(searchString) || x.Comment.Contains(searchString) || x.Company.Contains(searchString) || x.Firstname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Position.Contains(searchString)); 
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET: LabourICE 
        public ActionResult AddOrEdit(int id=0)
        {
            ICELabour iCELabour = new ICELabour();
            return View(iCELabour); 
        }

        [HttpPost]
        public ActionResult AddOrEdit(ICELabour iCELabour)
        {
            using(MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.ICELabour.Add(iCELabour);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registartion Successful";
            return View("AddOrEdit", new ICELabour()); 
        }
    }
}