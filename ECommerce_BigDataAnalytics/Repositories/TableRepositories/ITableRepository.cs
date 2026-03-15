using ECommerce_BigDataAnalytics.Dtos.CountryDto;
using ECommerce_BigDataAnalytics.Dtos.TableDto;

namespace ECommerce_BigDataAnalytics.Repositories.TableRepositories
{
    public interface ITableRepository
    {
        Task<List<RecentOrderDto>> GetRecentOrderAsync();
        Task<List<StockDistributionDto>> GetStockDistribution();
        Task<List<LowStockDto>> GetLowStockAsync();
        Task<List<TopProductsDto>> GetLowProductAsync();
        Task<List<HighTopProductDto>> GetHighProductAsync();
        Task<List<TopProductDetailDto>> GetTopSellingProductDetailsAsync();
    }
}
