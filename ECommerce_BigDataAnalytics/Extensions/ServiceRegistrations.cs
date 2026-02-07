

using ECommerce_BigDataAnalytics.Repositories.DoughnutChart1Repositories;
using ECommerce_BigDataAnalytics.Repositories.Line2Repositories;
using ECommerce_BigDataAnalytics.Repositories.MultiLine1Repositories;
using ECommerce_BigDataAnalytics.Repositories.PaymentWidgetRepositories;
using ECommerce_BigDataAnalytics.Repositories.PieChart1Repositories;
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
            services.AddScoped<IPieChart1Repository, PieChart1Repository>();
            services.AddScoped<IDoughnutChart1Repository, DoughnutChart1Repository>();
            services.AddScoped<ILine1Repository, Line1Repository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ILine2Repository, Line2Repository>();

        }
    }
}
