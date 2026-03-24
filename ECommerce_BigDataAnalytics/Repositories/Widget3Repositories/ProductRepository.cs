using Dapper;
using ECommerce_BigDataAnalytics.Context;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Widget3Repositories
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public Task<int> TotalProduct()
        {
            var query = "SELECT COUNT(*) FROM Products";
            return _db.QuerySingleAsync<int>(query);
        }
    }
}
