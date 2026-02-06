using ECommerce_BigDataAnalytics.Repositories.MultiLine1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIMultiLine1Component :ViewComponent
    {
        private readonly IMultiLineRepository _multiLineRepository;

        public _UIMultiLine1Component(IMultiLineRepository multiLineRepository)
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
