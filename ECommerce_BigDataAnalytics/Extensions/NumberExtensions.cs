namespace ECommerce_BigDataAnalytics.Extensions
{
    public static class NumberExtensions
    {
        public static string ToShortMoney(this decimal value)
        {
            if (value >= 1_000_000_000)
                return $"{value / 1_000_000_000M:0.##}B";

            if (value >= 1_000_000)
                return $"{value / 1_000_000M:0.##}M";

            if (value >= 1_000)
                return $"{value / 1_000M:0.##}K";

            return value.ToString("0.##");
        }
    }
}
