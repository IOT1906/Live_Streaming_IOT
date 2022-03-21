using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Live_Streaming_IOT.Web;

[Dependency(ReplaceServices = true)]
public class Live_Streaming_IOTBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Live_Streaming_IOT";
}
