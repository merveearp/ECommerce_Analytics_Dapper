
using ECommerce_BigDataAnalytics.Repositories.Line3Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UILine3ComponentV1 : ViewComponent
    {
        private readonly ILine3Repository _line3Repository;

        public _UILine3ComponentV1(ILine3Repository line3Repository)
        {
            _line3Repository = line3Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _line3Repository.GetTotalAmountByMountly2024();
            return View(values);
        }
    }
}
