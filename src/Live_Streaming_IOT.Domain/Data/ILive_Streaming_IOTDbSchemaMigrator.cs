using System.Threading.Tasks;

namespace Live_Streaming_IOT.Data;

public interface ILive_Streaming_IOTDbSchemaMigrator
{
    Task MigrateAsync();
}
