using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Abp.FamilyTree.Pages;

public class Index_Tests : FamilyTreeWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
