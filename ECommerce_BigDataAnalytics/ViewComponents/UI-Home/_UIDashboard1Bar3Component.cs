using ECommerce_BigDataAnalytics.Repositories.Bar2Repositories;
using ECommerce_BigDataAnalytics.Repositories.Bar3Repositories;
using ECommerce_BigDataAnalytics.Repositories.TableRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard1Bar3Component : ViewComponent
    {
        private readonly IBar3Repository _bar3Repository;

        public _UIDashboard1Bar3Component(IBar3Repository bar3Repository)
        {
            _bar3Repository = bar3Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _bar3Repository.GetCategoryRevenueAsync();
            return View(data);
        }
    }
}
