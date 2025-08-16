#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// Usage: dotnet run --project Tools/ExamplesFiller/ExamplesFiller.csproj -- FhirSDK.Resources.R5/Generated/ResourceRegistry.R5.g.cs FhirSDK.Resources.R5/Examples
var args0 = args.Length >= 1 ? args[0] : "FhirSDK.Resources.R5/Generated/ResourceRegistry.R5.g.cs";
var args1 = args.Length >= 2 ? args[1] : "FhirSDK.Resources.R5/Examples";

if (!File.Exists(args0))
{
    Console.Error.WriteLine($"Registry file not found: {args0}");
    return 2;
}

if (!Directory.Exists(args1))
{
    Directory.CreateDirectory(args1);
}

var text = File.ReadAllText(args0);
var matches = Regex.Matches(text, "\"([A-Za-z][A-Za-z0-9]+)\"");
var names = matches.Select(m => m.Groups[1].Value).Distinct().ToList();

int created = 0;
foreach (var n in names)
{
    var dir = Path.Combine(args1, n);
    Directory.CreateDirectory(dir);
    var hasAny = Directory.EnumerateFiles(dir, "*.json", SearchOption.TopDirectoryOnly).Any();
    if (!hasAny)
    {
        var basicJson = $"{{\"resourceType\":\"{n}\"}}\n";
        File.WriteAllText(Path.Combine(dir, "basic.json"), basicJson);
        created++;
    }
}
Console.WriteLine($"[ExamplesFiller] Added {created} basic examples. Total resources = {names.Count}");
return 0;

