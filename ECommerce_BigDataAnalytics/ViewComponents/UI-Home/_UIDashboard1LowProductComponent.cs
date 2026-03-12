using ECommerce_BigDataAnalytics.Repositories.TableRepositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard1LowProductComponent :ViewComponent
    {
        private readonly ITableRepository _tableRepository;

        public _UIDashboard1LowProductComponent(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tableRepository.GetLowProductAsync();
            return View(values);
        }
    }
}
