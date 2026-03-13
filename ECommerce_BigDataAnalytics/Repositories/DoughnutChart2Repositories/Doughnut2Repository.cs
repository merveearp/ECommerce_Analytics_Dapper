using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.DoughnutChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.DoughnutChart2Repositories
{
    public class Doughnut2Repository(AppDbContext context) : IDoughnut2Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<DoughnutChart2Dto>> GetStockFromCategory()
        {
            var query = @"SELECT 
                  c.CategoryName,
                  SUM(p.StockQuantity) AS TotalStock
                  FROM Products p
                  INNER JOIN Categories c
                      ON p.CategoryId = c.CategoryId
                  GROUP BY c.CategoryName";

            var result = await _db.QueryAsync<DoughnutChart2Dto>(query,commandTimeout:120);

            return result.ToList();
        }
    }
}
