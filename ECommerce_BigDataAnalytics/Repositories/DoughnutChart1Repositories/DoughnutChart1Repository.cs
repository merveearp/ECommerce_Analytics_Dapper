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
        GROUP BY o.StatusName
        ORDER BY o.StatusName;
    ";

            var result = await _db.QueryAsync<DoughnutChart1Dto>(query,commandTimeout:120);
            return result.ToList();
        }

        public async Task<List<DoughnutChart1Dto>> GetOrdersCountByOrderStatus2()
        {
            var query = @"
        SELECT 
            o.StatusName AS StatusName,
            COUNT(r.OrderId) AS OrderCount
        FROM Orders r
        INNER JOIN OrderStatuses o 
            ON o.OrderStatusId = r.OrderStatusId
                GROUP BY o.StatusName
                ORDER BY o.StatusName;
            ";

            var result = await _db.QueryAsync<DoughnutChart1Dto>(query, commandTimeout: 120);
            return result.ToList();
        }
        

        public async Task<int> GetOrdersCountByTotal()
        {
            var query = @" SELECT  COUNT(r.OrderId) FROM Orders r
            ";
            var result = await _db.QueryAsync<int>(query, commandTimeout: 120);
            return result.FirstOrDefault();
        }
    }
}
