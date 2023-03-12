using MiniEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MiniEcommerce.Permissions;

public class MiniEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MiniEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MiniEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MiniEcommerceResource>(name);
    }
}
