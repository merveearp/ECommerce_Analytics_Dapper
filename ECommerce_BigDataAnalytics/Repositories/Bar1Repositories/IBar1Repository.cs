using ECommerce_BigDataAnalytics.Dtos.BarChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.Bar1Repositories
{
    public interface IBar1Repository
    {
        Task<List<Bar1ChartDto>> GetCountByStatusAsync();
    }
}
