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
    public class SourceRoleICEAdminController : Controller
    {
        ICEEntities _db;
        public SourceRoleICEAdminController()
        {
            _db = new ICEEntities();
        }
        // GET: SourceRoleICEAdmin
        public ActionResult Index()
        {
            var test = _db.ICESourceRole.ToList();
            return View(test);
        }
        public async Task<ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.ICESourceRole select x; 
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Code.Contains(searchString) || x.De_Role.Contains(searchString) || x.En_Role.Contains(searchString)); 
            }

            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: SourceRoleICEAdmin
        public ActionResult Update()
        {
            ICESourceRole model = new ICESourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, ICESourceRole model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var neumodel = entities.ICESourceRole.Where(x => x.Source_id == id).FirstOrDefault();

                neumodel.Source_id = model.Source_id;
                neumodel.Code = model.Code;
                neumodel.De_Role = model.De_Role;
                neumodel.En_Role = model.En_Role;
                return View("Update", new ICESourceRole());
            }
        }
        // GET: SourceRoleICEAdmin
        public ActionResult Delete()
        {
            ICESourceRole model = new ICESourceRole();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, ICESourceRole model)
        {
            using (ICEEntities entities = new ICEEntities())
            {
                var data = (from x in entities.ICESourceRole
                            where x.Source_id == id
                            select x).FirstOrDefault();
                entities.ICESourceRole.Remove(data);
                entities.SaveChanges(); 

                return View("Delete", new ICESourceRole());
            }
        }
    }
}
