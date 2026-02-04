
using ECommerce_BigDataAnalytics.Context;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ECommerce_BigDataAnalytics.Controllers
{
    public class HomeController: Controller
    {
           
        public IActionResult Index()
        {

            return View();
        }

       
    }
}
