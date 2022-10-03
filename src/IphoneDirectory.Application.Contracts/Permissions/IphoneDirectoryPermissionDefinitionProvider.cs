using IphoneDirectory.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace IphoneDirectory.Permissions;

public class IphoneDirectoryPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(IphoneDirectoryPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(IphoneDirectoryPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<IphoneDirectoryResource>(name);
    }
}
