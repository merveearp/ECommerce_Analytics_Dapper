using ECommerce_BigDataAnalytics.Dtos.PaymentDto;

namespace ECommerce_BigDataAnalytics.Repositories.PaymentWidgetRepositories
{
    public interface IPaymentRepository
    {
        Task<List<PaymentTypeDto>> GetLastAmountByPaymentType();
    }
}
