using System.Collections.Generic;

namespace FhirSDK.Resources.R5.Tests.Generic;

public class ResourceCase
{
    public string Name { get; set; } = string.Empty;
    public string? InputJson { get; set; } = string.Empty; // optional when Chain is provided
    public List<ChainStep>? Chain { get; set; } // optional chain for fluent construction
    public List<AssertSpec> Asserts { get; set; } = new();
}

public class ChainStep
{
    public string Call { get; set; } = string.Empty;
    public System.Text.Json.Nodes.JsonArray? Args { get; set; }
}

public class AssertSpec
{
    public string Path { get; set; } = string.Empty; // JSON Pointer like /name/0/family
    public new string? Equals { get; set; }
    public string? Contains { get; set; }
    public bool? Exists { get; set; }
}

