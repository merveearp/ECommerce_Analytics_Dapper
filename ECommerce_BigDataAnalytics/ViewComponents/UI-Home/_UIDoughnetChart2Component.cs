using ECommerce_BigDataAnalytics.Repositories.DoughnutChart2Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDoughnetChart2Component :ViewComponent
    {
        private readonly IDoughnut2Repository _doughnut2Repository;

        public _UIDoughnetChart2Component(IDoughnut2Repository doughnut2Repository)
        {
            _doughnut2Repository = doughnut2Repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _doughnut2Repository.GetStockFromCategory();
            return View(values);
        }
    }
}
