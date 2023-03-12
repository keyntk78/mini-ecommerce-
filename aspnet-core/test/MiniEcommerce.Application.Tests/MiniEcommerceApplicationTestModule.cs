using Volo.Abp.Modularity;

namespace MiniEcommerce;

[DependsOn(
    typeof(MiniEcommerceApplicationModule),
    typeof(MiniEcommerceDomainTestModule)
    )]
public class MiniEcommerceApplicationTestModule : AbpModule
{

}
