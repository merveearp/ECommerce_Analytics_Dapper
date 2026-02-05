using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.LineChart1Dto;
using ECommerce_BigDataAnalytics.Dtos.PieChart1Dto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.MultiLine1Repositories
{
    public class MultiLineRepository(AppDbContext context) : IMultiLineRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<MonthlyOrderAmountDto>> GetAmountPerMonthly()
        {
            var query = @"

            SELECT
                MONTH(OrderDate)  AS 'Month',
                COUNT(OrderId)    AS 'OrderCount',
                SUM(TotalAmount)  AS 'TotalAmount'
            FROM Orders
            WHERE OrderDate >= '2025-01-01'
              AND OrderDate <  '2026-01-01'
            GROUP BY MONTH(OrderDate)
            ORDER BY Month;

            ";

            var result = await _db.QueryAsync<MonthlyOrderAmountDto>(query);
            return result.ToList();
        }
    }
}
