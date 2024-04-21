using Acme.BookSt.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookSt.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BookStPageModel : AbpPageModel
{
    protected BookStPageModel()
    {
        LocalizationResourceType = typeof(BookStResource);
    }
}
