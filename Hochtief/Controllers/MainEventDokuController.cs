using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hochtief.Models;
using Hochtief.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hochtief.Controllers
{
    public class MainEventDokuController : Controller
    {
        private readonly IRepostory<MainEventDoku> testRepostory;

        public MainEventDokuController(IRepostory<MainEventDoku> TestRepostory)
        {
            this.testRepostory = TestRepostory;
        }
        // GET: Test
        public ActionResult Index()
        {
            var test = testRepostory.List();
            return View(test);
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            var ob = testRepostory.Find(id);
            return View(ob);
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MainEventDoku test)
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

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            var ob = testRepostory.Find(id);
            return View(ob);
        }

        // POST: Test/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MainEventDoku test)
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

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            var ob = testRepostory.Find(id);
            return View(ob);
        }

        // POST: Test/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MainEventDoku test)
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
