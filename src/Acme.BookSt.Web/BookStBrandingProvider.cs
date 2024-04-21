using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.BookSt.Web;

[Dependency(ReplaceServices = true)]
public class BookStBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookSt";
}
