using Live_Streaming_IOT.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Live_Streaming_IOT.Permissions;

public class Live_Streaming_IOTPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Live_Streaming_IOTPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Live_Streaming_IOTPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Live_Streaming_IOTResource>(name);
    }
}
