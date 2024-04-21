using Volo.Abp.Modularity;

namespace Acme.BookSt;

[DependsOn(
    typeof(BookStDomainModule),
    typeof(BookStTestBaseModule)
)]
public class BookStDomainTestModule : AbpModule
{

}
