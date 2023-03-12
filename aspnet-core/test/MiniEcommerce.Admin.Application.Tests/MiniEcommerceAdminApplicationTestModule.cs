using Volo.Abp.Modularity;

namespace MiniEcommerce.Admin;

[DependsOn(
    typeof(MiniEcommerceAdminApplicationModule),
    typeof(MiniEcommerceDomainTestModule)
    )]
public class MiniEcommerceAdminApplicationTestModule : AbpModule
{

}
