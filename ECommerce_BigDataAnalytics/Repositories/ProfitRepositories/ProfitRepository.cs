using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.ProfitDto;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.ProfitRepositories
{
    public class ProfitRepository(AppDbContext context) : IProfitRepository
    {
        private readonly IDbConnection _db = context.CreateConnection();
        public async Task<ProfitDto> GetProfit1Async()
        {
            var query = @"            

                    SELECT 
                    SUM(d.Quantity * d.UnitPrice) AS Revenue,
                    SUM(d.Quantity * d.UnitPrice * 0.60) AS EstimatedCost,
                    SUM(d.Quantity * d.UnitPrice * 0.40) AS EstimatedProfit
                    FROM OrderDetails d
                    JOIN Orders o ON o.OrderId = d.OrderId
                    WHERE o.OrderDate >= '2025-12-01'
                    AND o.OrderDate < '2026-01-01';

                ";

            
            var result = await _db.QuerySingleOrDefaultAsync<ProfitDto>(query);
            return result;
        }
    }
}
