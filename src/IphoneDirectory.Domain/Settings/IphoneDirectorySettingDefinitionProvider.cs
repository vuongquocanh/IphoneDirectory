using Volo.Abp.Settings;

namespace IphoneDirectory.Settings;

public class IphoneDirectorySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(IphoneDirectorySettings.MySetting1));
    }
}
