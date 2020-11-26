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
    public class LabourA40AdminController : Controller
    {
        A40Entities _db;
        public LabourA40AdminController()
        {
            _db = new A40Entities();
        }
        // GET: LabourA40Admin
        public ActionResult Index()
        {
            var test = _db.A40Labour.ToList();
            return View(test);
        }
        [HttpGet]
        public async Task <ActionResult> Index(String searchString)
        {
            ViewData["Getdetails"] = searchString;
            var modelquery = from x in _db.A40Labour select x;
            if(!String.IsNullOrEmpty(searchString))
            {
                modelquery = modelquery.Where(x => x.Fullname.Contains(searchString) || x.Firstname.Contains(searchString) || x.Lastname.Contains(searchString) || x.Area.Contains(searchString) || x.Comment.Contains(searchString) || x.Company.Contains(searchString) || x.Position.Contains(searchString)); 
            }
            return View(await modelquery.AsNoTracking().ToListAsync()); 
        }
        // GET: LabourA40Admin
        public ActionResult Update()
        {
            A40Labour model = new A40Labour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(int id, A40Labour model)
        {
            using (A40Entities entities = new A40Entities())
            {
                var neumodel = entities.A40Labour.Where(x => x.Labour_id == id).FirstOrDefault();
                neumodel.Firstname = model.Firstname;
                neumodel.Lastname = model.Lastname;
                neumodel.Fullname = model.Fullname;
                neumodel.Labour_id = model.Labour_id;
                neumodel.Position = model.Position;
                neumodel.Comment = model.Comment;
                neumodel.Company = model.Company;
                entities.SaveChanges();
                return View("Update", new A40Labour());
            }
        }
        // Delete Methode is Done 
        // GET: LabourA40Admin
        public ActionResult Delete()
        {
            A40Labour model = new A40Labour();
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id, A40Labour model)
        {
            using (A40Entities entities = new A40Entities())
            {
                var data = (from x in entities.A40Labour
                            where x.Labour_id == id
                            select x).FirstOrDefault();
                entities.A40Labour.Remove(data);
                entities.SaveChanges();
            }
                return View("Delete", new A40Labour());
         }
        }
    
}
