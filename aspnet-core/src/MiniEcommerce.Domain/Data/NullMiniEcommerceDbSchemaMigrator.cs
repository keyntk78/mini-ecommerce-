using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MiniEcommerce.Data;

/* This is used if database provider does't define
 * IMiniEcommerceDbSchemaMigrator implementation.
 */
public class NullMiniEcommerceDbSchemaMigrator : IMiniEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
