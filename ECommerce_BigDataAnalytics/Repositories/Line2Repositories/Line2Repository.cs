using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.LineChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Line2Repositories
{
    public class Line2Repository(AppDbContext context) : ILine2Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<MonthlyOrderCountDto>> GetOrderCountByMonthly()
        {
            var query = @"
            SET LANGUAGE Turkish;
            SELECT
                DATENAME(MONTH, OrderDate) AS MonthName,
                COUNT(OrderId) AS OrderCount
            FROM Orders
            WHERE OrderStatusId <> 5
              AND OrderDate >= '2025-01-01'
              AND OrderDate <  '2026-01-01'
            GROUP BY
                MONTH(OrderDate),
                DATENAME(MONTH, OrderDate)
            ORDER BY
                MONTH(OrderDate);

            ";

            var result = await _db.QueryAsync<MonthlyOrderCountDto>(query,commandTimeout:120);
            return result.ToList();
          
        }
    }
}
