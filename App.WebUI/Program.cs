using App.WebUI.CustomViewLocation;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<HttpClient>();  
builder.Services.AddScoped<AboutService>();
builder.Services.AddScoped<TestimonialService>();
builder.Services.AddScoped<ServiceService>();
builder.Services.AddScoped<CarService>();
builder.Services.AddScoped<FooterAddressService>();
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<BannerService>();
builder.Services.AddScoped<BlogService>();
builder.Services.AddScoped<CarPricingService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<TagCloudService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
