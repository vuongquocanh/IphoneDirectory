using System;
using System.Collections.Generic;
using System.Text;
using IphoneDirectory.Localization;
using Volo.Abp.Application.Services;

namespace IphoneDirectory;

/* Inherit your application services from this class.
 */
public abstract class IphoneDirectoryAppService : ApplicationService
{
    protected IphoneDirectoryAppService()
    {
        LocalizationResource = typeof(IphoneDirectoryResource);
    }
}
