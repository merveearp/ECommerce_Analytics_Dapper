using ECommerce_BigDataAnalytics.Repositories.PieChart1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIPieChart1Component :ViewComponent
    {
        private readonly IPieChart1Repository _chart1Repository;

        public _UIPieChart1Component(IPieChart1Repository chart1Repository)
        {
            _chart1Repository = chart1Repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _chart1Repository.GetProductsCountByCategory();
            return View(values);
        }
    }
}
