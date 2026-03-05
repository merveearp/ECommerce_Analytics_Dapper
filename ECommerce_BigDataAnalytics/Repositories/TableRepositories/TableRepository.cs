using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.TableDto;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.TableRepositories
{
    public class TableRepository (AppDbContext context): ITableRepository
    {
        private readonly IDbConnection _db = context.CreateConnection(); 
        public async Task<List<RecentOrderDto>> GetRecentOrderAsync()
        {
            var query = @"

                select top(10)
                    g.CategoryName as 'CategoryName',
                    t.ProductName as 'ProductName' ,
                    d.Quantity as 'Quantity',
                    t.Price as 'ProductPrice',
                    c.FirstName as 'CustomerName',
                    c.LastName as 'CustomerLastName',
                    s.StatusName as 'OrderStatus',
                    p.PaymentTypeName as 'TypeName'

                    from Orders o 
                    inner join Customers c on c.CustomerId=o.CustomerId
                    inner join PaymentTypes p on p.PaymentTypeId=o.PaymentTypeId
                    inner join OrderStatuses s on s.OrderStatusId=o.OrderStatusId
                    inner join OrderDetails d on d.OrderId = o.OrderId
                    inner join Products t on t.ProductId= d.ProductId
                    inner join Categories g on g.CategoryId = t.CategoryId

                    ORDER BY  o.OrderDate DESC;
            ";
             var result =await _db.QueryAsync<RecentOrderDto>(query,commandTimeout:120);
               
              return result.ToList();
        }
    }
}
