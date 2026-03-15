namespace ECommerce_BigDataAnalytics.Dtos.LineChartDto
{
    public class CategoryMonthlyRevenueDto
    {
        public string CategoryName { get; set; }
        public int MonthNumber { get; set; }
        public string MonthName { get; set; }
        public decimal Revenue { get; set; }
    }
}
