using Microsoft.AspNetCore.Builder;
using Acme.BookSt;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<BookStWebTestModule>();

public partial class Program
{
}
