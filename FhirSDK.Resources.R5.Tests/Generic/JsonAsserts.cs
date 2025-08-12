using System.Collections.Generic;
using System.Text.Json.Nodes;
using Xunit;

namespace FhirSDK.Resources.R5.Tests.Generic;

public static class JsonAsserts
{
    public static void Run(JsonObject raw, IEnumerable<AssertSpec> asserts)
    {
        foreach (var a in asserts)
        {
            var node = JsonPointer.Select(raw, a.Path);
            if (a.Exists.HasValue)
            {
                if (a.Exists.Value) Assert.NotNull(node);
                else Assert.Null(node);
            }
            if (a.Equals != null)
            {
                if (a.Equals == "") // special case: expecting null/absent
                {
                    Assert.Null(node);
                }
                else
                {
                    Assert.NotNull(node);
                    string actual;
                    try { actual = node!.GetValue<string>(); }
                    catch { actual = node!.ToJsonString().Trim('"'); }
                    Assert.Equal(a.Equals, actual);
                }
            }
            if (a.Contains != null)
            {
                Assert.NotNull(node);
                string actual;
                try { actual = node!.GetValue<string>(); }
                catch { actual = node!.ToJsonString().Trim('"'); }
                Assert.Contains(a.Contains, actual);
            }
        }
    }
}

