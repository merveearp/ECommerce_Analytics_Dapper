using ECommerce_BigDataAnalytics.Repositories.Line1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UILine1Component :ViewComponent
    {
        private readonly ILine1Repository _multiLineRepository;

        public _UILine1Component(ILine1Repository multiLineRepository)
        {
            _multiLineRepository = multiLineRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _multiLineRepository.GetMonthlyOrderCountByStatus();

            return View(data);
        }
    }
}
