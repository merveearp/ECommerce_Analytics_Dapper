using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.PieChart1Dto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.PieChart1Repositories
{
    public class PieChart1Repository(AppDbContext context) : IPieChart1Repository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<List<PieChartCategoryDto>> GetProductsCountByCategory()
        {
            var query = @"
                Select 
                c.CategoryName AS 'CategoryName',
                count(p.ProductId) As 'ProductCount'
                from Products p
                inner join Categories c ON c.CategoryId= p.CategoryId
                group by c.CategoryName;
            ";

            var result = await _db.QueryAsync<PieChartCategoryDto>(query);
            return result.ToList();
        }
    }
}
