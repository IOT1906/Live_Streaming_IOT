using Live_Streaming_IOT.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Live_Streaming_IOT.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Live_Streaming_IOTEntityFrameworkCoreModule),
    typeof(Live_Streaming_IOTApplicationContractsModule)
    )]
public class Live_Streaming_IOTDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
