namespace ECommerce_BigDataAnalytics.Repositories.Widget2Repositories
{
    public interface IOrderRepository
    {
        Task<int> GetLast7DaysOrderCountAsync();
        Task<int> GetPrevious7DaysOrderCountAsync();
        Task<List<int>> GetLast7DaysDailyOrderCountsAsync();
    }
}
