using System.Threading.Tasks;

namespace IphoneDirectory.Data;

public interface IIphoneDirectoryDbSchemaMigrator
{
    Task MigrateAsync();
}
