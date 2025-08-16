#nullable enable
using System.Reflection;
using System.Linq;
using System.IO;
using FluentAssertions;
using FhirSDK.Resources.Tests.Common;
using Xunit;

namespace FhirSDK.Resources.Tests;

public class VersionAgnosticSmokeTests
{
    private readonly Assembly _resources;

    public VersionAgnosticSmokeTests()
    {
        // Try load by reference first
        string[] candidates = new[] { "FhirSDK.Resources.R6", "FhirSDK.Resources.R5", "FhirSDK.Resources.R4" };
        foreach (var name in candidates)
        {
            try { _resources = Assembly.Load(name); return; } catch { }
        }
        // Fallback: scan test bin directory for any FhirSDK.Resources.*.dll
        var baseDir = Path.GetDirectoryName(typeof(VersionAgnosticSmokeTests).Assembly.Location)!;
        var dll = Directory.GetFiles(baseDir, "FhirSDK.Resources.*.dll").FirstOrDefault();
        if (dll != null)
        {
            _resources = Assembly.LoadFrom(dll);
            return;
        }
        throw new System.Exception("No resources assembly found");
    }

    [Fact]
    public void EveryEmbeddedExample_ParsesAndMatchesResourceType()
    {
        var all = EmbeddedExampleLoader.ListAll(_resources).ToList();
        all.Should().NotBeEmpty();

        foreach (var (resource, name, json) in all)
        {
            var type = _resources.GetType($"{_resources.GetName().Name}.{resource}");
            type.Should().NotBeNull();
            var ctor = type!.GetConstructor(new[] { typeof(string) });
            ctor.Should().NotBeNull();
            var instance = ctor!.Invoke(new object?[] { json });
            var rtProp = type.GetProperty("ResourceType");
            ((string?)rtProp!.GetValue(instance)).Should().Be(resource);
        }
    }

    [Fact]
    public void AllRegistryResources_HaveAtLeastOneEmbeddedExample()
    {
        var asm = _resources;
        var registry = asm.GetTypes().First(t => t.Name.StartsWith("ResourceRegistry_"));
        var resTypes = (System.Collections.Generic.IEnumerable<string>) (registry.GetProperty("ResourceTypes", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static)!.GetValue(null)!);
        var grouped = EmbeddedExampleLoader.ListAll(asm).GroupBy(x => x.Resource).ToDictionary(g => g.Key, g => g.ToList());
        foreach (var r in resTypes)
        {
            grouped.Keys.Should().Contain(r);
            grouped[r].Should().NotBeEmpty();
        }
    }
}
