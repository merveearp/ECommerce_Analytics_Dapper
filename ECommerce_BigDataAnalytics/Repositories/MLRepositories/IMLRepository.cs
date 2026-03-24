using ECommerce_BigDataAnalytics.Services;

namespace ECommerce_BigDataAnalytics.Repositories.MLRepositories
{
    public interface IMLRepository
    {
        Task<List<MonthlyRevenueData>> GetMonthlyRevenue2025();
    }
}
