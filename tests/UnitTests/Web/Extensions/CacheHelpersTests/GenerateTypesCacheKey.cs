using Microsoft.eShopWeb.Web.Catalog;
using Xunit;

namespace Microsoft.eShopWeb.UnitTests.Web.Extensions.CacheHelpersTests;

public class GenerateTypesCacheKey
{
    [Fact]
    public void ReturnsTypesCacheKey()
    {
        var result = CacheHelpers.GenerateTypesCacheKey();

        Assert.Equal("types", result);
    }
}
