using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers.A40Controllers
{
    public class LayoutA40Controller : Controller
    {
       
        // GET: LayoutA40
        public ActionResult Index()
        {
            return View();
        }
        // GET: LayoutA40/List
        public ActionResult List()
        {
            return View(); 
        }
    }
}