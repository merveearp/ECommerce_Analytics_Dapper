

using ECommerce_BigDataAnalytics.Repositories.Bar1Repositories;
using ECommerce_BigDataAnalytics.Repositories.Bar2Repositories;
using ECommerce_BigDataAnalytics.Repositories.Bar3Repositories;
using ECommerce_BigDataAnalytics.Repositories.Bar4Repositories;
using ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories;
using ECommerce_BigDataAnalytics.Repositories.DoughnutChart1Repositories;
using ECommerce_BigDataAnalytics.Repositories.DoughnutChart2Repositories;
using ECommerce_BigDataAnalytics.Repositories.Line1Repositories;
using ECommerce_BigDataAnalytics.Repositories.Line2Repositories;
using ECommerce_BigDataAnalytics.Repositories.Line3Repositories;
using ECommerce_BigDataAnalytics.Repositories.Line4Repositories;
using ECommerce_BigDataAnalytics.Repositories.PaymentWidgetRepositories;
using ECommerce_BigDataAnalytics.Repositories.PieChart1Repositories;
using ECommerce_BigDataAnalytics.Repositories.ProfitRepositories;
using ECommerce_BigDataAnalytics.Repositories.TableRepositories;
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
            services.AddScoped<ILine4Repository, Line4Repository>();
            services.AddScoped<ILine3Repository, Line3Repository>();
            services.AddScoped<IBar1Repository, Bar1Repository>();
            services.AddScoped<IBar2Repository, Bar2Repository>();
            services.AddScoped<IBar3Repository, Bar3Repository>();
            services.AddScoped<IBar4Repository, Bar4Repository>();
            services.AddScoped<ITableRepository, TableRepository>();
            services.AddScoped<IProfitRepository, ProfitRepository>();
            services.AddScoped<IDoughnut2Repository, Doughnut2Repository>();
            services.AddScoped<ICountyWidgetRepository, CountyWidgetRepository>();


        }
    }
}
