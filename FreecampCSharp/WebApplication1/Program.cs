var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Configure services
builder.Services.AddControllersWithViews();
app.ConfigureMiddleware();
app.RegisterEndpoints(); 
app.UseStaticFiles();
app.UseRouting();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePagesWithReExecute();
}
else
{
    // Other error handling middleware for production.
    app.UseExceptionHandler("/Home/Error");
    app.UseStatusCodePagesWithReExecute("/Home/Error/{0}");
}

app.Run();


public static partial class ServiceInitializer// class to initialize a services
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        return services;
    }
}

public static partial class MiddlewareInitializer //class responsible for middleware initialization
{
    public static WebApplication ConfigureMiddleware(this WebApplication app)
    {
    }
}


public static partial class EndpointMapper //code for managing endpoints of application
{
    public static WebApplication RegisterEndpoints(this WebApplication app)
    {
        return app;
    }
}

