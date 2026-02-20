using ECommerce_BigDataAnalytics.Repositories.Bar1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIBar1Component :ViewComponent

    {
        private readonly IBar1Repository _bar1Repository;

        public _UIBar1Component(IBar1Repository bar1Repository)
        {
            _bar1Repository = bar1Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bar1Repository.GetCountByStatusAsync();
            return View(values);
        }
    }
}
