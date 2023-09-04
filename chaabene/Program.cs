using chaabene.Data;
using chaabene.Models;
using chaabene.Service.Archieve_Service;
using chaabene.Service.Offer_Service;
using chaabene.Service.OfferDetail_Service;
using chaabene.Service.Product_Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
builder.Services.AddTransient<IProductService,ProductService>();
builder.Services.AddTransient<IOfferService, OfferService>();
builder.Services.AddTransient<IOfferDetailService, OfferDetailService>();
builder.Services.AddTransient<IArchieveService, ArchieveService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
