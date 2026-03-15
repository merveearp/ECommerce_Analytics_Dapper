using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.CountryDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories
{
    public class CountyWidgetRepository(AppDbContext context) : ICountyWidgetRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();

        public async Task<List<CountryAreaTotalAmountDto>> GetAmountOfCountry()
        {
            var query = @"
                      SELECT 
                    co.CountryName,
                    SUM(o.TotalAmount) AS TotalAmount
                FROM Orders o
                INNER JOIN Customers cu 
                    ON cu.CustomerId = o.CustomerId
                INNER JOIN Cities ci 
                    ON ci.CityId = cu.CityId
                INNER JOIN Countries co 
                    ON co.CountryId = ci.CountryId
                GROUP BY co.CountryName
                ORDER BY TotalAmount DESC";

            var result = await _db.QueryAsync<CountryAreaTotalAmountDto>(query, commandTimeout: 120);

            return result.ToList();
        }

        public async Task<List<CountryOfCityDto>> GetCityAsync()
        {
            var query = @"
        SELECT 
            co.CountryName,
            co.CountryCode,
            ci.CityName,
            ci.Latitude,
            ci.Longitude,
            COUNT(c.CustomerId) AS CustomerCount
        FROM Customers c
        JOIN Cities ci ON ci.CityId = c.CityId
        JOIN Countries co ON co.CountryId = ci.CountryId
        GROUP BY 
            co.CountryName,
            co.CountryCode,
            ci.CityName,
            ci.Latitude,
            ci.Longitude
        ORDER BY 
            co.CountryName,
            CustomerCount DESC";

            var result = await _db.QueryAsync<CountryOfCityDto>(query, commandTimeout: 120);

            return result.ToList();
        }

        public async Task<int> GetCityCount()
        {
            var query = @"
               SELECT 
                count(*) 
                from Cities

            ";
            var result = await _db.QueryFirstOrDefaultAsync<int>(query, commandTimeout: 120);
            return result;
        }

        public async Task<int> GetCountryCount()
        {
            var query = @"
               SELECT 
                count(*) 
                from Countries

            ";
            var result = await _db.QueryFirstOrDefaultAsync<int>(query, commandTimeout: 120);
            return result;
        }

        public async Task<List<CountryCustomerDto>> GetCountryCustomer()
        {
            var query = @"
        SELECT 
            co.CountryName,
            co.CountryCode,
            COUNT(c.CustomerId) AS CustomerCount,
            CAST(
                COUNT(c.CustomerId) * 100.0 /
                (SELECT COUNT(*) FROM Customers)
            AS DECIMAL(5,2)) AS CustomerPercentage
        FROM Customers c
        JOIN Cities ci ON ci.CityId = c.CityId
        JOIN Countries co ON co.CountryId = ci.CountryId
        GROUP BY co.CountryName, co.CountryCode
        ORDER BY CustomerCount DESC
    ";

            var result = await _db.QueryAsync<CountryCustomerDto>(query, commandTimeout: 120);

            return result.ToList();
        }

        public async Task<List<CustomerCountryMapDto>> GetOrderByCountryAsync()
        {
            var query = @"
             SELECT 
                    co.CountryName,
                    co.CountryCode,
                    COUNT(o.OrderId) AS OrderCount,
                    CAST(
                        COUNT(o.OrderId) * 100.0 /
                        (SELECT COUNT(*) FROM Orders)
                    AS DECIMAL(5,2)) AS OrderPercentage
                FROM Orders o
                JOIN Customers c ON c.CustomerId = o.CustomerId
                JOIN Cities ci ON ci.CityId = c.CityId
                JOIN Countries co ON co.CountryId = ci.CountryId
                GROUP BY 
                    co.CountryName,
                    co.CountryCode
                ORDER BY OrderCount DESC";

            var result = await _db.QueryAsync<CustomerCountryMapDto>(query,commandTimeout:120);

            return result.ToList();
        }

        public async Task<TopCountryDto> GetTopCountry()
        {
            var query = @"
               SELECT TOP 1
                co.CountryName,
                SUM(o.TotalAmount) AS TotalRevenue
            FROM Orders o
            JOIN Customers cu ON cu.CustomerId = o.CustomerId
            JOIN Cities ci ON ci.CityId = cu.CityId
            JOIN Countries co ON co.CountryId = ci.CountryId
            GROUP BY co.CountryName
            ORDER BY TotalRevenue DESC
            ";
            var result = await _db.QueryFirstOrDefaultAsync<TopCountryDto>(query,commandTimeout:120);
            return result;  
        }

        public async Task<TopOrderDto> GetTopOrderCountry()
        {
            var query = @"
                  SELECT TOP 1
                    co.CountryName,
                    COUNT(o.OrderId) AS OrderCount
                FROM Orders o
                JOIN Customers cu ON cu.CustomerId = o.CustomerId
                JOIN Cities ci ON ci.CityId = cu.CityId
                JOIN Countries co ON co.CountryId = ci.CountryId
                GROUP BY co.CountryName
                ORDER BY OrderCount DESC";

            var result = await _db.QueryFirstOrDefaultAsync<TopOrderDto>(query,commandTimeout:120);

            return result;
        }
    }
}
