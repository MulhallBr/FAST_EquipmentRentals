
using Microsoft.AspNetCore.Mvc;
using FastEquipmentRental.Models;

namespace FastEquipmentRental.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(EquipmentRequest equipmentRequest)
        {
            // Store requests from users
            Repository.AddRequest(equipmentRequest);
            return View("Confirmation", equipmentRequest);
        }
    }
}