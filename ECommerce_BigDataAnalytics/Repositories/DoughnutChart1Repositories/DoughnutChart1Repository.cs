using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.DoughnutChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.DoughnutChart1Repositories
{
    public class DoughnutChart1Repository(AppDbContext context) : IDoughnutChart1Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<DoughnutChart1Dto>> GetOrdersCountByOrderStatus()
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

            var result = await _db.QueryAsync<DoughnutChart1Dto>(query);
            return result.ToList();
        }

    }
}
