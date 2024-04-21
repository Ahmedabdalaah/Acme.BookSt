using Acme.BookSt.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookSt.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStEntityFrameworkCoreModule),
    typeof(BookStApplicationContractsModule)
    )]
public class BookStDbMigratorModule : AbpModule
{
}
