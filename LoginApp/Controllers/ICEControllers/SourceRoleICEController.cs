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
    public class SourceRoleICEController : Controller
    {
        ICEEntities _db;
        public SourceRoleICEController()
        {
            _db = new ICEEntities();
        }
        // GET: SourceRoleICE
        public ActionResult Index()
        {
            var test = _db.ICESourceRole.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(string searchString)
        {
            ViewData["Getdetais"] = searchString;
            var modelquery = from x in _db.ICESourceRole select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Role.Contains(searchString) || x.De_Role.Contains(searchString) || x.Code.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceRoleICE   
        public ActionResult AddOrEdit(int id = 0)
        {
            ICESourceRole usermodel = new ICESourceRole();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(ICESourceRole userModel)
        {
            using (ICEEntities model = new ICEEntities())
            {
                model.ICESourceRole.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new ICESourceRole());
        }
    }
}