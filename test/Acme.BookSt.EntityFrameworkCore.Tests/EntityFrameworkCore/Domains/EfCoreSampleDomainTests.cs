using Acme.BookSt.Samples;
using Xunit;

namespace Acme.BookSt.EntityFrameworkCore.Domains;

[Collection(BookStTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStEntityFrameworkCoreTestModule>
{

}
