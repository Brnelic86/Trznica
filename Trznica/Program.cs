using Blazored.SessionStorage;
using Havit.Blazor.Components.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using Trznica.Data;
using Blazored.SessionStorage;
using Syncfusion.Pdf;
using Trznica.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<AppDbContext>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddControllers();
builder.Services.AddHxServices();
builder.Services.AddSingleton<VrstaStola>();

builder.Services.AddBlazoredSessionStorage();
var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzMwMDQ2M0AzMjM1MmUzMDJlMzBpdDZMRWhBU0tZVzJiVlJjaUFiMEJ2OHpWeTVhVzFIdGszNVJ2WFhGdFBvPQ==");

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
app.MapControllers();
app.MapFallbackToPage("/_Host");

app.Run();
