using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.BarChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Bar3Repositories
{
    public class Bar3Repository(AppDbContext context) : IBar3Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<Bar3ChartDto>> GetCategoryRevenueAsync()
        {
            var query = @"
                SELECT 
                    c.CategoryName,
                    SUM(od.Quantity * p.Price) AS Revenue
                FROM OrderDetails od
                JOIN Products p ON p.ProductId = od.ProductId
                JOIN Categories c ON c.CategoryId = p.CategoryId
                GROUP BY c.CategoryName
                ORDER BY Revenue DESC";

            var result = await _db.QueryAsync<Bar3ChartDto>(query,commandTimeout:120);
            return result.ToList();
        }
    }
}
