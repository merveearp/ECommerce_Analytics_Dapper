namespace ECommerce_BigDataAnalytics.DTOs.CustomerDtos
{
    public class ResultCustomerDtos
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
