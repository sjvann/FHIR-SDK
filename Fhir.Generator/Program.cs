using System.CommandLine;
using Fhir.Generator.Services;

namespace Fhir.Generator;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var rootCommand = new RootCommand();
        var versionOption = new Option<string>(new[] { "--fhir-version" }) { IsRequired = true };
        var inputOption = new Option<FileInfo>(new[] { "--definition-file" }) { IsRequired = true };
        
        rootCommand.AddOption(versionOption);
        rootCommand.AddOption(inputOption);
        
        rootCommand.SetHandler(async (invocationContext) =>
        {
            var fhirVersion = invocationContext.ParseResult.GetValueForOption(versionOption);
            var inputFile = invocationContext.ParseResult.GetValueForOption(inputOption);

            Console.WriteLine($"🚀 Starting FHIR Code Generation for {fhirVersion}...");

            var processor = new FhirDefinitionProcessor();
            var schema = await processor.ProcessDefinitionsAsync(inputFile!.FullName, fhirVersion!);

            Console.WriteLine($"✅ Processed {schema.DataTypes.Count} data types");
            Console.WriteLine($"✅ Processed {schema.Resources.Count} resources");
            Console.WriteLine($"✅ Processed {schema.ValueSets.Count} value sets");

            var outputDir = Path.Combine("Core", fhirVersion!);
            Directory.CreateDirectory(outputDir);

            var codeGenerator = new FhirCodeGenerator();
            await codeGenerator.GenerateAllAsync(schema, outputDir);

            Console.WriteLine("🎉 Code generation completed successfully!");
        });
        
        return await rootCommand.InvokeAsync(args);
    }
}
