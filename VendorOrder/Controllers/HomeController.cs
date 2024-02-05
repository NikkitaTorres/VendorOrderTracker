using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}