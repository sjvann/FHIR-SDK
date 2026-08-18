using Fhir.Resources.R5;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.Serialization;

namespace Fhir.TypeFramework.Tests.Serialization;

public sealed class OverflowAndHandlingTests
{
    [Fact]
    public void Lenient_unknown_element_roundtrips_via_overflow()
    {
        const string json = """{"family":"Doe","unknownExtra":"keep-me"}""";
        var name = FhirJsonSerializer.Deserialize<HumanName>(json, FhirSerializerOptions.Lenient);
        Assert.NotNull(name);
        Assert.Equal("Doe", name!.Family?.StringValue);
        Assert.True(name.TryGetValue("unknownExtra", out var extra));
        Assert.Equal("keep-me", extra is System.Text.Json.JsonElement el ? el.GetString() : extra?.ToString());

        var back = FhirJsonSerializer.Serialize(name, FhirSerializerOptions.Lenient);
        Assert.Contains("unknownExtra", back);
        Assert.Contains("keep-me", back);
    }

    [Fact]
    public void Strict_unknown_element_throws()
    {
        const string json = """{"family":"Doe","unknownExtra":"nope"}""";
        var ex = Assert.Throws<FhirSerializationException>(
            () => FhirJsonSerializer.Deserialize<HumanName>(json, FhirSerializerOptions.Strict));
        Assert.Contains("unknownExtra", ex.UnknownElements);
    }

    [Fact]
    public void Companion_underscore_is_not_unknown_in_strict()
    {
        const string json = """{"family":"Doe","_family":{"id":"f1"}}""";
        var name = FhirJsonSerializer.Deserialize<HumanName>(json, FhirSerializerOptions.Strict);
        Assert.NotNull(name);
        Assert.True(name!.TryGetValue("_family", out _));
        Assert.Empty(name.UnknownElementNames);
    }

    [Fact]
    public void DeepCopy_clones_overflow()
    {
        var name = FhirJsonSerializer.Deserialize<HumanName>(
            """{"family":"Doe","extra":1}""", FhirSerializerOptions.Lenient)!;
        var copy = (HumanName)name.DeepCopy();
        copy.SetValue("extra", 2);
        Assert.True(name.TryGetValue("extra", out var original));
        Assert.Equal(1, ((System.Text.Json.JsonElement)original!).GetInt32());
    }

    [Fact]
    public void EnumerateElements_includes_known_and_overflow()
    {
        var name = new HumanName { Family = new DataTypes.PrimitiveTypes.FhirString("X") };
        name.SetValue("extraFlag", true);
        var names = name.EnumerateElements().Select(kv => kv.Key).ToHashSet();
        Assert.Contains("family", names);
        Assert.Contains("extraFlag", names);
    }

    [Fact]
    public void Deferred_primitive_is_default()
    {
        Assert.Equal(PrimitiveTypedParseTiming.Deferred, PrimitiveTypeOptions.TypedParseTiming);
    }
}
