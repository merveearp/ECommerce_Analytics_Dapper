using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.PieChart1Dto;
using ECommerce_BigDataAnalytics.Dtos.PolarChart1Dto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.PolarChartStatusRepositories
{
    public class PolarChartStatusRepository(AppDbContext context) : IPolarChartStatusRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<PolarChartOrderStatusDto>> GetOrdersCountByOrderStatus()
        {
            var query = @"
        SELECT 
            o.StatusName AS StatusName,
            COUNT(r.OrderId) AS OrderCount
        FROM Orders r
        INNER JOIN OrderStatuses o 
            ON o.OrderStatusId = r.OrderStatusId
        WHERE r.OrderDate >= DATEADD(DAY, -30, CAST(GETDATE() AS DATE))
        GROUP BY o.StatusName
        ORDER BY o.StatusName;
    ";

            var result = await _db.QueryAsync<PolarChartOrderStatusDto>(query);
            return result.ToList();
        }

    }
}
