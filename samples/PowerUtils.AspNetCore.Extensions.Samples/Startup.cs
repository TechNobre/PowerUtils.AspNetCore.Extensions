using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PowerUtils.AspNetCore.Extensions;

namespace PowerUtils.AspNetCore.ErrorHandler.Samples;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(configure =>
            configure.UseGeneralRoutePrefix("/samples")
        );

        services.AddSwaggerGen();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseRouting();

        app.UseEndpoints(endpoints
            => endpoints.MapControllers() // Mapping all controller
        );
    }
}
