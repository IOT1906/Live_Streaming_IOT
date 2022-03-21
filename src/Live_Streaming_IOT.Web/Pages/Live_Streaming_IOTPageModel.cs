using Live_Streaming_IOT.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Live_Streaming_IOT.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class Live_Streaming_IOTPageModel : AbpPageModel
{
    protected Live_Streaming_IOTPageModel()
    {
        LocalizationResourceType = typeof(Live_Streaming_IOTResource);
    }
}
