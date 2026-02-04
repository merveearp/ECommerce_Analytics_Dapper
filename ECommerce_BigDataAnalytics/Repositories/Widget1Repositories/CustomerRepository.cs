using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Repositories.Widget1Repositories;
using System.Data;

public class CustomerRepository(AppDbContext context) : ICustomerRepository
{
    private readonly IDbConnection _db = context.CreateConnection();


    public Task<int> GetLast7DaysCustomerCountAsync()
    {
        var query = @"
        SELECT COUNT(*)
        FROM Customers
        WHERE CreatedDate >= DATEADD(DAY, -8, CONVERT(date, GETDATE()))
          AND CreatedDate <  CONVERT(date, GETDATE())
    ";

        return _db.QuerySingleAsync<int>(query);
    }


    public Task<int> GetPrevious7DaysCustomerCountAsync()
    {
        var query = @"
        SELECT COUNT(*)
        FROM Customers
        WHERE CreatedDate >= DATEADD(DAY, -15, CONVERT(date, GETDATE()))
          AND CreatedDate <  DATEADD(DAY, -8, CONVERT(date, GETDATE()))
    ";

        return _db.QuerySingleAsync<int>(query);
    }


    public async Task<List<int>> GetLast7DaysDailyCustomerCountsAsync()
    {
        var query = @"
        SELECT COUNT(*) AS DailyCount
        FROM Customers
        WHERE CreatedDate >= DATEADD(DAY, -8, CONVERT(date, GETDATE()))
          AND CreatedDate <  CONVERT(date, GETDATE())
        GROUP BY CONVERT(date, CreatedDate)
        ORDER BY CONVERT(date, CreatedDate)
    ";

        var result = await _db.QueryAsync<int>(query);
        return result.ToList();
    }

}
