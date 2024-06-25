using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.Services;
using CleanArchDemo.Domain.Entities;
using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Infrastructure.Db;
using CleanArchDemo.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Dbconnection"));
}, ServiceLifetime.Transient, ServiceLifetime.Transient)
    .AddScoped<IUserService, UserService>()
    .AddScoped<IRepository<User>, UserRepository>();


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
    pattern: "{controller=User}/{action=Index}/{id?}");

app.Run();
