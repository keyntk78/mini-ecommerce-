using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MiniEcommerce;

[Dependency(ReplaceServices = true)]
public class MiniEcommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MiniEcommerce";
}
