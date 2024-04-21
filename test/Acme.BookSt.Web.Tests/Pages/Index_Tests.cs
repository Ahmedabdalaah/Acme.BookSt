using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.BookSt.Pages;

public class Index_Tests : BookStWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
