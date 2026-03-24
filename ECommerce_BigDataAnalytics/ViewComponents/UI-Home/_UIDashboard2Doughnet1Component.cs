using ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories;
using ECommerce_BigDataAnalytics.Repositories.Widget1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard2Doughnet1Component : ViewComponent
    {
        private readonly ICountyWidgetRepository _widgetRepository;

        public _UIDashboard2Doughnet1Component(ICountyWidgetRepository widgetRepository)
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
