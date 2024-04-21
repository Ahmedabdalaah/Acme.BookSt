using Acme.BookSt.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookSt.Book;

/* Inherit your application services from this class.
 */
public abstract class BookStAppService : ApplicationService
{
    protected BookStAppService()
    {
        LocalizationResource = typeof(BookStResource);
    }
}
