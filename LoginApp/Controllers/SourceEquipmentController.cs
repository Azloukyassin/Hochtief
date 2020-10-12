using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class SourceEquipmentController : Controller
    {
        // GET: SourceEquipment
        public ActionResult AddOrEdit(int id = 0)
        {
            SourceEquipmenttest userModel = new SourceEquipmenttest();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(SourceEquipmenttest userModel)
        {
            using (MohamedAzloukSandboxTest model = new MohamedAzloukSandboxTest())
            {
                model.SourceEquipmenttest.Add(userModel);
                model.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new SourceEquipmenttest());
        }
    }
}