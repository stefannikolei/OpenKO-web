using OpenKO.Web.Db;
using OpenKO.Web.Endpoints;
using OpenKO.Web.Endpoints.Accounts;

namespace OpenKO.Web;

internal static class ConfigureApp
{
    extension(WebApplicationBuilder builder)
    {
        internal void AddServices()
        {
            builder.Services.AddOpenApi();
            
            builder.Services.AddSqlServer<KnightOnlineDbContext>(builder.Configuration.GetConnectionString("DefaultConnection"));
        }
    }

    extension(WebApplication app)
    {
        internal void Configure()
        { 
            app.MapOpenApi();
            app.UseSwaggerUI(options => { options.SwaggerEndpoint("/openapi/v1.json", "v1"); });
            
            app.MapEndpoints();
        }

        private void MapEndpoints()
        { 
            RouteGroupBuilder endpoints = app.MapGroup("api");
            
            endpoints.MapAccountEndpoints();
        }
    }

    extension(IEndpointRouteBuilder app)
    {
        private void MapAccountEndpoints()
        {
            RouteGroupBuilder endpoints = app.MapGroup("account").WithTags("Account");
            endpoints.MapEndpoint<RegisterAccountEndpoint>();
        }
        
        private IEndpointRouteBuilder MapEndpoint<TEndpoint>()
            where TEndpoint : IEndpoint
        {
            TEndpoint.Map(app);
            return app;
        }
    }
}