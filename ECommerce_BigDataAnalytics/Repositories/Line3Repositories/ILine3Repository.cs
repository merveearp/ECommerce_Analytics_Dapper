using ECommerce_BigDataAnalytics.Dtos.LineChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.Line3Repositories
{
    public interface ILine3Repository
    {
        Task<List<MonthlyTotalAmountDto>> GetTotalAmountByMountly();
        Task<List<MonthlyTotalAmountDto>> GetTotalAmountByMountly2024();
    }
}
