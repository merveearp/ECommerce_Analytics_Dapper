using ECommerce_BigDataAnalytics.Repositories.DoughnutChart1Repositories;
using ECommerce_BigDataAnalytics.ViewComponents.UI_Home;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UITable1Component :ViewComponent
    {
        private readonly IDoughnutChart1Repository _chart1Repository;

        public _UITable1Component(IDoughnutChart1Repository chart1Repository)
        {
            _chart1Repository = chart1Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _chart1Repository.GetOrdersCountByOrderStatus2();

            var value = await _chart1Repository.GetOrdersCountByTotal();
            ViewBag.Total = value;
            return View(values);
        }
    }
}


