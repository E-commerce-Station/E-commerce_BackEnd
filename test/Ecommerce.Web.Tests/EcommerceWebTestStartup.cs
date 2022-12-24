using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Ecommerce;

public class EcommerceWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<EcommerceWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
