using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
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
        public ActionResult Autherize(Usertest userModel)
        {
            using (MohamedAzloukSandboxEntities db = new MohamedAzloukSandboxEntities())
            {
                var userDetails = db.Usertest.Where(x => x.username== userModel.username && x.password == userModel.password).FirstOrDefault();
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