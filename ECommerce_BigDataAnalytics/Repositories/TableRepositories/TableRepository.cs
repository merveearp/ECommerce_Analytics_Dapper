using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.CountryDto;
using ECommerce_BigDataAnalytics.Dtos.TableDto;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.TableRepositories
{
    public class TableRepository (AppDbContext context): ITableRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();

        public async Task<List<HighTopProductDto>> GetHighProductAsync()
        {
            var query = @"

              SELECT TOP 10
                p.ProductName,
                SUM(od.Quantity) AS TotalSales
                FROM Products p
                INNER JOIN OrderDetails od ON od.ProductId = p.ProductId
                GROUP BY p.ProductName
                ORDER BY TotalSales DESC
            ";
            var result = await _db.QueryAsync<HighTopProductDto>(query, commandTimeout: 120);

            return result.ToList();
        }

        public async Task<List<TopProductsDto>> GetLowProductAsync()
        {
            var query = @"

               SELECT TOP 10
            p.ProductName,
            p.StockQuantity,
            c.CategoryName
            FROM Products p
            LEFT JOIN OrderDetails od ON od.ProductId = p.ProductId
            INNER JOIN Categories c ON c.CategoryId = p.CategoryId
            WHERE od.ProductId IS NULL
            ORDER BY p.StockQuantity DESC
            ";
            var result = await _db.QueryAsync<TopProductsDto>(query, commandTimeout: 120);

            return result.ToList();
        }

        public async Task<List<LowStockDto>> GetLowStockAsync()
        {
            var query = @"

               SELECT TOP 10
                ProductName,
                StockQuantity
                FROM Products
                WHERE StockQuantity < 81
                ORDER BY StockQuantity
            ";
            var result = await _db.QueryAsync<LowStockDto>(query, commandTimeout: 120);

            return result.ToList();
        }

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

        public async Task<List<StockDistributionDto>> GetStockDistribution()
        {
            var query = @"

               SELECT 
                CASE 
                    WHEN StockQuantity BETWEEN 0 AND 20 THEN '0-20 (Kritik)'
                    WHEN StockQuantity BETWEEN 21 AND 80 THEN '21-80 (Düşük)'
                    WHEN StockQuantity BETWEEN 81 AND 200 THEN '81-200 (Normal)'
                    WHEN StockQuantity BETWEEN 201 AND 400 THEN '201-400 (Yüksek)'
                    ELSE '400+ (Aşırı)'
                END AS StockRange,
                COUNT(*) AS ProductCount
                FROM Products
                GROUP BY 
                CASE 
                    WHEN StockQuantity BETWEEN 0 AND 20 THEN '0-20 (Kritik)'
                    WHEN StockQuantity BETWEEN 21 AND 80 THEN '21-80 (Düşük)'
                    WHEN StockQuantity BETWEEN 81 AND 200 THEN '81-200 (Normal)'
                    WHEN StockQuantity BETWEEN 201 AND 400 THEN '201-400 (Yüksek)'
                    ELSE '400+ (Aşırı)'
                END
                ORDER BY StockRange";
            var result = await _db.QueryAsync<StockDistributionDto>(query, commandTimeout: 120);

            return result.ToList();
        }

        public async Task<List<TopProductDetailDto>> GetTopSellingProductDetailsAsync()
        {
            var query = @"
                SELECT TOP 10
                    p.ProductName,
                    c.CategoryName,
                    p.Price,
                    SUM(od.Quantity) AS TotalSold,
                    SUM(od.Quantity * p.Price) AS TotalRevenue
                FROM OrderDetails od
                INNER JOIN Products p 
                    ON p.ProductId = od.ProductId
                INNER JOIN Categories c 
                    ON c.CategoryId = p.CategoryId
                GROUP BY 
                    p.ProductName,
                    c.CategoryName,
                    p.Price
                ORDER BY TotalSold DESC";

            var result = await _db.QueryAsync<TopProductDetailDto>(query,commandTimeout:120);
            return result.ToList();
        }
    }
}
