using ECommerce_BigDataAnalytics.Dtos.DoughnutChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.DoughnutChart2Repositories
{
    public interface IDoughnut2Repository
    {
        Task<List<DoughnutChart2Dto>> GetStockFromCategory();
    }
}
