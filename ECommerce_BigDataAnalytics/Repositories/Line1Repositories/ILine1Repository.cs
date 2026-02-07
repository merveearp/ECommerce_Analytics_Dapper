using ECommerce_BigDataAnalytics.Dtos.LineChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.MultiLine1Repositories
{
    public interface ILine1Repository
    {
        Task<List<MonthlyOrderStatusCountDto>> GetMonthlyOrderCountByStatus();
    }
}
