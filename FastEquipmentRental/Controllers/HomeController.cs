
using Microsoft.AspNetCore.Mvc;

namespace FastEquipmentRental.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}