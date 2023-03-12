using MiniEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MiniEcommerce;

[DependsOn(
    typeof(MiniEcommerceEntityFrameworkCoreTestModule)
    )]
public class MiniEcommerceDomainTestModule : AbpModule
{

}
