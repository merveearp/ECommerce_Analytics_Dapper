using ECommerce_BigDataAnalytics.Repositories.Widget1Repositories;
using ECommerce_BigDataAnalytics.Repositories.Widget4Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIWidget4Component : ViewComponent
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public _UIWidget4Component(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var current = await _orderDetailRepository.TotalOrderDetail(); 

            ViewBag.TotalOrderDetails = current;
            return View();

        }
      

    }
}
