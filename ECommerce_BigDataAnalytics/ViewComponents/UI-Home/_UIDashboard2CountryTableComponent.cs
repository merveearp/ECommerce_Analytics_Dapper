using ECommerce_BigDataAnalytics.Extensions;
using ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard2CountryTableComponent : ViewComponent
    {
        private readonly ICountyWidgetRepository _widgetRepository;

        public _UIDashboard2CountryTableComponent(ICountyWidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }

   
         public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _widgetRepository.GetCountryCustomer();

            return View(values);
        }
    
    }
}
