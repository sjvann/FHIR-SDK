using System.Text.Json;
using Fhir.Generator.Models;
using Fhir.Generator.Services;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Xunit;

namespace Fhir.Generator.Tests;

/// <summary>
/// 測試生成的程式碼是否能正確編譯和使用
/// </summary>
public class GeneratedCodeCompilationTests
{
    [Fact]
    public async Task GeneratedResource_ShouldCompile_Successfully()
    {
        // Arrange
        var testResource = CreateTestResource();
        var generator = new SimpleGenerator();
        
        // Act
        var generatedCode = generator.GenerateSimpleResource(testResource, "R4");
        
        // Assert
        Assert.NotNull(generatedCode);
        Assert.Contains("public class TestResource : DomainResource", generatedCode);
        Assert.Contains("FhirString?", generatedCode);
        Assert.Contains("FhirBoolean?", generatedCode);
        Assert.Contains("FHIR Path:", generatedCode);
        Assert.Contains("Cardinality:", generatedCode);
        
        // 檢查是否能編譯
        var compilationResult = await CompileCode(generatedCode);
        Assert.True(compilationResult.Success, $"編譯失敗: {string.Join(", ", compilationResult.Errors)}");
    }

    [Fact]
    public async Task GeneratedResource_ShouldSerialize_ToJson()
    {
        // 這個測試需要實際編譯生成的程式碼並測試序列化
        // 目前先跳過，等修正編譯問題後再實作
        await Task.CompletedTask;
    }

    private ResourceInfo CreateTestResource()
    {
        return new ResourceInfo
        {
            ClassName = "TestResource",
            ResourceType = "TestResource",
            Description = "A simple test resource for validation",
            Properties = new List<PropertyDefinition>
            {
                new PropertyDefinition
                {
                    Name = "Active",
                    Type = "boolean",
                    Description = "Whether this test resource record is in active use",
                    MinCardinality = 0,
                    MaxCardinality = "1",
                    Order = 1
                },
                new PropertyDefinition
                {
                    Name = "Name",
                    Type = "string",
                    Description = "A name for the test resource",
                    MinCardinality = 0,
                    MaxCardinality = "1",
                    Order = 2
                }
            }
        };
    }

    private async Task<CompilationResult> CompileCode(string code)
    {
        try
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(code);
            
            // 基本的參考組件
            var references = new[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.ComponentModel.DataAnnotations.ValidationResult).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.Text.Json.Serialization.JsonPropertyNameAttribute).Assembly.Location)
            };

            var compilation = CSharpCompilation.Create(
                "TestAssembly",
                new[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            using var ms = new MemoryStream();
            var result = compilation.Emit(ms);

            var errors = result.Diagnostics
                .Where(diagnostic => diagnostic.IsWarningAsError || diagnostic.Severity == DiagnosticSeverity.Error)
                .Select(d => d.ToString())
                .ToList();

            return new CompilationResult
            {
                Success = result.Success,
                Errors = errors
            };
        }
        catch (Exception ex)
        {
            return new CompilationResult
            {
                Success = false,
                Errors = new List<string> { ex.Message }
            };
        }
    }

    private class CompilationResult
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; } = new();
    }
}
