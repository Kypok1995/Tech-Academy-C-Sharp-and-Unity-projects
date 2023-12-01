using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAllGames, MockGames>();//to link interface and class using it
builder.Services.AddTransient<IGamesCategory, MockCategory>();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Games}/{action=List}/{id?}");

// Configure services
app.UseStaticFiles();
app.UseRouting();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePages();
}
else
{
    // Other error handling middleware for production.
    app.UseExceptionHandler("/Home/Error");
    app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");
}


app.Run();


