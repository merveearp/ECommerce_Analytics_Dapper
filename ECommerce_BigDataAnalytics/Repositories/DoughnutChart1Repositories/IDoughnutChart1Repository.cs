using ECommerce_BigDataAnalytics.Dtos.DoughnutChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.DoughnutChart1Repositories
{
    public interface IDoughnutChart1Repository
    {
        Task<List<DoughnutChart1Dto>> GetOrdersCountByOrderStatus();
    }
}
