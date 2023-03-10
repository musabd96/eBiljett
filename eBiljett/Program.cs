using eBiljett.Data;
using eBiljett.Data.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySQL(
    builder.Configuration.GetConnectionString("DefualtConnectionString")));


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IActorsService, ActorsService>();



//var connectionString =builder.Configuration.GetConnectionString("ConnectionStrings");


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

//Seed Database
AppDBInitializer.Seed(app);

app.Run();
