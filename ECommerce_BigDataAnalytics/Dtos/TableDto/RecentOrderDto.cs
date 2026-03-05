namespace ECommerce_BigDataAnalytics.Dtos.TableDto
{
    public class RecentOrderDto
    {
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string ProductName { get; set; }
        public string TypeName { get; set; }
        public string CategoryName { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
    }
}
