using IphoneDirectory.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IphoneDirectory.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class IphoneDirectoryController : AbpControllerBase
{
    protected IphoneDirectoryController()
    {
        LocalizationResource = typeof(IphoneDirectoryResource);
    }
}
