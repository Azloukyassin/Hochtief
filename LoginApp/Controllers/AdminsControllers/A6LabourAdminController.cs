using LoginApp.Models.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.AdminsControllers.A6Controllers
{
    public class A6LabourAdminController : Controller
    {

        private readonly IRepostory<A6Labourtest> testRepostory;
        // GET: A6LabourAdmin
        public ActionResult Index()
        {
            var test = testRepostory.List();
            return View(test);
        }

        // GET: A6LabourAdmin/Details/5
        public ActionResult Details(int id)
        {
            var ob = testRepostory.Find(id);
            return View(ob);
        }

        // GET: A6LabourAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: A6LabourAdmin/Create
        [HttpPost]
        public ActionResult Create(A6Labourtest test)
        {
            try
            {
                testRepostory.Add(test);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: A6LabourAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            var ob = testRepostory.Find(id);
            return View(ob);
        }

        // POST: A6LabourAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, A6Labourtest test)
        {
            try
            {
                testRepostory.Update(id, test);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: A6LabourAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            var ob = testRepostory.Find(id);
            return View(ob);
        }

        // POST: A6LabourAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, A6Labourtest test)
        {
            try
            {
                testRepostory.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
