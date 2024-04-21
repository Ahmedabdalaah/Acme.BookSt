using Acme.BookSt.Samples;
using Xunit;

namespace Acme.BookSt.EntityFrameworkCore.Applications;

[Collection(BookStTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStEntityFrameworkCoreTestModule>
{

}
