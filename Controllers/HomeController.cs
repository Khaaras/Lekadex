using Lekadex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lekadex.Controllers
{
    public class HomeController : Controller
    {
        
        
        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View(TestDataBasePleaseDelete.Doctors);
        }

        public IActionResult View(int indexOfDoctor)
        {
            //return RedirectToAction("Index", "Prescription", TestDataBasePleaseDelete.Doctors.ElementAt(indexOfDoctor));

            return RedirectToAction("Index", "Prescription", new { indexOfDoctor = indexOfDoctor });
        }

        public IActionResult Delete(int indexOfDoctor)
        {
            return View(TestDataBasePleaseDelete.Doctors);
        }
    }
}
 