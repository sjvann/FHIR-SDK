using System.Linq;
using System.Text.Json.Nodes;
using FhirSDK.Resources.R5;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;
using Xunit;

namespace FhirSDK.Resources.R5.Tests;

public class PrimitiveJsonSyncTests
{
    [Fact]
    public void Gender_Primitive_WithElement_ShouldCreateUnderscoreSibling()
    {
        var p = new Patient();
        var gender = new FhirCode("male");
        // Set element metadata via Element base properties (synchronous)
        gender.Id = new FhirString("a1");
        p.Gender = gender;

        var raw = p.Raw!;
        Assert.Equal("male", raw["gender"]!.GetValue<string>());
        Assert.NotNull(raw["_gender"]);
        var idNode = raw["_gender"]!["id"];
        Assert.NotNull(idNode);
        Assert.Equal("a1", idNode!.GetValue<string>());
    }

    [Fact]
    public void Organization_Alias_PrimitiveArray_WithElements_ShouldCreateUnderscoreArray()
    {
        var org = new Organization();
        var s1 = new FhirString("A");
        var s2 = new FhirString("B");
        s2.Id = new FhirString("x2");
        org.Alias = new List<FhirString> { s1, s2 };

        var raw = org.Raw!;
        var values = raw["alias"]!.AsArray();
        Assert.Equal(2, values.Count);
        Assert.Equal("A", values[0]!.GetValue<string>());
        Assert.Equal("B", values[1]!.GetValue<string>());

        var elems = (JsonArray?)raw["_alias"];
        Assert.NotNull(elems);
        Assert.Equal(2, elems!.Count);
        Assert.Null(elems[0]);
        Assert.Equal("x2", elems[1]!["id"]!.GetValue<string>());
    }

    [Fact]
    public void Telecom_ComplexArray_ShouldNotCreateTopLevelUnderscore()
    {
        var p = new Patient();
        p.Telecom = new List<ContactPoint>
        {
            new ContactPoint { Value = new FhirString("1111") },
            new ContactPoint { Value = new FhirString("2222") },
            new ContactPoint { Value = new FhirString("3333") },
        };

        var raw = p.Raw!;
        var values = raw["telecom"]!.AsArray();
        Assert.Equal(3, values.Count);
        var elems = raw["_telecom"] as JsonArray;
        Assert.Null(elems);
    }
}

