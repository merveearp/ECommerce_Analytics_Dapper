using ECommerce_BigDataAnalytics.Repositories.TableRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UILowStockComponent :ViewComponent
    {
        private readonly ITableRepository _tableRepository;

        public _UILowStockComponent(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tableRepository.GetLowStockAsync();
            return View(values);
        }
    }
}
