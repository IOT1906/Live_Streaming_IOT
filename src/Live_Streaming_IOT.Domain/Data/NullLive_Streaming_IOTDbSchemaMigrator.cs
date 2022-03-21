using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Live_Streaming_IOT.Data;

/* This is used if database provider does't define
 * ILive_Streaming_IOTDbSchemaMigrator implementation.
 */
public class NullLive_Streaming_IOTDbSchemaMigrator : ILive_Streaming_IOTDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
