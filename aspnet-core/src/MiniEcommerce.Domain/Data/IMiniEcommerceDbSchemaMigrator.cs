using System.Threading.Tasks;

namespace MiniEcommerce.Data;

public interface IMiniEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
