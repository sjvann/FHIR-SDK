using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Interop;

namespace Fhir.TypeFramework.Interop.Tests;

public class TemporalInteropExtensionsTests
{
    [Fact]
    public void ToFhirDateFromLexical_preserves_partial_year()
    {
        var d = "1997".ToFhirDateFromLexical();
        Assert.Equal("1997", d.StringValue);
    }

    [Fact]
    public void ToFhirDate_uses_invariant_format()
    {
        var d = new DateTime(2020, 1, 15).ToFhirDate();
        Assert.Equal("2020-01-15", d.StringValue);
    }

    [Fact]
    public void ToFhirBoolean_roundtrip()
    {
        var b = true.ToFhirBoolean();
        Assert.True(b.Value);
    }
}
