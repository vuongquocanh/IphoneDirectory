using IphoneDirectory.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace IphoneDirectory.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IphoneDirectoryEntityFrameworkCoreModule),
    typeof(IphoneDirectoryApplicationContractsModule)
    )]
public class IphoneDirectoryDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
