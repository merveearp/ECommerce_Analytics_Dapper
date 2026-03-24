using ECommerce_BigDataAnalytics.Repositories.Widget2Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIWidget2ComponentV1 :ViewComponent
    {
        private readonly IOrderRepository _orderRepository;

        public _UIWidget2ComponentV1(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var current = await _orderRepository.TotalOrder();
            ViewBag.TotalOrders = current;
            return View();
        }
       
    }
}
