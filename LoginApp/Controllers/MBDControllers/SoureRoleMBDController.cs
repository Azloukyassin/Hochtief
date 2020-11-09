using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A6Controllers
{
    public class SourceRoleMBDController : Controller
    {

        MBDEntities _db;
        public SourceRoleMBDController()
        {
            _db = new MBDEntities();
        }
        // GET: SourceRoleMBD
        public ActionResult Index()
        {
            var test = _db.MDBSourceRole.ToList();
            return View(test);
        }

        [HttpGet]
        public async Task<ActionResult> Index(string searchString)
        {

            ViewData["Getdetais"] = searchString;
            var modelquery = from x in _db.MDBSourceRole select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Role.Contains(searchString) || x.De_Role.Contains(searchString) || x.Code.Contains(searchString));
            }

            return View(await modelquery.AsNoTracking().ToListAsync());

        }


        // GET: SourceRoleMBD 
        public ActionResult AddOrEdit(int id = 0)
        {
            MDBSourceRole usermodel = new MDBSourceRole();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(MDBSourceRole userModel)
        {
            using (MBDEntities model = new MBDEntities())
            {
                model.MDBSourceRole.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new MDBSourceRole());
        }
    }
}