var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.ConfigureMiddleware();
app.RegisterEndpoints(); 

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

