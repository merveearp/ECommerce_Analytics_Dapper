using ECommerce_BigDataAnalytics.Repositories.Bar1Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_BigDataAnalytics.ViewComponents.UI_Home
{
    public class _UIBar1Component :ViewComponent

    {
        private readonly IBar1Repository _bar1Repository;

        public _UIBar1Component(IBar1Repository bar1Repository)
        {
            _bar1Repository = bar1Repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await _bar1Repository.GetCountByStatusAsync();

            var months = Enumerable.Range(1, 12).ToList();

            var labels = new[]
            {
        "Ocak","Şubat","Mart","Nisan","Mayıs","Haziran",
        "Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"
    };

            var datasets = data
                .GroupBy(x => x.StatusName)
                .Select(g => new
                {
                    label = g.Key,
                    data = months.Select(m =>
                        g.FirstOrDefault(x => x.MonthNumber == m)?.OrderCount ?? 0
                    ).ToList()   
                })
                .ToList();       

            ViewBag.Labels = labels;
            ViewBag.Datasets = datasets;

            return View();
        }
    }
}
