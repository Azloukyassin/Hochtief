using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace UserReg.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(UserTab userModel)
        {
            using(MohamedAzloukSandboxEntities26 db = new MohamedAzloukSandboxEntities26())
            {
                var userDetails = db.UserTab.Where(x => x.Username == userModel.Username && x.password == userModel.password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = " Falsch Username oder Password";
                    return View("Index", userModel);
                }
                else 
                    return View("~/Views/Projects/Index.cshtml", userModel);
            }
        }
    }
}