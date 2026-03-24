using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Services;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.MLRepositories
{
    public class MLRepository(AppDbContext context) :IMLRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();

        public async Task<List<MonthlyRevenueData>> GetMonthlyRevenue2025()
        {
            var query = @"
            SELECT 
                DATEFROMPARTS(YEAR(OrderDate), MONTH(OrderDate), 1) AS Date,
                SUM(TotalAmount) AS TotalAmount
            FROM Orders
            WHERE OrderDate BETWEEN '2024-01-01' AND '2025-12-31'
            GROUP BY DATEFROMPARTS(YEAR(OrderDate), MONTH(OrderDate), 1)
            ORDER BY Date";
            var result = await _db.QueryAsync<MonthlyRevenueData>(query,commandTimeout:120);
            return result.ToList();
        }
    }
}
