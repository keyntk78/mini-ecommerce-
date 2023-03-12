using MiniEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MiniEcommerce.Admin.Permissions;

public class MiniEcommerceAdminPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MiniEcommerceAdminPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MiniEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MiniEcommerceResource>(name);
    }
}
