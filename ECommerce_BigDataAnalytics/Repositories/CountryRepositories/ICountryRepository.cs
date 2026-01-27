using ECommerce_BigDataAnalytics.DTOs.CityDtos;
using ECommerce_BigDataAnalytics.DTOs.CountryDtos;

namespace ECommerce_BigDataAnalytics.Repositories.CountryRepositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<ResultCountryDto>> GetAllCountryAsync();
        Task<int> CountryCountAsync();

    }
}
