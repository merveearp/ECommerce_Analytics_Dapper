using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.LineChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.MultiLine1Repositories
{
    public class Line1Repository(AppDbContext context) : ILine1Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<MonthlyOrderStatusCountDto>> GetMonthlyOrderCountByStatus()
        {
            var query = @"
                SET LANGUAGE Turkish;

                SELECT
                    MONTH(o.OrderDate)           AS MonthNumber,
                    DATENAME(MONTH, o.OrderDate) AS MonthName,
                    os.StatusName                AS OrderStatusName,
                    COUNT(o.OrderId)             AS OrderCount
                FROM Orders o
                INNER JOIN OrderStatuses os
                    ON o.OrderStatusId = os.OrderStatusId
                WHERE o.OrderDate >= '2025-01-01'
                  AND o.OrderDate <  '2026-01-01'
                GROUP BY
                    MONTH(o.OrderDate),
                    DATENAME(MONTH, o.OrderDate),
                    os.StatusName
                ORDER BY
                    MonthNumber,
                    os.StatusName;
            ";

            var result = await _db.QueryAsync<MonthlyOrderStatusCountDto>(query);
            return result.ToList();
        }

    }
}
