using ECommerce_BigDataAnalytics.Repositories.DoughnutChart1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDoughnetChart1Component : ViewComponent
    {
        private readonly IDoughnutChart1Repository _chart2Repository;

        public _UIDoughnetChart1Component(IDoughnutChart1Repository chart2Repository)
        {
            _chart2Repository = chart2Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _chart2Repository.GetOrdersCountByOrderStatus();
            return View(values);
        }
    
    }
}
