using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TempleProject.Models;

namespace TempleProject.Controllers
{
    public class HomeController : Controller
    {
        private TempleApplicationContext templeContext { get; set; }
       
        public HomeController(TempleApplicationContext temple)
        {
            templeContext = temple;
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
            templeContext.Add(ar);
            templeContext.SaveChanges();
            return View("TempleList");
        }

        public IActionResult ScheduledAppointments ()
        {
            var appointments = templeContext.Responses.ToList();

            return View(appointments);
        }

        [HttpGet]
        public IActionResult TempleList()
        {
            var applications = templeContext.Responses
                .Include(x => x.Time)
                .ToList();


            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int appointmentid)
        {
            ViewBag.Time = templeContext.times.ToList();

            var application = templeContext.Responses.Single(x => x.AppointmentID == appointmentid);

            return View("ScheduleForm", application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse mv)
        {
            templeContext.Update(mv);
            templeContext.SaveChanges();

            return RedirectToAction("TempleList");
        }


        [HttpGet]
        public IActionResult Delete(int applicationid)
        {

            var application = templeContext.Responses.Single(x => x.AppointmentID == applicationid);

            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse mv)
        {
            templeContext.Responses.Remove(mv);
            templeContext.SaveChanges();

            return RedirectToAction("TempleList");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            var times = templeContext.times
                .Where(t => t.IsTaken == false)
                .ToList();

            return View(times);
        }

    }
}
