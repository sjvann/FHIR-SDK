using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Interop;

namespace Fhir.TypeFramework.Interop.Tests;

public class ComplexInteropExtensionsTests
{
    [Fact]
    public void CreateCoding_sets_system_and_code()
    {
        var c = ComplexInteropExtensions.CreateCoding("http://loinc.org", "1234-5", "Test");
        Assert.Equal("http://loinc.org", c.System?.StringValue);
        Assert.Equal("1234-5", c.Code?.StringValue);
    }

    [Fact]
    public void HumanName_fluent_builder()
    {
        var n = new HumanName().WithFamily("Lin").WithGiven("A", "B").WithText("A B Lin");
        Assert.Equal("Lin", n.Family?.StringValue);
        Assert.Equal(2, n.Given?.Count);
    }
}
