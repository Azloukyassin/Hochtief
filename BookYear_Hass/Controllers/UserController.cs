using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookYear_Hass.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddOrEdit(int id = 0)
        {
            UserTable userModel = new UserTable();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(UserTable userModel)
        {
            using (BookYear model = new BookYear())
            {
                model.UserTable.Add(userModel);
                model.SaveChanges();
                //model.SaveChangesAsync(); 
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful ";
            return View("AddOrEdit", new UserTable());
        }
    }
}
