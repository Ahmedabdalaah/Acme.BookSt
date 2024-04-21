using Volo.Abp.Settings;

namespace Acme.BookSt.Settings;

public class BookStSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStSettings.MySetting1));
    }
}
