using Acme.BookSt.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookSt.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStController : AbpControllerBase
{
    protected BookStController()
    {
        LocalizationResource = typeof(BookStResource);
    }
}
