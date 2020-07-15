using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hochtief.Controllers
{
    //noch bei Testing ! 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
