using ECommerce_BigDataAnalytics.Dtos.ProfitDto;

namespace ECommerce_BigDataAnalytics.Repositories.ProfitRepositories
{
    public interface IProfitRepository
    {
        Task<ProfitDto> GetProfit1Async();
    }
}
