using ECommerce_BigDataAnalytics.Extensions;
using ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard2City2MapComponent : ViewComponent
    {
        private readonly ICountyWidgetRepository _widgetRepository;

        public _UIDashboard2City2MapComponent(ICountyWidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }

   
         public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _widgetRepository.GetCityAsync();

            return View(values);
        }
    
    }
}
