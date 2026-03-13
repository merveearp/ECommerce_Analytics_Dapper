namespace ECommerce_BigDataAnalytics.Dtos.CountryDto
{
    public class CustomerCountryMapDto
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderPercentage { get; set; }
    }
}
