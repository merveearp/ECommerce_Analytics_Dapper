using ECommerce_BigDataAnalytics.Repositories.Bar2Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard1Bar2Component :ViewComponent
    {
        private readonly IBar2Repository _bar2Repository;

        public _UIDashboard1Bar2Component(IBar2Repository bar2Repository)
        {
            _bar2Repository = bar2Repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bar2Repository.GetTopOrderCountCategory();

            ViewBag.CategoryName = values.Select(x => x.CategoryName).ToList();
            ViewBag.OrderCount = values.Select(x => x.OrderCount).ToList();
            return View();
        }
    }
}
