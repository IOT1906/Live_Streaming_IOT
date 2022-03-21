using System;
using System.Collections.Generic;
using System.Text;
using Live_Streaming_IOT.Localization;
using Volo.Abp.Application.Services;

namespace Live_Streaming_IOT;

/* Inherit your application services from this class.
 */
public abstract class Live_Streaming_IOTAppService : ApplicationService
{
    protected Live_Streaming_IOTAppService()
    {
        LocalizationResource = typeof(Live_Streaming_IOTResource);
    }
}
