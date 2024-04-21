using System.Threading.Tasks;

namespace Acme.BookSt.Data;

public interface IBookStDbSchemaMigrator
{
    Task MigrateAsync();
}
