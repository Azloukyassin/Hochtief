using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class SourceCompanyA6AdminController : Controller
    {
        MohamedAzloukSandboxEntitiesA6 _db; 

        public SourceCompanyA6AdminController()
        {
            _db = new MohamedAzloukSandboxEntitiesA6(); 
        }
        // GET: SourceCompanyA6Admin
        public ActionResult Index()
        {
            var test = _db.A6SourceCompanytest.ToList();
            return View(test);
        }
        // GET: SourceCompanyA6Admin
        public ActionResult Update()
        {
            A6SourceCompanytest model = new A6SourceCompanytest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id ,A6SourceCompanytest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if(model.sourceCompany_id == id)
                {
                    entitiesA6.A6SourceCompanytest.Add(model);
                    entitiesA6.SaveChanges();
                }
                return View("Update", new A6SourceCompanytest()); 
            }
        }

        // GET: SourceCompanyA6Admin
        public ActionResult Delete()
        {
            A6SourceCompanytest model = new A6SourceCompanytest();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A6SourceCompanytest model)
        {
            using (MohamedAzloukSandboxEntitiesA6 entitiesA6 = new MohamedAzloukSandboxEntitiesA6())
            {
                if (model.sourceCompany_id == id)
                {
                    entitiesA6.A6SourceCompanytest.Remove(model);
                    entitiesA6.SaveChanges();
                }
                return View("Delete", new A6SourceCompanytest());
            }
        }



    }
}
