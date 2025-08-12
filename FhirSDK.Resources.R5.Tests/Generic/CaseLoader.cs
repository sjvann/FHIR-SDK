using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace FhirSDK.Resources.R5.Tests.Generic;

public static class CaseLoader
{
    public static IEnumerable<object[]> LoadCases()
    {
        var root = Path.Combine(TestContext.ProjectRoot, "FhirSDK.Resources.R5.Tests", "Data", "R5");
        if (!Directory.Exists(root)) yield break;

        foreach (var file in Directory.EnumerateFiles(root, "*.json", SearchOption.AllDirectories))
        {
            var json = File.ReadAllText(file);
            var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var rc = JsonSerializer.Deserialize<ResourceCase>(json, opts);
            if (rc != null)
                yield return new object[] { file, rc };
        }
    }
}

internal static class TestContext
{
    public static string ProjectRoot => FindRoot(Directory.GetCurrentDirectory());

    private static string FindRoot(string start)
    {
        var dir = new DirectoryInfo(start);
        while (dir != null)
        {
            if (File.Exists(Path.Combine(dir.FullName, "FhirSDK.Resources.R5.Tests", "FhirSDK.Resources.R5.Tests.csproj")))
                return dir.FullName;
            dir = dir.Parent!;
        }
        return start;
    }
}

