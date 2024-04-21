using Volo.Abp.Modularity;

namespace Acme.BookSt;

[DependsOn(
    typeof(BookStApplicationModule),
    typeof(BookStDomainTestModule)
)]
public class BookStApplicationTestModule : AbpModule
{

}
