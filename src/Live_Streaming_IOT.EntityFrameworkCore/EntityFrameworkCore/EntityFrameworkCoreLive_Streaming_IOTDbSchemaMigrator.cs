using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Live_Streaming_IOT.Data;
using Volo.Abp.DependencyInjection;

namespace Live_Streaming_IOT.EntityFrameworkCore;

public class EntityFrameworkCoreLive_Streaming_IOTDbSchemaMigrator
    : ILive_Streaming_IOTDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLive_Streaming_IOTDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Live_Streaming_IOTDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Live_Streaming_IOTDbContext>()
            .Database
            .MigrateAsync();
    }
}
