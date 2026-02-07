using ECommerce_BigDataAnalytics.Repositories.Line2Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UILine2Component : ViewComponent
    {
        private readonly ILine2Repository _line2Repository;

        public _UILine2Component(ILine2Repository line2Repository)
        {
            _line2Repository = line2Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _line2Repository.GetOrderCountByMonthly();
            return View(values);
        }
    }
}
