using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace IphoneDirectory;

[Dependency(ReplaceServices = true)]
public class IphoneDirectoryBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "IphoneDirectory";
}
