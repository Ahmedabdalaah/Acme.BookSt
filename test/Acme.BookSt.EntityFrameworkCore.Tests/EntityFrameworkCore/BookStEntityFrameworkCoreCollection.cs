using Xunit;

namespace Acme.BookSt.EntityFrameworkCore;

[CollectionDefinition(BookStTestConsts.CollectionDefinitionName)]
public class BookStEntityFrameworkCoreCollection : ICollectionFixture<BookStEntityFrameworkCoreFixture>
{

}
