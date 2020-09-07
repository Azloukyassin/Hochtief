using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookYear_Hass.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult Autherize(UserTable userModel)
        {
            using (BookYear db = new BookYear())
            {
                var userDetails = db.UserTable.Where(x => x.Username == userModel.Username && x.password == userModel.password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = " Falsch Username oder Password";
                    return View("Index", userModel);
                }
                
            }
            return View();
        }
    }
}
