using Dapper;
using ECommerce_BigDataAnalytics.Context;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Widget2Repositories
{
    public class OrderRepository(AppDbContext context) : IOrderRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<int>> GetLast7DaysDailyOrderCountsAsync()
        {
            var query = @"
            SELECT COUNT(*) AS DailyCount
            FROM Orders
            WHERE OrderDate >= DATEADD(DAY, -55, CONVERT(date, GETDATE()))
              AND OrderDate <  CONVERT(date, GETDATE())
            GROUP BY CONVERT(date, OrderDate)
            ORDER BY CONVERT(date, OrderDate)
        ";

            var result = await _db.QueryAsync<int>(query);
            return result.ToList();
        }

        public Task<int> GetLast7DaysOrderCountAsync()
        {
            var query = @"

            Select COUNT(*) FROM Orders
            WHERE OrderDate >= DATEADD(DAY, -55 , GETDATE())
            AND OrderDate < GETDATE() 
 
            ";

            return _db.QuerySingleAsync<int>(query);
        }

        public Task<int> GetPrevious7DaysOrderCountAsync()
        {
            var query = @"
                SELECT COUNT(*)
                FROM Orders
                WHERE OrderDate >= DATEADD(DAY, -85, CONVERT(date, GETDATE()))
                  AND OrderDate <  DATEADD(DAY, -55, CONVERT(date, GETDATE()))
            ";

            return _db.QuerySingleAsync<int>(query);
        }
    }
}
