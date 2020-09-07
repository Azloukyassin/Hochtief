using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginApp.Models;

namespace UserReg.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        // muss nachschauen 
        [HttpPost]
        public ActionResult Autherize(UserTab userModel)
        {
            using(MohamedAzloukSandboxEntities db = new MohamedAzloukSandboxEntities())
            {
                var userDetails = db.UserTab.Where(x => x.Username == userModel.Username && x.password == userModel.password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = " Falsch Username oder Password";
                    return View("Index", userModel);
                }
                else
                    return View("Projects", "Index"); 
            }
            //return View();
        }
    }
}