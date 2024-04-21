using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookSt.Data;

/* This is used if database provider does't define
 * IBookStDbSchemaMigrator implementation.
 */
public class NullBookStDbSchemaMigrator : IBookStDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
