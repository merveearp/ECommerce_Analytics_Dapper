using ECommerce_BigDataAnalytics.Dtos.LineChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.Line2Repositories
{
    public interface ILine2Repository
    {
        Task<List<MonthlyOrderCountDto>> GetOrderCountByMonthly();
    }
}
