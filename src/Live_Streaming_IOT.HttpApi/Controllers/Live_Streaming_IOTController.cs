using Live_Streaming_IOT.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Live_Streaming_IOT.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Live_Streaming_IOTController : AbpControllerBase
{
    protected Live_Streaming_IOTController()
    {
        LocalizationResource = typeof(Live_Streaming_IOTResource);
    }
}
