using Fhir.Generator.Services;

namespace Examples;

/// <summary>
/// XML 文件註解生成範例
/// 展示如何正確生成符合 C# 規範的 XML 註解
/// </summary>
public class XmlDocumentationExample
{
    private readonly XmlDocumentationGenerator _docGenerator;
    private readonly FhirCompliantTypeMapper _typeMapper;

    public XmlDocumentationExample()
    {
        _docGenerator = new XmlDocumentationGenerator();
        _typeMapper = new FhirCompliantTypeMapper();
    }

    /// <summary>
    /// 展示基本類別註解生成
    /// </summary>
    public void BasicClassDocumentationExample()
    {
        // 原始 FHIR 描述（可能包含問題字元）
        var originalDescription = "Demographics and other administrative information about an individual or animal receiving care or other health-related services. <br/> This includes <strong>name</strong>, <em>address</em> & contact information.";

        // 生成清理後的註解
        var classDoc = _docGenerator.GenerateClassDocumentation(
            summary: originalDescription,
            remarks: "FHIR R4 Patient DomainResource",
            example: "var patient = new Patient { Active = true, Gender = \"male\" };"
        );

        Console.WriteLine("Generated Class Documentation:");
        Console.WriteLine(classDoc);
        Console.WriteLine();

        // 輸出結果：
        // /// <summary>
        // /// Demographics and other administrative information about an individual or animal 
        // /// receiving care or other health-related services. This includes name, address 
        // /// &amp; contact information.
        // /// </summary>
        // /// <remarks>
        // /// FHIR R4 Patient DomainResource
        // /// </remarks>
        // /// <example>
        // /// var patient = new Patient { Active = true, Gender = "male" };
        // /// </example>
    }

    /// <summary>
    /// 展示屬性註解生成
    /// </summary>
    public void PropertyDocumentationExample()
    {
        // 一般屬性
        var propertyDoc1 = _docGenerator.GeneratePropertyDocumentation(
            summary: "Whether this patient record is in active use. Many systems use this property to mark as non-current.",
            fhirPath: "Patient.active",
            cardinality: "0..1",
            isRequired: false
        );

        Console.WriteLine("Generated Property Documentation:");
        Console.WriteLine(propertyDoc1);
        Console.WriteLine();

        // 有型別限制的屬性
        var propertyDoc2 = _docGenerator.GeneratePropertyDocumentation(
            summary: "The organization that is the custodian of the patient record.",
            fhirPath: "Patient.managingOrganization",
            cardinality: "0..1",
            allowedTypes: new[] { "Organization" },
            isRequired: false
        );

        Console.WriteLine("Property with Type Restrictions:");
        Console.WriteLine(propertyDoc2);
        Console.WriteLine();
    }

    /// <summary>
    /// 展示 Choice Type 註解生成
    /// </summary>
    public void ChoiceTypeDocumentationExample()
    {
        // Extension.value[x] 的註解
        var choiceDoc = _docGenerator.GenerateChoiceTypeDocumentation(
            baseName: "value",
            allowedTypes: new[] { "string", "integer", "boolean", "CodeableConcept", "Quantity" },
            summary: "Value of extension - must be one of a constrained set of the data types."
        );

        Console.WriteLine("Generated Choice Type Documentation:");
        Console.WriteLine(choiceDoc);
        Console.WriteLine();

        // 輸出結果：
        // /// <summary>
        // /// Value of extension - must be one of a constrained set of the data types.
        // ///
        // /// Choice Type: value[x]
        // /// This is a choice element - only one of the following types may be present:
        // ///   - string
        // ///   - integer
        // ///   - boolean
        // ///   - CodeableConcept
        // ///   - Quantity
        // /// </summary>
    }

    /// <summary>
    /// 展示 Reference 註解生成
    /// </summary>
    public void ReferenceDocumentationExample()
    {
        var referenceDoc = _docGenerator.GenerateReferenceDocumentation(
            allowedTargets: new[] { "Patient", "Group", "Device", "Location" },
            summary: "The patient, or group of patients, location, or device this observation is about."
        );

        Console.WriteLine("Generated Reference Documentation:");
        Console.WriteLine(referenceDoc);
        Console.WriteLine();

        // 輸出結果：
        // /// <summary>
        // /// The patient, or group of patients, location, or device this observation is about.
        // ///
        // /// Reference to:
        // ///   - Patient
        // ///   - Group
        // ///   - Device
        // ///   - Location
        // /// </summary>
    }

    /// <summary>
    /// 展示方法註解生成
    /// </summary>
    public void MethodDocumentationExample()
    {
        var parameters = new Dictionary<string, string>
        {
            ["validationContext"] = "The validation context containing the resource data",
            ["includeWarnings"] = "Whether to include warnings in the validation results"
        };

        var methodDoc = _docGenerator.GenerateMethodDocumentation(
            summary: "Validates the resource according to FHIR rules and constraints.",
            parameters: parameters,
            returns: "A collection of validation results indicating any errors or warnings",
            exceptions: new[] { "ArgumentNullException", "InvalidOperationException" }
        );

        Console.WriteLine("Generated Method Documentation:");
        Console.WriteLine(methodDoc);
        Console.WriteLine();
    }

    /// <summary>
    /// 展示 BackboneElement 註解生成
    /// </summary>
    public void BackboneElementDocumentationExample()
    {
        var backboneDoc = _docGenerator.GenerateBackboneElementDocumentation(
            resourceName: "Patient",
            elementName: "Contact",
            summary: "A contact party (e.g. guardian, partner, friend) for the patient."
        );

        Console.WriteLine("Generated BackboneElement Documentation:");
        Console.WriteLine(backboneDoc);
        Console.WriteLine();
    }

    /// <summary>
    /// 展示問題字元處理
    /// </summary>
    public void ProblematicCharacterHandlingExample()
    {
        // 包含各種問題字元的原始文字
        var problematicText = @"Use <code>exact</code> for precise matching & validation. 
        This includes ""quoted text"" and 'single quotes'. 
        Special chars: < > & "" ' 
        HTML: <br/><strong>Bold</strong> <em>Italic</em>
        Unicode: "smart quotes" and 'smart apostrophes'
        Control chars: " + "\x01\x02\x03" + @"
        Very long text that should be wrapped automatically when it exceeds the maximum line length specified in the configuration settings for proper formatting and readability.";

        var cleanDoc = _docGenerator.GenerateClassDocumentation(
            summary: problematicText
        );

        Console.WriteLine("Cleaned Documentation:");
        Console.WriteLine(cleanDoc);
        Console.WriteLine();

        // 驗證生成的註解
        var isValid = _docGenerator.ValidateXmlDocumentation(cleanDoc);
        Console.WriteLine($"Generated documentation is valid: {isValid}");
        Console.WriteLine();
    }

    /// <summary>
    /// 展示整合型別映射器的註解生成
    /// </summary>
    public void IntegratedDocumentationExample()
    {
        // 使用型別映射器生成類別註解
        var classDoc = _typeMapper.GenerateClassDocumentation(
            fhirType: "Patient",
            description: "Demographics and other administrative information about an individual receiving care.",
            fhirVersion: "R4"
        );

        Console.WriteLine("Integrated Class Documentation:");
        Console.WriteLine(classDoc);
        Console.WriteLine();

        // 使用型別映射器生成屬性註解
        var propertyDoc = _typeMapper.GeneratePropertyDocumentation(
            propertyName: "active",
            fhirPath: "Patient.active",
            description: "Whether this patient record is in active use.",
            cardinality: "0..1",
            fhirType: "boolean",
            isRequired: false
        );

        Console.WriteLine("Integrated Property Documentation:");
        Console.WriteLine(propertyDoc);
        Console.WriteLine();

        // 生成 Choice Type 屬性註解
        var choicePropertyDoc = _typeMapper.GeneratePropertyDocumentation(
            propertyName: "deceased[x]",
            fhirPath: "Patient.deceased[x]",
            description: "Indicates if the individual is deceased or not.",
            cardinality: "0..1",
            fhirType: "boolean|dateTime",
            isRequired: false
        );

        Console.WriteLine("Integrated Choice Type Documentation:");
        Console.WriteLine(choicePropertyDoc);
        Console.WriteLine();
    }

    /// <summary>
    /// 展示完整的類別生成範例
    /// </summary>
    public void CompleteClassGenerationExample()
    {
        Console.WriteLine("Complete Generated Class Example:");
        Console.WriteLine();

        // 類別註解
        var classDoc = _typeMapper.GenerateClassDocumentation(
            fhirType: "Patient",
            description: "Demographics and other administrative information about an individual or animal receiving care or other health-related services.",
            fhirVersion: "R4"
        );

        Console.WriteLine(classDoc);
        Console.WriteLine("public class Patient : DomainResource");
        Console.WriteLine("{");

        // 屬性註解範例
        var activeDoc = _typeMapper.GeneratePropertyDocumentation(
            propertyName: "active",
            fhirPath: "Patient.active",
            description: "Whether this patient record is in active use.",
            cardinality: "0..1",
            fhirType: "boolean"
        );

        Console.WriteLine("    " + activeDoc.Replace("\n", "\n    "));
        Console.WriteLine("    [JsonPropertyName(\"active\")]");
        Console.WriteLine("    public bool? Active { get; set; }");
        Console.WriteLine();

        // Choice Type 屬性範例
        var deceasedDoc = _typeMapper.GeneratePropertyDocumentation(
            propertyName: "deceased[x]",
            fhirPath: "Patient.deceased[x]",
            description: "Indicates if the individual is deceased or not.",
            cardinality: "0..1",
            fhirType: "boolean|dateTime"
        );

        Console.WriteLine("    " + deceasedDoc.Replace("\n", "\n    "));
        Console.WriteLine("    [JsonIgnore]");
        Console.WriteLine("    public ChoiceType<FhirBoolean, FhirDateTime>? DeceasedChoice { get; set; }");
        Console.WriteLine();

        Console.WriteLine("}");
    }

    /// <summary>
    /// 展示驗證功能
    /// </summary>
    public void ValidationExample()
    {
        // 有效的 XML 註解
        var validDoc = @"/// <summary>
/// This is a valid XML documentation comment.
/// </summary>";

        // 無效的 XML 註解
        var invalidDoc = @"/// <summary>
/// This contains invalid XML: <unclosed tag
/// </summary>";

        Console.WriteLine($"Valid documentation: {_docGenerator.ValidateXmlDocumentation(validDoc)}");
        Console.WriteLine($"Invalid documentation: {_docGenerator.ValidateXmlDocumentation(invalidDoc)}");
    }
}
