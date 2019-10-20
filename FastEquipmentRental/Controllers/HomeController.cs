using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FastEquipmentRental.Models;
using System.Linq;

namespace FastEquipmentRental.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(EquipmentRequest equipmentRequest)
        {
            if (ModelState.IsValid)
            {
                // Store requests from users
                Repository.AddRequest(equipmentRequest);
                return View("Confirmation", equipmentRequest);
            } else
            {
                return View();
            }
        }

        public IActionResult AllEquipment()
        {
            return View(Repository.Equipments);
        }

        public IActionResult AvailableEquipment()
        {
            return View(Repository.Equipments.Where(e => e.Availability == true));
        }

        public IActionResult Requests()
        {
            return View(Repository.Requests);
        }

        public IActionResult RequestDetails()
        {
            return View();
        }
    }
}