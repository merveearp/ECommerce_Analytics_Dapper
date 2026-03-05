using ECommerce_BigDataAnalytics.Repositories.ProfitRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIProfit1Component :ViewComponent
    {
        private readonly IProfitRepository _profitRepository;

        public _UIProfit1Component(IProfitRepository profitRepository)
        {
            _profitRepository = profitRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _profitRepository.GetProfit1Async();
            ViewBag.Profit1 = Math.Round((value.EstimatedProfit / value.Revenue) * 100, 1);
            return View(value);
        }

        
    }
}
