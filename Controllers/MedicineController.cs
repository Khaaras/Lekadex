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
    public class MedicineController : Controller
    {        

        public MedicineController()
        {

        }

        public IActionResult Index(int indexOfDoctor, int indexOfPrescription)
        {
            return View(TestDataBasePleaseDelete.Doctors.ElementAt(indexOfDoctor).Prescriptions.ElementAt(indexOfPrescription));
        }

        public IActionResult Delete(int indexOfMedicine)
        {
            return View();
        }

    }  
}
