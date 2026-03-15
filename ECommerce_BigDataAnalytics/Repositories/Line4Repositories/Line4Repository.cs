using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.LineChartDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Line4Repositories
{
    public class Line4Repository(AppDbContext context) : ILine4Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<CategoryMonthlyRevenueDto>> CategoryMonthlyRevenue()
        {
            var query = @"
                SELECT 
                    c.CategoryName,
                    MONTH(o.OrderDate) AS MonthNumber,
                    DATENAME(MONTH,o.OrderDate) AS MonthName,
                    SUM(od.Quantity * p.Price) AS Revenue
                FROM OrderDetails od
                JOIN Orders o ON o.OrderId = od.OrderId
                JOIN Products p ON p.ProductId = od.ProductId
                JOIN Categories c ON c.CategoryId = p.CategoryId
                WHERE YEAR(o.OrderDate) = 2025
                AND c.CategoryName IN ('Elektronik','Beyaz Esya','Giyim')
                GROUP BY 
                    c.CategoryName,
                    MONTH(o.OrderDate),
                    DATENAME(MONTH,o.OrderDate)
                ORDER BY MonthNumber
                ";
            var result = await _db.QueryAsync<CategoryMonthlyRevenueDto>(query,commandTimeout:120);
            return result.ToList();
        }
    }
}
