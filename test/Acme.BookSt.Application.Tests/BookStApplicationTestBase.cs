using Volo.Abp.Modularity;

namespace Acme.BookSt;

public abstract class BookStApplicationTestBase<TStartupModule> : BookStTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
