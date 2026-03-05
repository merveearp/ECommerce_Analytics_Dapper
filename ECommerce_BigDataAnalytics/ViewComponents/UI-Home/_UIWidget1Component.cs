using ECommerce_BigDataAnalytics.Repositories.Widget1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIWidget1Component :ViewComponent
    {
        private readonly ICustomerRepository _customerRepository;

        public _UIWidget1Component(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var current = await _customerRepository.GetLast7DaysCustomerCountAsync(); 
            var previous = await _customerRepository.GetPrevious7DaysCustomerCountAsync(); 
            var sparkline = await _customerRepository.GetLast7DaysDailyCustomerCountsAsync();

            ViewBag.TotalCustomers = current;
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
