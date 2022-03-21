using Volo.Abp.Modularity;

namespace Live_Streaming_IOT;

[DependsOn(
    typeof(Live_Streaming_IOTApplicationModule),
    typeof(Live_Streaming_IOTDomainTestModule)
    )]
public class Live_Streaming_IOTApplicationTestModule : AbpModule
{

}
