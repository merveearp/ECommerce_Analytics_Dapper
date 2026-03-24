using ECommerce_BigDataAnalytics.Context;
using ECommerce_BigDataAnalytics.Extensions;
using ECommerce_BigDataAnalytics.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<RevenueForecastService>();
builder.Services.AddRepository();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddControllersWithViews();




var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
