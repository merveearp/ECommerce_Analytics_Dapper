using ECommerce_BigDataAnalytics.Dtos.BarChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.Bar2Repositories
{
    public interface IBar2Repository
    {
        Task<List<Bar2ChartDto>> GetTopOrderCountCategory();
        Task<List<Bar3ChartDto>> GetTotalAmountCategory();
    }
}
