using Microsoft.ML;
using Microsoft.ML.Transforms.TimeSeries;

namespace ECommerce_BigDataAnalytics.Services
{
    public class MonthlyRevenueData
    {
        public DateTime Date { get; set; }
        public float TotalAmount { get; set; }
    }

    public class MonthlyRevenueForecast
    {
        public float[] ForecastedRevenue { get; set; }
     
    }


    public class RevenueForecastService
    {
        public List<float> GetMonthlyForecast(List<MonthlyRevenueData> data)
        {
            var mlContext = new MLContext();

           
            var orderedData = data.OrderBy(x => x.Date).ToList();

          
            var dataView = mlContext.Data.LoadFromEnumerable(orderedData);


            var pipeline = mlContext.Forecasting.ForecastBySsa(
             outputColumnName: "ForecastedRevenue",
             inputColumnName: "TotalAmount",
             windowSize: 6,
             seriesLength: orderedData.Count,
             trainSize: orderedData.Count,
             horizon: 12
         );

            var model = pipeline.Fit(dataView);

            
            var engine = model.CreateTimeSeriesEngine<MonthlyRevenueData, MonthlyRevenueForecast>(mlContext);

           
            var forecast = engine.Predict();

           
            return forecast.ForecastedRevenue.ToList();
        }
    }
}
