using Volo.Abp.Modularity;

namespace IphoneDirectory;

[DependsOn(
    typeof(IphoneDirectoryApplicationModule),
    typeof(IphoneDirectoryDomainTestModule)
    )]
public class IphoneDirectoryApplicationTestModule : AbpModule
{

}
