#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using FluentAssertions;
using Xunit;

namespace FhirSDK.Resources.Tests.Common;

public class VersionAgnosticExamplesTests
{
    private readonly Assembly _resources;
    private readonly string _ns;

    public VersionAgnosticExamplesTests()
    {
        // Try load in priority order; allows the same tests to run for whichever version is present
        string[] candidates = new[] { "FhirSDK.Resources.R6", "FhirSDK.Resources.R5", "FhirSDK.Resources.R4" };
        Assembly? loaded = null;
        foreach (var name in candidates)
        {
            try { loaded = Assembly.Load(name); if (loaded != null) break; }
            catch { /* ignore */ }
        }
        loaded.Should().NotBeNull("at least one FhirSDK.Resources.* assembly should be available");
        _resources = loaded!;
        _ns = _resources.GetName().Name!; // e.g., FhirSDK.Resources.R5
    }

    [Fact]
    public void AllRegistryResources_HaveAtLeastOneEmbeddedExample()
    {
        var registryType = _resources.GetTypes().FirstOrDefault(t => t.Name.StartsWith("ResourceRegistry_", StringComparison.Ordinal));
        registryType.Should().NotBeNull();
        var prop = registryType!.GetProperty("ResourceTypes", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
        prop.Should().NotBeNull();
        var resourceTypes = (IEnumerable<string>) (prop!.GetValue(null) ?? Array.Empty<string>());
        resourceTypes.Should().NotBeEmpty();

        var all = EmbeddedExampleLoader.ListAll(_resources).ToList();
        var grouped = all.GroupBy(e => e.Resource).ToDictionary(g => g.Key, g => g.ToList());

        foreach (var r in resourceTypes)
        {
            grouped.Keys.Should().Contain(r, $"resource {r} should have at least one embedded example");
            grouped[r].Should().NotBeEmpty();
        }
    }

    [Fact]
    public void EmbeddedExamples_CanInstantiate_And_MatchResourceType()
    {
        var all = EmbeddedExampleLoader.ListAll(_resources).ToList();
        all.Should().NotBeEmpty();

        foreach (var (resource, name, json) in all)
        {
            // find type by convention: Namespace.Resource
            var type = _resources.GetType($"{_ns}.{resource}");
            type.Should().NotBeNull($"resource type {_ns}.{resource} should exist");

            // Prefer ctor(string json)
            var ctor = type!.GetConstructor(new[] { typeof(string) });
            ctor.Should().NotBeNull($"{type} should have a (string json) constructor");
            var instance = ctor!.Invoke(new object?[] { json });

            // Assert ResourceType property matches
            var rtProp = type.GetProperty("ResourceType", BindingFlags.Public | BindingFlags.Instance);
            rtProp.Should().NotBeNull();
            var rt = (string?)rtProp!.GetValue(instance);
            rt.Should().Be(resource);

            // Basic JSON parse validity
            JsonNode.Parse(json).Should().NotBeNull();
        }
    }
}

