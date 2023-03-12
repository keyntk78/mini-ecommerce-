using MiniEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MiniEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MiniEcommerceEntityFrameworkCoreModule),
    typeof(MiniEcommerceApplicationContractsModule)
    )]
public class MiniEcommerceDbMigratorModule : AbpModule
{

}
