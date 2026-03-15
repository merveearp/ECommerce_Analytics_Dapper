using ECommerce_BigDataAnalytics.Extensions;
using ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard2AreaComponent : ViewComponent
    {
        private readonly ICountyWidgetRepository _widgetRepository;

        public _UIDashboard2AreaComponent(ICountyWidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }

   
         public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _widgetRepository.GetAmountOfCountry();

            ViewBag.CountryName = values.Select(x => x.CountryName);

            ViewBag.Revenue = values.Select(x => x.TotalAmount);

            return View();
        }
    
    }
}
