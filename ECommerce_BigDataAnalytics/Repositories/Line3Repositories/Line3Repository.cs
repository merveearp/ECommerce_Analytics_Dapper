using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.LineChartDto;
using ECommerce_BigDataAnalytics.Repositories.Line2Repositories;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Line3Repositories
{
    public class Line3Repository(AppDbContext context) : ILine3Repository
    {
        private readonly IDbConnection _db = context.CreateConnection(); 
        public async Task<List<MonthlyTotalAmountDto>> GetTotalAmountByMountly()
        {
            var query = @"

            SET LANGUAGE Turkish;
            SELECT
                DATENAME(MONTH, OrderDate) AS MonthName,
                SUM(TotalAmount) AS TotalAmount
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

            var result = await _db.QueryAsync<MonthlyTotalAmountDto>(query,commandTimeout:120);
            return result.ToList();

        }
    }
}
