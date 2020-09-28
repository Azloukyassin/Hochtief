using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class EntreController : Controller
    {
        // GET: Entre
        public IActionResult Index()
        {
            return View();
        }
    }
}