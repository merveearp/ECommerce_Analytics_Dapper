using ECommerce_BigDataAnalytics.Repositories.Bar4Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIBar4Component :ViewComponent
    {
        private readonly IBar4Repository _bar4Repository;

        public _UIBar4Component(IBar4Repository bar4Repository)
        {
            _bar4Repository = bar4Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bar4Repository.GetStockSalesAnalysis();
            return View(values);
        }
    }
}
