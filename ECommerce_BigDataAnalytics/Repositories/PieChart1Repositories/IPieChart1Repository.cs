using ECommerce_BigDataAnalytics.Dtos.PieChart1Dto;

namespace ECommerce_BigDataAnalytics.Repositories.PieChart1Repositories
{
    public interface IPieChart1Repository
    {
        Task<List<PieChartCategoryDto>> GetProductsCountByCategory();

    }
}
