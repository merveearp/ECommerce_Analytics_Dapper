namespace ECommerce_BigDataAnalytics.Dtos.CountryDto
{
    public class CountryOfCityDto
    {
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int CustomerCount { get; set; }
        public int OrderCount { get; set; }

    }
}
