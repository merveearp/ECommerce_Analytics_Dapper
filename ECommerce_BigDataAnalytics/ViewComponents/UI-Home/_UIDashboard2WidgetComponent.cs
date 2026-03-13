using ECommerce_BigDataAnalytics.Extensions;
using ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard2WidgetComponent:ViewComponent
    {
        private readonly ICountyWidgetRepository _widgetRepository;

        public _UIDashboard2WidgetComponent(ICountyWidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }

   
         public async Task<IViewComponentResult> InvokeAsync()
        {
            var topCountry = await _widgetRepository.GetTopCountry();
            var topOrderCountry = await _widgetRepository.GetTopOrderCountry();

            ViewBag.TopCountryName = topCountry.CountryName;
            ViewBag.TopCountryRevenue = topCountry.TotalRevenue.ToShortMoney();

            ViewBag.CountCountry = await _widgetRepository.GetCountryCount();
            ViewBag.CountCity = await _widgetRepository.GetCityCount();

            ViewBag.TopOrderCountryName = topOrderCountry.CountryName;
            ViewBag.TopOrderCount = topOrderCountry.OrderCount;

            return View();
        }
    
    }
}
