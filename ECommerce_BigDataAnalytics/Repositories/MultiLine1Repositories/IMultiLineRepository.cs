using ECommerce_BigDataAnalytics.Dtos.LineChart1Dto;

namespace ECommerce_BigDataAnalytics.Repositories.MultiLine1Repositories
{
    public interface IMultiLineRepository
    {
        Task<List<MonthlyOrderAmountDto>> GetAmountPerMonthly();
    }
}
