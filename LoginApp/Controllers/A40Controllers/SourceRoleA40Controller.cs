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
    public class SourceRoleA40Controller : Controller
    {
        A40Entities _db;
        public SourceRoleA40Controller()
        {
            _db = new A40Entities();
        }
        // GET: SourceRoleA40
        public ActionResult Index()
        {
            var test = _db.A40SourceRole.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task<ActionResult> Index(string searchString)
        {
            ViewData["Getdetais"] = searchString;
            var modelquery = from x in _db.A40SourceRole select x;
            if (!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.En_Role.Contains(searchString) || x.De_Role.Contains(searchString) || x.Code.Contains(searchString));
            }
            return View(await modelquery.AsNoTracking().ToListAsync());
        }
        // GET: SourceRoleA40
        public ActionResult AddOrEdit(int id = 0)
        {
            A40SourceRole usermodel = new A40SourceRole();
            return View(usermodel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(A40SourceRole userModel)
        {
            using (A40Entities model = new A40Entities())
            {
                model.A40SourceRole.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new A40SourceRole());
        }
    }
}