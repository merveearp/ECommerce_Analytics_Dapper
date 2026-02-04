namespace ECommerce_BigDataAnalytics.Repositories.Widget1Repositories
{
    public interface ICustomerRepository
    {
        Task<int> GetLast7DaysCustomerCountAsync();
        Task<int> GetPrevious7DaysCustomerCountAsync();
        Task<List<int>> GetLast7DaysDailyCustomerCountsAsync();

    }
}
