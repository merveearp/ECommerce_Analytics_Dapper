using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Repositories.Widget1Repositories;
using System.Data;

public class CustomerRepository(AppDbContext context) : ICustomerRepository
{
    private readonly IDbConnection _db = context.CreateConnection();

    public Task<int> TotalCustomer()
    {
        var query = "SELECT COUNT(*) FROM Customers";
        return _db.QuerySingleAsync<int>(query);
    }
}
