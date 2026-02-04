using ECommerce_BigDataAnalytics.Repositories.Widget2Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIWidget2Component :ViewComponent
    {
        private readonly IOrderRepository _orderRepository;

        public _UIWidget2Component(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var current = await _orderRepository.GetLast7DaysOrderCountAsync(); //son 7 gün order sayısı
            var previous = await _orderRepository.GetPrevious7DaysOrderCountAsync(); //son 14 ile 7 gün arasındaki sayı
            var sparkline = await _orderRepository.GetLast7DaysDailyOrderCountsAsync(); //son 7 gün gün order sayısı

            ViewBag.TotalOrders = current;
            ViewBag.ChangeRate = CalculateRate(current, previous);
            ViewBag.SparklineData = sparkline;


            return View();
        }
        private decimal CalculateRate(int current, int previous)
        {

            if (previous == 0)
                return current > 0 ? 100 : 0;


            return Math.Round(
                ((decimal)(current - previous) / previous) * 100,
                2
            );
        }
    }
}
