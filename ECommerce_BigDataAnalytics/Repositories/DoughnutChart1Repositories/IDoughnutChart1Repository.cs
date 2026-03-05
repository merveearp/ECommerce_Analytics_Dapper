using ECommerce_BigDataAnalytics.Dtos.DoughnutChartDto;

namespace ECommerce_BigDataAnalytics.Repositories.DoughnutChart1Repositories
{
    public interface IDoughnutChart1Repository
    {
        Task<List<DoughnutChart1Dto>> GetOrdersCountByOrderStatus();
        Task<List<DoughnutChart1Dto>> GetOrdersCountByOrderStatus2();
        Task<int> GetOrdersCountByTotal();
    }
}
