using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace livraria.Pages;

public class Index_Tests : livrariaWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
