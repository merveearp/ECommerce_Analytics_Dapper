using ECommerce_BigDataAnalytics.Repositories.Line2Repositories;
using ECommerce_BigDataAnalytics.Repositories.Line3Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UILine3Component : ViewComponent
    {
        private readonly ILine3Repository _line3Repository;

        public _UILine3Component(ILine3Repository line3Repository)
        {
            _line3Repository = line3Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _line3Repository.GetTotalAmountByMountly();
            return View(values);
        }
    }
}
