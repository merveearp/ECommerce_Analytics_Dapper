using Dapper;
using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Dtos.PaymentDto;
using NuGet.Packaging;
using System.Data;

namespace ECommerce_BigDataAnalytics.Repositories.PaymentWidgetRepositories
{
    public class PaymentRepository(AppDbContext context) : IPaymentRepository
    {
        private readonly IDbConnection db = context.CreateConnection();
        public async Task<List<PaymentTypeDto>> GetLastAmountByPaymentType()
        {
            var query = @"
            SELECT 
                p.PaymentTypeName As 'PaymentTypeName',
                Sum(o.TotalAmount) As 'TotalAmount'
                FROM Orders o
                inner join PaymentTypes p on p.PaymentTypeId=o.PaymentTypeId
                where o.OrderDate >= '2025-12-01'
                and o.OrderDate < '2025-12-31'
                group by p.PaymentTypeName
            ";

            var result = await db.QueryAsync<PaymentTypeDto>(query,commandTimeout:120);
            return result.ToList();
        }
    }
}
