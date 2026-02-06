using ECommerce_BigDataAnalytics.Repositories.PaymentWidgetRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIPaymentWidgetsComponent :ViewComponent
    {
        private readonly IPaymentRepository _paymentRepository;

        public _UIPaymentWidgetsComponent(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _paymentRepository.GetLastAmountByPaymentType();
            return View(values);
        }
    }
}
