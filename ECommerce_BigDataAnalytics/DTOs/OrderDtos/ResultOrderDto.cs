namespace ECommerce_BigDataAnalytics.DTOs.OrderDtos
{
    public class ResultOrderDto
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public DateTime OrderDate { get; set; }

        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }


        public int OrderStatusId { get; set; }
        public string StatusName { get; set; }


    }
}
