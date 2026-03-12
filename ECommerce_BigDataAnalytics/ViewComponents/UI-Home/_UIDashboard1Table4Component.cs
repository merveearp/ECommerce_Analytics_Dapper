using ECommerce_BigDataAnalytics.Repositories.Bar2Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard1Table4Component :ViewComponent
    {
        private readonly IBar2Repository _bar2Repository;

        public _UIDashboard1Table4Component(IBar2Repository bar2Repository)
        {
            _bar2Repository = bar2Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bar2Repository.GetTotalAmountCategory();
            return View(values);
        }
    }
}
