namespace ECommerce_BigDataAnalytics.Dtos.CountryDto
{
    public class TopProductDetailDto
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public int TotalSold { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
