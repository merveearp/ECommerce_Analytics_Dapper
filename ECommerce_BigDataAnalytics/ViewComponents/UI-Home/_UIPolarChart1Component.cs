using ECommerce_BigDataAnalytics.Repositories.PieChart1Repositories;
using ECommerce_BigDataAnalytics.Repositories.PolarChartStatusRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIPolarChart1Component : ViewComponent
    {
        private readonly IPolarChartStatusRepository _chart2Repository;

        public _UIPolarChart1Component(IPolarChartStatusRepository chart2Repository)
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
