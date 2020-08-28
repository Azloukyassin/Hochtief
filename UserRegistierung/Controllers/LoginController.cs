using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            using (MohamedAzloukSandboxEntities db = new MohamedAzloukSandboxEntities())
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