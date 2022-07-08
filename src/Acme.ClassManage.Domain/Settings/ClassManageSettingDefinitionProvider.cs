using Volo.Abp.Settings;

namespace Acme.ClassManage.Settings;

public class ClassManageSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ClassManageSettings.MySetting1));
    }
}
