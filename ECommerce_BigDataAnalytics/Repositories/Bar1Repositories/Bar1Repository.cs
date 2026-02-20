using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.BarChartDto;
using ECommerce_BigDataAnalytics.Dtos.DoughnutChartDto;
using System.Data;
using System.Data.Common;

namespace ECommerce_BigDataAnalytics.Repositories.Bar1Repositories
{
    public class Bar1Repository(AppDbContext context) : IBar1Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<Bar1ChartDto>> GetCountByStatusAsync()
        {
            var query = @"
        SELECT 
            o.OrderStatusId,
            s.StatusName,
            MONTH(o.OrderDate) AS MonthNumber,
            DATENAME(MONTH, o.OrderDate) AS MonthName,
            COUNT(*) AS OrderCount
        FROM Orders o
        INNER JOIN OrderStatuses s 
            ON o.OrderStatusId = s.OrderStatusId
        WHERE o.OrderDate >= '2025-01-01'
        GROUP BY 
            o.OrderStatusId,
            s.StatusName,
            MONTH(o.OrderDate),
            DATENAME(MONTH, o.OrderDate)
        ORDER BY 
            MonthNumber;
    ";

            var result = await _db.QueryAsync<Bar1ChartDto>(query);
            return result.ToList();
        }
    }
}
