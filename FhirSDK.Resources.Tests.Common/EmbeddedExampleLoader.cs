#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FhirSDK.Resources.Tests.Common;

public static class EmbeddedExampleLoader
{
    public static IEnumerable<(string Resource, string Name, string Json)> ListAll(Assembly resourceAssembly)
    {
        var prefix = resourceAssembly.GetName().Name + ".Examples."; // e.g., FhirSDK.Resources.R5.Examples.
        foreach (var name in resourceAssembly.GetManifestResourceNames())
        {
            if (!name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase) || !name.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                continue;
            using var s = resourceAssembly.GetManifestResourceStream(name);
            if (s is null) continue;
            using var sr = new StreamReader(s);
            var json = sr.ReadToEnd();
            // name: FhirSDK.Resources.R5.Examples.Patient.basic.json
            var parts = name.Split('.');
            // ... Examples . {Resource} . {example} . json
            var resource = parts[^3];
            var example = parts[^2];
            yield return (resource, example, json);
        }
    }
}

