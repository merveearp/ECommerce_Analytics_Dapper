

using ECommerce_BigDataAnalytics.Repositories.Widget1Repositories;
using ECommerce_BigDataAnalytics.Repositories.Widget2Repositories;

namespace ECommerce_BigDataAnalytics.Extensions
{
    public static class ServiceRegistrations 
    {
        public static void AddRepository( this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
