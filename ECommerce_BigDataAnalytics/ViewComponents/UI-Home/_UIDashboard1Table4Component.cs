using ECommerce_BigDataAnalytics.Repositories.Bar2Repositories;
using ECommerce_BigDataAnalytics.Repositories.TableRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard1Table4Component :ViewComponent
    {
        private readonly ITableRepository _tableRepository;

        public _UIDashboard1Table4Component(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tableRepository.GetTopSellingProductDetailsAsync();
            return View(values);
        }
    }
}
