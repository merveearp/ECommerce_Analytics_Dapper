using ECommerce_BigDataAnalytics.Repositories.MLRepositories;
using ECommerce_BigDataAnalytics.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _MLRevenueComponent :ViewComponent
    {
        private readonly IMLRepository _mLRepository;
        private readonly RevenueForecastService _forecastService;

        public _MLRevenueComponent(IMLRepository mLRepository, RevenueForecastService forecastService)
        {
            _mLRepository = mLRepository;
            _forecastService = forecastService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var historicalData = await _mLRepository.GetMonthlyRevenue2025();

            var forecast2026 = _forecastService
                .GetMonthlyForecast(historicalData)
                .Select(x => float.IsNaN(x) || float.IsInfinity(x) ? 0 : x)
                .ToList();

            ViewBag.History = historicalData;
            ViewBag.Forecast = forecast2026;

            return View();
        }
    }
}
