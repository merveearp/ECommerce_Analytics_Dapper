using ECommerce_BigDataAnalytics.Dtos.TableDto;

namespace ECommerce_BigDataAnalytics.Repositories.TableRepositories
{
    public interface ITableRepository
    {
        Task<List<RecentOrderDto>> GetRecentOrderAsync();
    }
}
