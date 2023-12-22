using GameShop.DB;
using GameShop.Interfaces;
using GameShop.Models.Mocks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAllGames, GameRepository>();//to link interface with data class
builder.Services.AddTransient<IGamesCategory, CategoryRepository>();
builder.Services.AddDbContext<AppDBContent>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//to connect database and connection string 


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
    pattern: "{controller=Games}/{action=List}/{id?}");

app.Run();
