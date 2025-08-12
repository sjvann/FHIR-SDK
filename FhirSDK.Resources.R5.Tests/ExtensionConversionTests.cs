using System;
using Xunit;
using DataTypeServices.Extensions;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace FhirSDK.Resources.R5.Tests;

public class ExtensionConversionTests
{
    [Fact]
    public void CSharp_Primitives_To_Fhir_Primitives_Extensions_Work()
    {
        string s = "hello";
        bool b = true;
        int n = 42;
        decimal d = 12.34m;
        DateTime dt = new DateTime(2020, 2, 29, 13, 45, 0, DateTimeKind.Utc);
        var uri = new Uri("https://example.com");
        var guid = Guid.Parse("12345678-1234-1234-1234-1234567890ab");

        FhirString fs = s.ToFhirString();
        FhirCode fc = s.ToFhirCode();
        FhirUri fu1 = s.ToFhirUri();
        FhirBoolean fb = b.ToFhirBoolean();
        FhirInteger fi = n.ToFhirInteger();
        FhirDecimal fdec = d.ToFhirDecimal();
        FhirDateTime fdt = dt.ToFhirDateTime();
        FhirDate fdate = dt.ToFhirDate();
        FhirUri fu2 = uri.ToFhirUri();
        FhirUuid fuid = guid.ToFhirUuid();

        Assert.Equal("hello", fs.Value);
        Assert.Equal("hello", fc.Value);
        Assert.Equal("hello", fu1.Value);
        Assert.True(fb.Value);
        Assert.Equal(42, fi.Value);
        Assert.Equal(12.34m, fdec.Value);
        var fdtString = fdt.ToJsonString();
        Assert.Contains("2020", fdtString);
        var fdateString = fdate.GetJsonValue()!.GetValue<string>();
        Assert.Equal("2020-02-29", fdateString);
        Assert.StartsWith("https://example.com", fu2.Value);
        Assert.StartsWith("urn:uuid:", fuid.Value);
    }
}

