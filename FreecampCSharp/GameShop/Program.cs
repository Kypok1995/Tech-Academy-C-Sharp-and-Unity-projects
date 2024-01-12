using GameShop.DB;
using GameShop.Interfaces;
using GameShop.Migrations;
using GameShop.Models;
using GameShop.Models.Mocks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => GameShop.Models.ShopCart.GetCart(sp));//to add reference to shop cart class
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAllGames, GameRepository>();//to link interface with data class
builder.Services.AddTransient<IGamesCategory, CategoryRepository>();
builder.Services.AddTransient<IAllOrders, OrdersRepository>();
builder.Services.AddDbContext<AppDBContent>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//to connect database and connection string 
builder.Services.AddMemoryCache();//to implement a shop cart functionality
builder.Services.AddSession();


var app = builder.Build();

DbObjects.Initial(app);//to initialize database

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();//to turn on sessions for shop cart
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(//route for categories filter
    name: "categoryFilter",
    pattern: "{controller=Games}/{action=List}/{category?}",
    defaults: new {Controller = "Games", action = "List"}) ;

app.MapControllerRoute(//route for categories filter
    name: "shopCartAddition",
    pattern: "{controller=ShopCart}/{action=addToCart}/{id?}",
    defaults: new { Controller = "ShopCart", action = "addToCart" });


app.Run();
