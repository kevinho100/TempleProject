using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TempleProject.Models;

namespace TempleProject.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
        // this is to go to the form 
        [HttpGet]
        public IActionResult ScheduleForm ()
        {
            return View();
        }
        // Need to change this eventually to go to the right page after you submit the form
        [HttpPost]
        public IActionResult ScheduleForm (ApplicationResponse ar)
        {
            return View();
        }
       
    }
}
