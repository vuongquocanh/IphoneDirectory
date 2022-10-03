using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IphoneDirectory.Data;

/* This is used if database provider does't define
 * IIphoneDirectoryDbSchemaMigrator implementation.
 */
public class NullIphoneDirectoryDbSchemaMigrator : IIphoneDirectoryDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
