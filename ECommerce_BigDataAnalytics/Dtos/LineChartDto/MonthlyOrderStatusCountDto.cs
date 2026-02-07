namespace ECommerce_BigDataAnalytics.Dtos.LineChartDto
{
    public class MonthlyOrderStatusCountDto
    {
        public int MonthNumber { get; set; }
        public string MonthName { get; set; }     
        public string OrderStatusName { get; set; } 
        public int OrderCount { get; set; }
    }
}
