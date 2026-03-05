using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.Controllers
{
    public class Dashboard1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
