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
            var current = await _customerRepository.TotalCustomer(); 

            ViewBag.TotalCustomers = current;
            return View();

        }
      

    }
}
