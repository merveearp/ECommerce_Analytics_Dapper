using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.BarChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Bar2Repositories
{
    public class Bar2Repository(AppDbContext context) : IBar2Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<Bar2ChartDto>> GetTopOrderCountCategory()
        {
            var query= @"
               SELECT TOP (10)
                c.CategoryName,
                COUNT_BIG(*) AS OrderCount
            FROM OrderDetails d
            INNER JOIN Orders o ON o.OrderId = d.OrderId
            INNER JOIN Products p ON p.ProductId = d.ProductId
            INNER JOIN Categories c ON c.CategoryId = p.CategoryId
            WHERE o.OrderDate >= '2025-01-01'
            AND o.OrderDate < '2026-01-01'
            GROUP BY c.CategoryName
            ORDER BY OrderCount DESC;
                    ";

            var result = await _db.QueryAsync<Bar2ChartDto>(query,commandTimeout:120);
            return result.ToList();
                

        }

        public async Task<List<Bar3ChartDto>> GetTotalAmountCategory()
        {
            var query = @"
               SELECT TOP (10)
                c.CategoryName,
                COUNT_BIG(*) AS OrderCount
            FROM OrderDetails d
            INNER JOIN Orders o ON o.OrderId = d.OrderId
            INNER JOIN Products p ON p.ProductId = d.ProductId
            INNER JOIN Categories c ON c.CategoryId = p.CategoryId
            WHERE o.OrderDate >= '2025-01-01'
            AND o.OrderDate < '2026-01-01'
            GROUP BY c.CategoryName
            ORDER BY OrderCount DESC;
                    ";

            var result = await _db.QueryAsync<Bar3ChartDto>(query, commandTimeout: 120);
            return result.ToList();
        }
    }
}
