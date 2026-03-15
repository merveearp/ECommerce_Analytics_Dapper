using ECommerce_BigDataAnalytics.Dtos.LineChartDto;
using System.Reflection.Metadata.Ecma335;

namespace ECommerce_BigDataAnalytics.Repositories.Line4Repositories
{
    public interface ILine4Repository
    {
        Task<List<CategoryMonthlyRevenueDto>> CategoryMonthlyRevenue();


    }
}
