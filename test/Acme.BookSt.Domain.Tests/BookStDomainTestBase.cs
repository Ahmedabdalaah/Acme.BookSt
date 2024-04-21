using Volo.Abp.Modularity;

namespace Acme.BookSt;

/* Inherit from this class for your domain layer tests. */
public abstract class BookStDomainTestBase<TStartupModule> : BookStTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
