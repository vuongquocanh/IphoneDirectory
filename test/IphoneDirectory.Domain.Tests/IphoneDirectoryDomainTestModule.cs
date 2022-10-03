using IphoneDirectory.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IphoneDirectory;

[DependsOn(
    typeof(IphoneDirectoryEntityFrameworkCoreTestModule)
    )]
public class IphoneDirectoryDomainTestModule : AbpModule
{

}
