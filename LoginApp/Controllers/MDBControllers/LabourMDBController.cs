using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.MDBControllers
{
    public class LabourMDBController : Controller
    {
        MohamedAzloukSandboxEntities8 _db; 
        public LabourMDBController()
        {
            _db = new MohamedAzloukSandboxEntities8(); 
        }
        // GET: LabourMDB
        public ActionResult Index()
        {
            var model = _db.MDBLabour.ToList(); 
            return View(model);
        }
        [HttpGet]
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery= from x in _db.MDBLabour select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Firstname.Contains(searchString) || x.Fullname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Position.Contains(searchString) || x.Area.Contains(searchString) || x.Comment.Contains(searchString) || x.Company.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }

        // GET: LabourMDB
        public ActionResult AddOrEdit(int id =0)
        {
            MDBLabour mDBLabour = new MDBLabour();
            return View(mDBLabour); 
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBLabour userModel)
        {
            using (MohamedAzloukSandboxEntities8 model = new MohamedAzloukSandboxEntities8())
            {
                model.MDBLabour.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new MDBLabour());
        }
    }
}