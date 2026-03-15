using ECommerce_BigDataAnalytics.Repositories.Line4Repositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIDashboard1Line4Component :ViewComponent
    {
        private readonly ILine4Repository _line4Repository;

        public _UIDashboard1Line4Component(ILine4Repository line4Repository)
        {
            _line4Repository = line4Repository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _line4Repository.CategoryMonthlyRevenue();

            ViewBag.Months = data
            .Select(x => x.MonthName)
            .Distinct()
            .ToList();

            ViewBag.Electronics = data
            .Where(x => x.CategoryName == "Elektronik")
            .Select(x => x.Revenue)
            .ToList();

            ViewBag.BeyazEsya = data
            .Where(x => x.CategoryName == "Beyaz Esya")
            .Select(x => x.Revenue)
            .ToList();

            ViewBag.Fashion = data
            .Where(x => x.CategoryName == "Giyim")
            .Select(x => x.Revenue)
            .ToList();
            return View();
        }
    }
}
