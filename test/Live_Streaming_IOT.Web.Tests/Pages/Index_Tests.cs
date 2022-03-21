using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Live_Streaming_IOT.Pages;

public class Index_Tests : Live_Streaming_IOTWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
