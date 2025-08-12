using System.Collections.Generic;
using System.IO;
using Xunit;

namespace FhirSDK.Resources.R5.Tests.Generic;

public class ResourceE2ERunner
{
    public static IEnumerable<object[]> AllCases() => CaseLoader.LoadCases();

    [Theory]
    [MemberData(nameof(AllCases))]
    public void Run_All_Resource_Cases(string filePath, ResourceCase c)
    {
        var resource = ResourceFactory.Create(filePath, c);
        var rawProp = resource.GetType().GetProperty("Raw");
        var raw = (System.Text.Json.Nodes.JsonObject?)rawProp!.GetValue(resource);
        Assert.NotNull(raw);

        JsonAsserts.Run(raw!, c.Asserts);
    }
}

