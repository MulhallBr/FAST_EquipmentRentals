using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FastEquipmentRental.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Diagnostics;

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
            var x = new EquipmentRequest();
            x.Types = new List<SelectListItem>
            {
                new SelectListItem {Text = "Laptop", Value = "Laptop"},
                new SelectListItem {Text = "Tablet", Value = "Tablet"},
                new SelectListItem {Text = "Phone", Value = "Phone"},
                new SelectListItem {Text = "Other", Value = "Other"}
            };

            return View(x);
        }

        [HttpPost]
        public IActionResult RequestForm(EquipmentRequest equipmentRequest)
        {
            Debug.WriteLine("Checking");
            Debug.WriteLine(equipmentRequest.EqType);
            if (ModelState.IsValid)
            {
                // Store requests from users
                Debug.WriteLine("Request Being Added");
                Repository.AddRequest(equipmentRequest);
                return View("Confirmation", equipmentRequest);
            } else
            {
                var x = new EquipmentRequest();
                x.Types = new List<SelectListItem>
                {
                    new SelectListItem {Text = "Laptop", Value = "Laptop"},
                    new SelectListItem {Text = "Tablet", Value = "Tablet"},
                    new SelectListItem {Text = "Phone", Value = "Phone"},
                    new SelectListItem {Text = "Other", Value = "Other"}
                };

                return View(x);
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

        public IActionResult RequestDetails(int id)
        {
            return View(Repository.Requests.Where(r => r.Id == id));
        }
    }
}