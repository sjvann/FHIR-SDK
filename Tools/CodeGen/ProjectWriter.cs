using System.Text;

namespace CodeGen;

internal static class ProjectWriter
{
    public static string EnsureProjectFileAndReferences(string outputProjectArg, string version)
    {
        string csprojPath;
        if (File.Exists(outputProjectArg) && outputProjectArg.EndsWith(".csproj", StringComparison.OrdinalIgnoreCase))
        {
            csprojPath = Path.GetFullPath(outputProjectArg);
        }
        else if (Directory.Exists(outputProjectArg))
        {
            var dir = Path.GetFullPath(outputProjectArg);
            var name = $"FhirSDK.Resources.{version}";
            csprojPath = Path.Combine(dir, $"{name}.csproj");
            if (!File.Exists(csprojPath))
            {
                var sbp = new StringBuilder();
                sbp.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
                sbp.AppendLine("  <PropertyGroup>");
                sbp.AppendLine("    <TargetFramework>net9.0</TargetFramework>");
                sbp.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
                sbp.AppendLine("    <Nullable>enable</Nullable>");
                sbp.AppendLine("    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>");
                sbp.AppendLine($"    <Title>FhirSDK.Resources.{version}</Title>");
                sbp.AppendLine("    <Authors>sjvann</Authors>");
                sbp.AppendLine($"    <Description>FHIR SDK {version} resource models (auto-generated)</Description>");
                sbp.AppendLine("    <Version>0.1.0</Version>");
                sbp.AppendLine($"    <PackageId>FhirSDK.Resources.{version}</PackageId>");
                sbp.AppendLine("    <GenerateDocumentationFile>true</GenerateDocumentationFile>");
                sbp.AppendLine("    <DocumentationFile>bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml</DocumentationFile>");
                sbp.AppendLine("    <NoWarn>$(NoWarn);1591</NoWarn>");
                sbp.AppendLine("  </PropertyGroup>");
                sbp.AppendLine("  <ItemGroup>");
                sbp.AppendLine("    <ProjectReference Include=\"..\\FhirCore\\FhirCore.csproj\" />");
                sbp.AppendLine("    <ProjectReference Include=\"..\\DataTypeServices\\DataTypeServices.csproj\" />");
                sbp.AppendLine("    <ProjectReference Include=\"..\\Fhir.TypeFramework\\Fhir.TypeFramework.csproj\" />");
                sbp.AppendLine("  </ItemGroup>");
                sbp.AppendLine("</Project>");
                Directory.CreateDirectory(dir);
                File.WriteAllText(csprojPath, sbp.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
                Console.WriteLine($"[CodeGen] Created project file: {csprojPath}");
            }
        }
        else
        {
            throw new DirectoryNotFoundException($"Output project not found: {outputProjectArg}");
        }

        var xml = File.ReadAllText(csprojPath);
        bool changed = false;

        // Remove any accidental reference to Fhir.TypeFramework in resource-only project
        if (xml.IndexOf("Fhir.TypeFramework.csproj", StringComparison.OrdinalIgnoreCase) >= 0)
        {
            var lines = xml.Split(new[] {"\r\n", "\n"}, StringSplitOptions.None);
            var filtered = new List<string>(lines.Length);
            foreach (var l in lines)
            {
                if (l.IndexOf("Fhir.TypeFramework.csproj", StringComparison.OrdinalIgnoreCase) < 0)
                    filtered.Add(l);
                else
                    changed = true;
            }
            xml = string.Join("\n", filtered);
        }

        string[] requiredRefs = new[]
        {
            "..\\FhirCore\\FhirCore.csproj",
            "..\\DataTypeServices\\DataTypeServices.csproj"
        };
        foreach (var r in requiredRefs)
        {
            if (!xml.Contains(r, StringComparison.OrdinalIgnoreCase))
            {
                if (xml.Contains("</ItemGroup>", StringComparison.OrdinalIgnoreCase))
                {
                    xml = xml.Replace("</ItemGroup>", $"  <ProjectReference Include=\"{r}\" />\n  </ItemGroup>");
                }
                else
                {
                    var insert = $"  <ItemGroup>\n    <ProjectReference Include=\"{r}\" />\n  </ItemGroup>\n";
                    xml = xml.Replace("</Project>", insert + "</Project>");
                }
                changed = true;
            }
        }
        if (changed)
        {
            File.WriteAllText(csprojPath, xml, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
            Console.WriteLine($"[CodeGen] Updated project references in: {csprojPath}");
        }

        return csprojPath;
    }
}

