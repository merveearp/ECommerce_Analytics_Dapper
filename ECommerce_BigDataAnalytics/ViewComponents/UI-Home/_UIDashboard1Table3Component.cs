using ECommerce_BigDataAnalytics.Repositories.PieChart1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents
{
    public class _UIDashboard1Table3Component :ViewComponent
    {
        private readonly IPieChart1Repository _pieChart1Repository;

        public _UIDashboard1Table3Component(IPieChart1Repository pieChart1Repository)
        {
            _pieChart1Repository = pieChart1Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _pieChart1Repository.GetProductsCountByCategory();
            var topValues = values.OrderByDescending(x => x.ProductCount).Take(10).ToList();
            return View(topValues);
        }
    }
}
