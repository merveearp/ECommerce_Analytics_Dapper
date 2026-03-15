using ECommerce_BigDataAnalytics.Dtos.BarChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.Bar3Repositories
{
    public interface IBar3Repository
    {
        Task<List<Bar3ChartDto>> GetCategoryRevenueAsync();
    }
}
