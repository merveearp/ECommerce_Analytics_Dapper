using ECommerce_BigDataAnalytics.Dtos.BarChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.Bar4Repositories
{
    public interface IBar4Repository
    {
        Task<List<Bar4ChartDto>> GetStockSalesAnalysis();
    }
}
