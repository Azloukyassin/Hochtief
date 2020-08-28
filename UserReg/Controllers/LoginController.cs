using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserReg.Models;
using UserRegistierung;

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
            using (MohamedAzloukSandboxEntities1 db = new MohamedAzloukSandboxEntities1())
            {
                var userDetails = db.UserTab.Where(x => x.Username == userModel.Username && x.Password == userModel.Password).FirstOrDefault();
                if(userDetails==null)
                {
                    return View("Login","Index", userModel);
                }
            }
            return View();
        }
    }
}