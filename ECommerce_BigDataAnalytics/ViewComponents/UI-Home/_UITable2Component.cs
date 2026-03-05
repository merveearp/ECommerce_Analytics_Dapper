using ECommerce_BigDataAnalytics.Repositories.TableRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UITable2Component :ViewComponent
    {
        private readonly ITableRepository _tableRepository;

        public _UITable2Component(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tableRepository.GetRecentOrderAsync();
            return View(values);
        }
    }
}
