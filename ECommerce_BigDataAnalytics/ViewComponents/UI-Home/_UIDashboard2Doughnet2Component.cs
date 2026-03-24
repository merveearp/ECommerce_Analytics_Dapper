using ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard2Doughnet2Component : ViewComponent
    {
        private readonly ICountyWidgetRepository _widgetRepository;

        public _UIDashboard2Doughnet2Component(ICountyWidgetRepository widgetRepository)
        {
            _widgetRepository = widgetRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _widgetRepository.GetOrderByCountryAsync();

            return View(values);
        }
    }
}
