using Live_Streaming_IOT.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Live_Streaming_IOT;

[DependsOn(
    typeof(Live_Streaming_IOTEntityFrameworkCoreTestModule)
    )]
public class Live_Streaming_IOTDomainTestModule : AbpModule
{

}
