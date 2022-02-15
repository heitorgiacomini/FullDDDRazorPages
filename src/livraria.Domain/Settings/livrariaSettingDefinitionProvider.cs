using Volo.Abp.Settings;

namespace livraria.Settings;

public class livrariaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(livrariaSettings.MySetting1));
    }
}
