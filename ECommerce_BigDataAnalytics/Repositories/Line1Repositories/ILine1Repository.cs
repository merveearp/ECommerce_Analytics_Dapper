using ECommerce_BigDataAnalytics.Dtos.LineChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.Line1Repositories
{
    public interface ILine1Repository
    {
        Task<List<MonthlyOrderStatusCountDto>> GetMonthlyOrderCountByStatus();
    }
}
