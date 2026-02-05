using ECommerce_BigDataAnalytics.Dtos.PolarChart1Dto;

namespace ECommerce_BigDataAnalytics.Repositories.PolarChartStatusRepositories
{
    public interface IPolarChartStatusRepository
    {
        Task<List<PolarChartOrderStatusDto>> GetOrdersCountByOrderStatus();
    }
}
