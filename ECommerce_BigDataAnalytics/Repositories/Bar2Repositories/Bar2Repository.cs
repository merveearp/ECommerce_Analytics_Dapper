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
                select TOP(10)
                c.CategoryName AS 'CategoryName',
                Count(o.OrderId) AS 'OrderCount'

                from 
                Categories c
                inner join Products p on p.CategoryId=c.CategoryId
                inner join OrderDetails d on d.ProductId=p.ProductId
                inner join Orders o on o.OrderId=d.OrderId
                group by CategoryName
                ORDER BY OrderCount DESC;

                    ";

            var result = await _db.QueryAsync<Bar2ChartDto>(query,commandTimeout:120);
            return result.ToList();
                

        }
    }
}
