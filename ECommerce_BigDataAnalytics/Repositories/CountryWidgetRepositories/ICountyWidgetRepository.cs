using ECommerce_BigDataAnalytics.Dtos.CountryDto;

namespace ECommerce_BigDataAnalytics.Repositories.CountryWidgetRepositories
{
    public interface ICountyWidgetRepository
    {
        Task<TopCountryDto> GetTopCountry();
        Task<int> GetCountryCount();
        Task<int> GetCityCount();
        Task<TopOrderDto> GetTopOrderCountry();
        Task<List<CustomerCountryMapDto>> GetOrderByCountryAsync();
        Task<List<CountryCustomerDto>> GetCountryCustomer();
        Task<List<CountryOfCityDto>> GetCityAsync();
        Task<List<CountryAreaTotalAmountDto>> GetAmountOfCountry();

    }
}
