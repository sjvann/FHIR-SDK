using System.Collections.Generic;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirSDK.Resources.R5.Tests.TestHelpers;

public static class ResourceTestHelpers
{
    // Assert that a primitive element writes both value and underscore sibling when element metadata exists
    public static void AssertPrimitiveWithElement(JsonObject raw, string name, string expectedValue)
    {
        var val = raw[name];
        var elem = raw[$"_{name}"];
        Xunit.Assert.NotNull(val);
        Xunit.Assert.Equal(expectedValue, val!.GetValue<string>());
        Xunit.Assert.NotNull(elem);
        Xunit.Assert.NotNull(elem!["id"]);
    }

    // For arrays of primitives: ensure underscore array aligns with values
    public static void AssertPrimitiveArrayWithElements(JsonObject raw, string name, params string?[] expected)
    {
        var values = raw[name]!.AsArray();
        Xunit.Assert.Equal(expected.Length, values.Count);
        var elems = raw[$"_{name}"] as JsonArray;
        if (elems != null)
        {
            Xunit.Assert.Equal(expected.Length, elems.Count);
        }
    }

    // Utility: get camel-case JSON name from C# property name
    public static string ToJsonName(string prop) => string.IsNullOrEmpty(prop) ? prop : char.ToLowerInvariant(prop[0]) + prop.Substring(1);
}

