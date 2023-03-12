using Volo.Abp.Settings;

namespace MiniEcommerce.Settings;

public class MiniEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MiniEcommerceSettings.MySetting1));
    }
}
