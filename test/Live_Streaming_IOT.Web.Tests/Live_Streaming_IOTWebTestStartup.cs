using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Live_Streaming_IOT;

public class Live_Streaming_IOTWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<Live_Streaming_IOTWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
