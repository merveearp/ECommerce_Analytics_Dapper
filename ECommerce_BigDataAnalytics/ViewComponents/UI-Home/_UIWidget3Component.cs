using ECommerce_BigDataAnalytics.Repositories.Widget1Repositories;
using ECommerce_BigDataAnalytics.Repositories.Widget3Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIWidget3Component : ViewComponent
    {
        private readonly IProductRepository _productRepository;

        public _UIWidget3Component(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var current = await _productRepository.TotalProduct(); 

            ViewBag.TotalProducts = current;
            return View();

        }
      

    }
}
