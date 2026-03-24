using Dapper;
using ECommerce_BigDataAnalytics.Context;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.Widget4Repositories
{
    public class OrderDetailRepository(AppDbContext context) : IOrderDetailRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public Task<int> TotalOrderDetail()
        {
            var query = "SELECT COUNT(*) FROM OrderDetails";
            return _db.QuerySingleAsync<int>(query);
        }
    }
}
