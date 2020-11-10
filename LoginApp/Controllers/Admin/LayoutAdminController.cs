using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.Admin
{
    public class LayoutAdminController : Controller
    {
        // GET: LayoutAdmin
        public ActionResult Index()
        {
            return View();
        }
        // GET: LayoutAdmin
        public ActionResult FirstPage()
        {
            return View(); 
        }
    }
}