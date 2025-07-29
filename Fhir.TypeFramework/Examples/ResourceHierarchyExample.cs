using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// FHIR 資源層次結構使用範例
/// 展示 Resource -> DomainResource -> CanonicalResource -> MetadataResource 的繼承關係
/// </summary>
public static class ResourceHierarchyExample
{
    /// <summary>
    /// 展示基本的 Resource 使用
    /// </summary>
    public static void DemonstrateResource()
    {
        Console.WriteLine("=== Resource 範例 ===");
        
        // 創建一個基本的 Resource（需要具體實作）
        var resource = new ExampleResource
        {
            Id = "example-123",
            Meta = new Meta
            {
                VersionId = "1",
                LastUpdated = DateTime.UtcNow
            },
            ImplicitRules = "https://example.com/rules",
            Language = "zh-TW"
        };

        Console.WriteLine($"Resource ID: {resource.Id}");
        Console.WriteLine($"Resource Type: {resource.ResourceType}");
        Console.WriteLine($"Has Meta: {resource.HasMeta}");
        Console.WriteLine($"Has ImplicitRules: {resource.HasImplicitRules}");
        Console.WriteLine($"Has Language: {resource.HasLanguage}");
    }

    /// <summary>
    /// 展示 DomainResource 的使用
    /// </summary>
    public static void DemonstrateDomainResource()
    {
        Console.WriteLine("\n=== DomainResource 範例 ===");
        
        var domainResource = new ExampleDomainResource
        {
            Id = "domain-example-123",
            Text = new Narrative
            {
                Status = "generated",
                Div = "<div>這是一個範例 DomainResource</div>"
            }
        };

        // 添加擴展
        domainResource.AddExtension("https://example.com/extension", "extension-value");
        domainResource.AddModifierExtension("https://example.com/modifier", "modifier-value");

        // 添加內含資源
        var containedResource = new ExampleResource { Id = "contained-1" };
        domainResource.Contained = new List<Resource> { containedResource };

        Console.WriteLine($"DomainResource ID: {domainResource.Id}");
        Console.WriteLine($"Has Text: {domainResource.HasText}");
        Console.WriteLine($"Has Extensions: {domainResource.HasExtensions}");
        Console.WriteLine($"Has ModifierExtensions: {domainResource.HasModifierExtensions}");
        Console.WriteLine($"Has Contained: {domainResource.HasContained}");
    }

    /// <summary>
    /// 展示 CanonicalResource 的使用
    /// </summary>
    public static void DemonstrateCanonicalResource()
    {
        Console.WriteLine("\n=== CanonicalResource 範例 ===");
        
        var canonicalResource = new ExampleCanonicalResource
        {
            Id = "canonical-example-123",
            Url = "https://example.com/canonical-resource",
            Version = "1.0.0",
            Name = "ExampleCanonicalResource",
            Title = "範例規範資源",
            Status = "active",
            Experimental = false,
            Date = DateTime.UtcNow,
            Publisher = "範例出版社",
            Description = "這是一個範例規範資源"
        };

        // 添加聯絡資訊
        var contact = new ContactDetail
        {
            Name = "聯絡人",
            Telecom = new List<ContactPoint>
            {
                new ContactPoint { System = "phone", Value = "+886-2-1234-5678" },
                new ContactPoint { System = "email", Value = "contact@example.com" }
            }
        };
        canonicalResource.Contact = new List<ContactDetail> { contact };

        // 添加使用上下文
        var usageContext = new UsageContext();
        usageContext.Code = new Coding
        {
            System = "http://terminology.hl7.org/CodeSystem/usage-context-type",
            Code = "focus",
            Display = "Clinical Focus"
        };
        usageContext.SetValue(new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://terminology.hl7.org/CodeSystem/condition-clinical",
                    Code = "active",
                    Display = "Active"
                }
            }
        });
        canonicalResource.UseContext = new List<UsageContext> { usageContext };

        Console.WriteLine($"CanonicalResource ID: {canonicalResource.Id}");
        Console.WriteLine($"URL: {canonicalResource.Url}");
        Console.WriteLine($"Version: {canonicalResource.Version}");
        Console.WriteLine($"Name: {canonicalResource.Name}");
        Console.WriteLine($"Status: {canonicalResource.Status}");
        Console.WriteLine($"Has Contact: {canonicalResource.Contact?.Any() == true}");
        Console.WriteLine($"Has UseContext: {canonicalResource.UseContext?.Any() == true}");
    }

    /// <summary>
    /// 展示 MetadataResource 的使用
    /// </summary>
    public static void DemonstrateMetadataResource()
    {
        Console.WriteLine("\n=== MetadataResource 範例 ===");
        
        var metadataResource = new ExampleMetadataResource
        {
            Id = "metadata-example-123",
            ApprovalDate = DateTime.Today.AddDays(-30),
            LastReviewDate = DateTime.Today.AddDays(-7),
            EffectivePeriod = new Period
            {
                Start = DateTime.Today,
                End = DateTime.Today.AddYears(1)
            }
        };

        // 添加主題
        var topic = new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = "http://terminology.hl7.org/CodeSystem/definition-topic",
                    Code = "treatment",
                    Display = "Treatment"
                }
            }
        };
        metadataResource.Topic = new List<CodeableConcept> { topic };

        // 添加作者
        var author = new ContactDetail
        {
            Name = "作者",
            Telecom = new List<ContactPoint>
            {
                new ContactPoint { System = "email", Value = "author@example.com" }
            }
        };
        metadataResource.Author = new List<ContactDetail> { author };

        // 添加相關文件
        var relatedArtifact = new RelatedArtifact
        {
            Type = "citation",
            Label = "參考文獻",
            Citation = "這是一個參考文獻",
            Url = "https://example.com/reference"
        };
        metadataResource.RelatedArtifact = new List<RelatedArtifact> { relatedArtifact };

        Console.WriteLine($"MetadataResource ID: {metadataResource.Id}");
        Console.WriteLine($"Approval Date: {metadataResource.ApprovalDate}");
        Console.WriteLine($"Last Review Date: {metadataResource.LastReviewDate}");
        Console.WriteLine($"Has Effective Period: {metadataResource.EffectivePeriod != null}");
        Console.WriteLine($"Has Topic: {metadataResource.Topic?.Any() == true}");
        Console.WriteLine($"Has Author: {metadataResource.Author?.Any() == true}");
        Console.WriteLine($"Has Related Artifacts: {metadataResource.RelatedArtifact?.Any() == true}");
    }

    /// <summary>
    /// 執行所有範例
    /// </summary>
    public static void RunAllExamples()
    {
        DemonstrateResource();
        DemonstrateDomainResource();
        DemonstrateCanonicalResource();
        DemonstrateMetadataResource();
    }
}

/// <summary>
/// 範例 Resource 實作
/// </summary>
public class ExampleResource : Resource
{
    public override string ResourceType => "ExampleResource";
}

/// <summary>
/// 範例 DomainResource 實作
/// </summary>
public class ExampleDomainResource : DomainResource
{
    public override string ResourceType => "ExampleDomainResource";
}

/// <summary>
/// 範例 CanonicalResource 實作
/// </summary>
public class ExampleCanonicalResource : CanonicalResource
{
    public override string ResourceType => "ExampleCanonicalResource";
}

/// <summary>
/// 範例 MetadataResource 實作
/// </summary>
public class ExampleMetadataResource : MetadataResource
{
    public override string ResourceType => "ExampleMetadataResource";
} 