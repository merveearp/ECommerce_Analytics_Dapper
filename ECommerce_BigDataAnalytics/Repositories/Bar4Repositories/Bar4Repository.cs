using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.BarChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Bar4Repositories
{
    public class Bar4Repository(AppDbContext context) : IBar4Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<Bar4ChartDto>> GetStockSalesAnalysis()
        {
            var query = @"
                SELECT 
                    c.CategoryName,
                    SUM(p.StockQuantity) AS CurrentStock,
                    ISNULL(SUM(s.TotalSold),0) AS TotalSold
                FROM Products p
                INNER JOIN Categories c 
                    ON p.CategoryId = c.CategoryId
                LEFT JOIN 
                (
                    SELECT ProductId, SUM(Quantity) AS TotalSold
                    FROM OrderDetails
                    GROUP BY ProductId
                ) s ON p.ProductId = s.ProductId
                GROUP BY c.CategoryName
                ORDER BY TotalSold DESC";

            var result = await _db.QueryAsync<Bar4ChartDto>(query,commandTimeout:120);
            return result.ToList();
        }
    }
}
