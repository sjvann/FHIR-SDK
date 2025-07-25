using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

/// <summary>
/// 完全符合 FHIR 官方規範的型別映射器
/// 基於 https://hl7.org/fhir/datatypes.html 的完整實作
/// 不簡化任何 FHIR 型別系統的複雜性
///
/// 重要設計原則：
/// 1. FHIR Primitive Types 加上 "Fhir" 前綴避免與程式語言原生型別衝突
///    - FHIR "boolean" → C# "FhirBoolean" (避免與 C# bool 衝突)
///    - FHIR "string" → C# "FhirString" (避免與 C# string 衝突)
///    - FHIR "integer" → C# "FhirInteger" (避免與 C# int 衝突)
/// 2. 在對應時，FHIR 官方文件使用原本名稱，但生成的 C# 類別使用前綴版本
/// 3. 每個 FhirXxx 類別內部包含對應的 C# 原生型別作為 Value 屬性
/// 4. Extension 直接繼承 Base 而非 DataType，避免與 Element 的循環依賴
///    - Element 包含 extension: List<Extension>
///    - DataType 繼承 Element
///    - Extension 如果繼承 DataType 會造成循環：Extension → DataType → Element → Extension
/// 5. Resource 抽象類別使用 ResourceWrapper 解決實例化問題
///    - Resource 和 DomainResource 是抽象的，無法直接實例化
///    - Bundle.entry.resource 等屬性需要具體實例
///    - 使用 ResourceWrapper 包裝任何具體 Resource，提供統一介面
/// 6. BackboneElement 正確實作為 Resource 特定的內部結構
///    - 繼承 Element，支援 id 和 extension
///    - 額外支援 modifierExtension（可以改變父元素語義）
///    - 每個 Resource 的 BackboneElement 都是獨特的類別（如 Patient.Contact, Bundle.Entry）
/// 7. Reference 使用強型別泛型系統確保型別安全
///    - Reference<Patient> 只能參照 Patient
///    - Reference<Patient, Group> 可以參照 Patient 或 Group
///    - 編譯時期強制執行 FHIR 的參照限制，確保開發者遵守規範
/// 8. Choice Types ([x] 型別) 使用強型別泛型系統確保型別安全和互斥性
///    - ChoiceType<string, int> 只能設定 string 或 int，不能同時設定
///    - 自動處理 JSON 序列化（valueString, valueInteger）
///    - 編譯時期強制執行允許的型別，確保開發者在有限集合中選擇
/// </summary>
public class FhirCompliantTypeMapper
{
    private readonly Dictionary<string, FhirTypeMapping> _typeMappings;
    private readonly Dictionary<string, ChoiceTypeDefinition> _choiceTypes;
    private readonly Dictionary<string, ReferenceTypeDefinition> _referenceTypes;
    private readonly Dictionary<string, AbstractTypeMapping> _abstractTypeMappings;
    private readonly XmlDocumentationGenerator _docGenerator;

    public FhirCompliantTypeMapper()
    {
        _typeMappings = InitializeTypeMappings();
        _choiceTypes = InitializeChoiceTypes();
        _referenceTypes = InitializeReferenceTypes();
        _abstractTypeMappings = InitializeAbstractTypeMappings();
        _docGenerator = new XmlDocumentationGenerator();
    }

    /// <summary>
    /// 初始化完整的 FHIR 型別映射
    /// 基於官方 FHIR 規範
    /// </summary>
    private Dictionary<string, FhirTypeMapping> InitializeTypeMappings()
    {
        var mappings = new Dictionary<string, FhirTypeMapping>();

        // ===== 基礎抽象型別 =====
        mappings["Base"] = new FhirTypeMapping
        {
            FhirType = "Base",
            CSharpType = "Base",
            BaseType = "",
            Category = FhirTypeCategory.Base,
            IsAbstract = true,
            Description = "Base definition for all types defined in FHIR type system"
        };

        mappings["Element"] = new FhirTypeMapping
        {
            FhirType = "Element",
            CSharpType = "Element",
            BaseType = "Base",
            Category = FhirTypeCategory.Base,
            IsAbstract = true,
            SupportsExtensions = true,
            Description = "Base definition for all elements in a resource"
        };

        // Extension 直接繼承 Base，打破與 Element 的循環依賴
        mappings["Extension"] = new FhirTypeMapping
        {
            FhirType = "Extension",
            CSharpType = "Extension",
            BaseType = "Base",  // 重要：直接繼承 Base，不是 DataType
            Category = FhirTypeCategory.SpecialPurpose,
            IsAbstract = false,
            SupportsExtensions = true,  // Extension 可以有子 Extension
            Description = "Optional Extension Element - may be used to represent additional information"
        };

        mappings["DataType"] = new FhirTypeMapping
        {
            FhirType = "DataType",
            CSharpType = "DataType",
            BaseType = "Element",
            Category = FhirTypeCategory.DataType,
            IsAbstract = true,
            Description = "The base class for all re-usable types defined as part of the FHIR Specification"
        };

        mappings["PrimitiveType"] = new FhirTypeMapping
        {
            FhirType = "PrimitiveType",
            CSharpType = "PrimitiveType<T>",
            BaseType = "DataType",
            Category = FhirTypeCategory.Primitive,
            IsAbstract = true,
            Description = "The base type for all re-usable types defined that have a simple property"
        };

        mappings["BackboneType"] = new FhirTypeMapping
        {
            FhirType = "BackboneType",
            CSharpType = "BackboneType",
            BaseType = "DataType",
            Category = FhirTypeCategory.BackboneType,
            IsAbstract = true,
            SupportsModifierExtensions = true,
            Description = "Base definition for the few data types that are allowed to carry modifier extensions"
        };

        mappings["BackboneElement"] = new FhirTypeMapping
        {
            FhirType = "BackboneElement",
            CSharpType = "BackboneElement",
            BaseType = "Element",
            Category = FhirTypeCategory.BackboneElement,
            IsAbstract = true,
            SupportsModifierExtensions = true,
            Description = "Base definition for all elements that are defined inside a resource"
        };

        // Resource 抽象類別
        mappings["Resource"] = new FhirTypeMapping
        {
            FhirType = "Resource",
            CSharpType = "Resource",
            BaseType = "Base",
            Category = FhirTypeCategory.Resource,
            IsAbstract = true,
            Description = "Base Resource"
        };

        // DomainResource 抽象類別
        mappings["DomainResource"] = new FhirTypeMapping
        {
            FhirType = "DomainResource",
            CSharpType = "DomainResource",
            BaseType = "Resource",
            Category = FhirTypeCategory.DomainResource,
            IsAbstract = true,
            SupportsExtensions = true,
            SupportsModifierExtensions = true,
            Description = "A resource that includes narrative, extensions, and contained resources"
        };

        // ===== Primitive Types =====
        // 重要：FHIR Primitive Types 必須加上 "Fhir" 前綴避免與 C# 原生型別衝突
        // 例如：FHIR "boolean" → C# "FhirBoolean"，內部包含 bool? Value 屬性

        AddPrimitiveType(mappings, "boolean", "FhirBoolean", "bool?", "xs:boolean", "boolean",
            @"true|false", "Value to indicate true or false");

        AddPrimitiveType(mappings, "integer", "FhirInteger", "int?", "xs:int", "number",
            @"[0]|[-+]?[1-9][0-9]*", "A signed integer in the range −2,147,483,648..2,147,483,647");

        AddPrimitiveType(mappings, "integer64", "FhirInteger64", "long?", "xs:long", "string",
            @"[0]|[-+]?[1-9][0-9]*", "A signed 64-bit integer");

        AddPrimitiveType(mappings, "decimal", "FhirDecimal", "decimal?", "xs:decimal", "number",
            @"-?(0|[1-9][0-9]{0,17})(\.[0-9]{1,17})?([eE][+-]?[0-9]{1,9}})?", "Rational numbers with decimal representation");

        AddPrimitiveType(mappings, "string", "FhirString", "string", "xs:string", "string",
            @"^[\s\S]+$", "A sequence of Unicode characters");

        AddPrimitiveType(mappings, "uri", "FhirUri", "string", "xs:anyURI", "string",
            @"\S*", "A Uniform Resource Identifier Reference");

        AddPrimitiveType(mappings, "url", "FhirUrl", "string", "xs:anyURI", "string",
            @"\S*", "A Uniform Resource Locator");

        AddPrimitiveType(mappings, "canonical", "FhirCanonical", "string", "xs:anyURI", "string",
            @"\S*", "A URI that refers to a resource by its canonical URL");

        AddPrimitiveType(mappings, "base64Binary", "FhirBase64Binary", "byte[]", "xs:base64Binary", "string",
            @"(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?", "A stream of bytes, base64 encoded");

        AddPrimitiveType(mappings, "instant", "FhirInstant", "DateTimeOffset?", "xs:dateTime", "string",
            @"([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9})?(Z|(\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00))",
            "An instant in time - known at least to the second");

        AddPrimitiveType(mappings, "date", "FhirDate", "DateTime?", "xs:date", "string",
            @"([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)(-(0[1-9]|1[0-2])(-(0[1-9]|[1-2][0-9]|3[0-1]))?)?",
            "A date, or partial date");

        AddPrimitiveType(mappings, "dateTime", "FhirDateTime", "DateTime?", "xs:dateTime", "string",
            @"([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)(-(0[1-9]|1[0-2])(-(0[1-9]|[1-2][0-9]|3[0-1])(T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9})?)?)?(Z|(\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00)?)?)?",
            "A date, date-time or partial date");

        AddPrimitiveType(mappings, "time", "FhirTime", "TimeSpan?", "xs:time", "string",
            @"([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9})?",
            "A time during the day, in the format hh:mm:ss");

        AddPrimitiveType(mappings, "code", "FhirCode", "string", "xs:token", "string",
            @"[^\s]+( [^\s]+)*", "Indicates that the value is taken from a set of controlled strings");

        AddPrimitiveType(mappings, "oid", "FhirOid", "string", "xs:anyURI", "string",
            @"urn:oid:[0-2](\.(0|[1-9][0-9]*))+", "An OID represented as a URI");

        AddPrimitiveType(mappings, "id", "FhirId", "string", "xs:string", "string",
            @"[A-Za-z0-9\-\.]{1,64}", "Any combination of upper- or lower-case ASCII letters");

        AddPrimitiveType(mappings, "markdown", "FhirMarkdown", "string", "xs:string", "string",
            @"^[\s\S]+$", "A FHIR string that may contain markdown syntax");

        AddPrimitiveType(mappings, "unsignedInt", "FhirUnsignedInt", "uint?", "xs:nonNegativeInteger", "number",
            @"[0]|([1-9][0-9]*)", "Any non-negative integer in the range 0..2,147,483,647");

        AddPrimitiveType(mappings, "positiveInt", "FhirPositiveInt", "uint?", "xs:positiveInteger", "number",
            @"[1-9][0-9]*", "Any positive integer in the range 1..2,147,483,647");

        AddPrimitiveType(mappings, "uuid", "FhirUuid", "string", "xs:anyURI", "string",
            @"urn:uuid:[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}",
            "A UUID represented as a URI");

        // ===== Complex DataTypes =====
        AddComplexType(mappings, "Identifier", "Identifier", "DataType",
            "An identifier - identifies some entity uniquely and unambiguously");

        AddComplexType(mappings, "HumanName", "HumanName", "DataType",
            "A human's name with the ability to identify parts and usage");

        AddComplexType(mappings, "Address", "Address", "DataType",
            "An address expressed using postal conventions");

        AddComplexType(mappings, "ContactPoint", "ContactPoint", "DataType",
            "Details for all kinds of technology mediated contact points");

        AddComplexType(mappings, "Timing", "Timing", "BackboneType",
            "Specifies an event that may occur multiple times");

        AddComplexType(mappings, "Quantity", "Quantity", "DataType",
            "A measured amount (or an amount that can potentially be measured)");

        AddComplexType(mappings, "Attachment", "Attachment", "DataType",
            "Content in a format defined elsewhere");

        AddComplexType(mappings, "Range", "Range", "DataType",
            "A set of ordered Quantities defined by a low and high limit");

        AddComplexType(mappings, "Period", "Period", "DataType",
            "A time period defined by a start and end date and optionally time");

        AddComplexType(mappings, "Ratio", "Ratio", "DataType",
            "A relationship of two Quantity values - expressed as a numerator and a denominator");

        AddComplexType(mappings, "RatioRange", "RatioRange", "DataType",
            "A range of ratios expressed as a low and high numerator and a denominator");

        AddComplexType(mappings, "CodeableConcept", "CodeableConcept", "DataType",
            "A concept that may be defined by a formal reference to a terminology or ontology");

        AddComplexType(mappings, "Coding", "Coding", "DataType",
            "A reference to a code defined by a terminology system");

        AddComplexType(mappings, "SampledData", "SampledData", "DataType",
            "A series of measurements taken by a device");

        AddComplexType(mappings, "Age", "Age", "Quantity",
            "A duration of time during which an organism (or a process) has existed");

        AddComplexType(mappings, "Distance", "Distance", "Quantity",
            "A length - a value with a unit that is a physical distance");

        AddComplexType(mappings, "Duration", "Duration", "Quantity",
            "A length of time");

        AddComplexType(mappings, "Count", "Count", "Quantity",
            "A measured amount (or an amount that can potentially be measured)");

        AddComplexType(mappings, "Money", "Money", "DataType",
            "An amount of economic utility in some recognized currency");

        AddComplexType(mappings, "Annotation", "Annotation", "DataType",
            "A text note which also contains information about who made the statement and when");

        AddComplexType(mappings, "Signature", "Signature", "DataType",
            "A signature along with supporting context");

        // ===== Special Purpose DataTypes =====
        // Reference 使用特殊處理，支援強型別泛型
        mappings["Reference"] = new FhirTypeMapping
        {
            FhirType = "Reference",
            CSharpType = "Reference",  // 基礎類別，實際使用時會是泛型
            BaseType = "DataType",
            Category = FhirTypeCategory.SpecialPurpose,
            IsAbstract = true,  // 基礎 Reference 是抽象的
            Description = "A reference from one resource to another - use strongly-typed Reference<T> in practice"
        };

        AddComplexType(mappings, "Narrative", "Narrative", "DataType",
            "Human-readable summary of the resource");

        // Extension 已經在上面定義，直接繼承 Base 避免循環依賴

        AddComplexType(mappings, "Meta", "Meta", "DataType",
            "Metadata about a resource");

        AddComplexType(mappings, "Dosage", "Dosage", "BackboneType",
            "How the medication is/was taken or should be taken");

        AddComplexType(mappings, "ElementDefinition", "ElementDefinition", "BackboneType",
            "Definition of an element in a resource or extension");

        return mappings;
    }

    /// <summary>
    /// 添加 FHIR Primitive Type 映射
    /// </summary>
    /// <param name="mappings">映射字典</param>
    /// <param name="fhirType">FHIR 官方型別名稱（如 "boolean", "string"）</param>
    /// <param name="csharpType">C# 類別名稱（加上 Fhir 前綴，如 "FhirBoolean", "FhirString"）</param>
    /// <param name="nativeType">對應的 C# 原生型別（如 "bool?", "string"）</param>
    /// <param name="xmlType">XML Schema 型別</param>
    /// <param name="jsonType">JSON 型別</param>
    /// <param name="regex">驗證用的正規表達式</param>
    /// <param name="description">型別描述</param>
    private void AddPrimitiveType(Dictionary<string, FhirTypeMapping> mappings, string fhirType,
        string csharpType, string nativeType, string xmlType, string jsonType, string regex, string description)
    {
        // 重要：fhirType 是 FHIR 官方名稱（如 "boolean"）
        // csharpType 是加上前綴的 C# 類別名稱（如 "FhirBoolean"）
        // 這樣避免與 C# 原生型別衝突
        mappings[fhirType] = new FhirTypeMapping
        {
            FhirType = fhirType,                                    // "boolean"
            CSharpType = csharpType,                                // "FhirBoolean"
            BaseType = "PrimitiveType<" + nativeType + ">",         // "PrimitiveType<bool?>"
            Category = FhirTypeCategory.Primitive,
            NativeType = nativeType,                                // "bool?"
            XmlType = xmlType,                                      // "xs:boolean"
            JsonType = jsonType,                                    // "boolean"
            Regex = regex,                                          // "true|false"
            Description = description
        };
    }

    private void AddComplexType(Dictionary<string, FhirTypeMapping> mappings, string fhirType,
        string csharpType, string baseType, string description)
    {
        var category = baseType switch
        {
            "BackboneType" => FhirTypeCategory.BackboneType,
            "BackboneElement" => FhirTypeCategory.BackboneElement,
            _ => FhirTypeCategory.DataType
        };

        mappings[fhirType] = new FhirTypeMapping
        {
            FhirType = fhirType,
            CSharpType = csharpType,
            BaseType = baseType,
            Category = category,
            Description = description,
            SupportsModifierExtensions = baseType == "BackboneType" || baseType == "BackboneElement"
        };
    }

    /// <summary>
    /// 初始化 Choice Types
    /// </summary>
    private Dictionary<string, ChoiceTypeDefinition> InitializeChoiceTypes()
    {
        // 這裡會從 FHIR 定義中動態載入
        // 目前先返回空字典，實際實作時會從 StructureDefinition 中解析
        return new Dictionary<string, ChoiceTypeDefinition>();
    }

    /// <summary>
    /// 初始化 Reference Types
    /// </summary>
    private Dictionary<string, ReferenceTypeDefinition> InitializeReferenceTypes()
    {
        // 這裡會從 FHIR 定義中動態載入
        // 目前先返回空字典，實際實作時會從 StructureDefinition 中解析
        return new Dictionary<string, ReferenceTypeDefinition>();
    }

    /// <summary>
    /// 獲取 FHIR 型別的完整映射資訊
    /// </summary>
    public FhirTypeMapping? GetTypeMapping(string fhirType)
    {
        return _typeMappings.TryGetValue(fhirType, out var mapping) ? mapping : null;
    }

    /// <summary>
    /// 將 FHIR 型別映射到 C# 型別
    /// 完全基於 FHIR 官方規範，不簡化
    /// </summary>
    /// <param name="fhirType">FHIR 型別名稱</param>
    /// <param name="isArray">是否為陣列型別</param>
    /// <param name="needsConcrete">是否需要具體實例（用於抽象型別）</param>
    /// <param name="validationRule">驗證規則</param>
    /// <returns>對應的 C# 型別</returns>
    public string MapFhirTypeToCSharp(string fhirType, bool isArray = false, bool needsConcrete = false, ValidationRule? validationRule = null)
    {
        if (string.IsNullOrEmpty(fhirType))
            return "object?";

        // 特殊處理：Resource 和 DomainResource 在需要具體實例時使用 ResourceWrapper
        if ((fhirType == "Resource" || fhirType == "DomainResource") && needsConcrete)
        {
            return isArray ? "List<ResourceWrapper>?" : "ResourceWrapper?";
        }

        // 檢查是否為其他抽象型別且需要具體實例
        if (needsConcrete && _abstractTypeMappings.TryGetValue(fhirType, out var abstractMapping))
        {
            var concreteType = abstractMapping.ImplType;
            return isArray ? $"List<{concreteType}>?" : $"{concreteType}?";
        }

        var mapping = GetTypeMapping(fhirType);
        if (mapping == null)
        {
            // 未知型別，可能是具體的 Resource 或自定義型別
            var cleanType = CleanTypeName(fhirType);
            return isArray ? $"List<{cleanType}>?" : $"{cleanType}?";
        }

        var baseType = mapping.CSharpType;
        return isArray ? $"List<{baseType}>?" : $"{baseType}?";
    }

    /// <summary>
    /// 清理型別名稱
    /// </summary>
    private string CleanTypeName(string typeName)
    {
        if (string.IsNullOrEmpty(typeName))
            return typeName;

        // 處理 URL 格式的型別名稱
        if (typeName.Contains("://"))
        {
            var parts = typeName.Split('/', '.');
            return parts.LastOrDefault() ?? typeName;
        }

        return typeName;
    }

    /// <summary>
    /// 檢查是否為 Primitive Type
    /// </summary>
    public bool IsPrimitiveType(string fhirType)
    {
        var mapping = GetTypeMapping(fhirType);
        return mapping?.Category == FhirTypeCategory.Primitive;
    }

    /// <summary>
    /// 檢查是否為 Complex Type
    /// </summary>
    public bool IsComplexType(string fhirType)
    {
        var mapping = GetTypeMapping(fhirType);
        return mapping?.Category == FhirTypeCategory.DataType;
    }

    /// <summary>
    /// 檢查是否為 Resource Type
    /// </summary>
    public bool IsResourceType(string fhirType)
    {
        var mapping = GetTypeMapping(fhirType);
        return mapping?.Category == FhirTypeCategory.Resource ||
               mapping?.Category == FhirTypeCategory.DomainResource;
    }

    /// <summary>
    /// 檢查是否為抽象型別
    /// </summary>
    public bool IsAbstractType(string fhirType)
    {
        return _abstractTypeMappings.ContainsKey(fhirType);
    }

    /// <summary>
    /// 獲取抽象型別的具體實作類別名稱
    /// </summary>
    public string? GetImplType(string abstractType)
    {
        return _abstractTypeMappings.TryGetValue(abstractType, out var mapping) ? mapping.ImplType : null;
    }

    /// <summary>
    /// 判斷在特定上下文中是否需要具體實例
    /// </summary>
    /// <param name="fhirType">FHIR 型別名稱</param>
    /// <param name="context">使用上下文（如屬性名稱、父類別等）</param>
    /// <returns>是否需要具體實例</returns>
    public bool NeedsConcrete(string fhirType, string? context = null)
    {
        // Resource 在以下情況需要具體實例：
        if (fhirType == "Resource" || fhirType == "DomainResource")
        {
            return context switch
            {
                "Bundle.entry.resource" => true,
                "Parameters.parameter.resource" => true,
                "Bundle.entry" => true,  // BundleEntry.resource
                "Parameters.parameter" => true,  // ParametersParameter.resource
                _ => IsAbstractType(fhirType)  // 預設：抽象型別需要具體實例
            };
        }

        // 其他抽象型別在屬性中使用時通常需要具體實例
        return IsAbstractType(fhirType);
    }

    /// <summary>
    /// 檢查是否為 BackboneElement 型別
    /// BackboneElement 是 Resource 特定的內部結構元素
    /// </summary>
    public bool IsBackboneElement(string fhirType, string? resourceContext = null)
    {
        // BackboneElement 通常以 Resource 名稱為前綴
        if (!string.IsNullOrEmpty(resourceContext))
        {
            return fhirType.StartsWith(resourceContext + ".");
        }

        // 常見的 BackboneElement 模式
        return fhirType.Contains(".") &&
               (fhirType.Contains("Entry") ||
                fhirType.Contains("Component") ||
                fhirType.Contains("Contact") ||
                fhirType.Contains("Link") ||
                fhirType.Contains("Search") ||
                fhirType.Contains("Request") ||
                fhirType.Contains("Response"));
    }

    /// <summary>
    /// 為 BackboneElement 生成正確的 C# 類別名稱
    /// </summary>
    /// <param name="fhirType">FHIR 型別名稱（如 "Bundle.entry"）</param>
    /// <param name="resourceName">所屬的 Resource 名稱</param>
    /// <returns>C# 類別名稱（如 "Entry"）</returns>
    public string MapBackboneElementToCSharp(string fhirType, string resourceName)
    {
        if (string.IsNullOrEmpty(fhirType) || string.IsNullOrEmpty(resourceName))
            return fhirType;

        // 移除 Resource 前綴（如 "Bundle.entry" → "entry"）
        var elementName = fhirType.StartsWith(resourceName + ".")
            ? fhirType.Substring(resourceName.Length + 1)
            : fhirType;

        // 轉換為 PascalCase（如 "entry" → "Entry"）
        return ToPascalCase(elementName);
    }

    /// <summary>
    /// 轉換為 PascalCase
    /// </summary>
    private string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        // 處理點分隔的名稱（如 "reference.range" → "ReferenceRange"）
        var parts = input.Split('.');
        var result = string.Join("", parts.Select(part =>
            char.ToUpperInvariant(part[0]) + part.Substring(1).ToLowerInvariant()));

        return result;
    }

    /// <summary>
    /// 映射 Reference 型別到強型別泛型 Reference
    /// </summary>
    /// <param name="allowedTargetTypes">允許的目標 Resource 型別</param>
    /// <param name="isArray">是否為陣列</param>
    /// <returns>強型別的 Reference 型別字串</returns>
    public string MapReferenceType(string[] allowedTargetTypes, bool isArray = false)
    {
        if (allowedTargetTypes == null || allowedTargetTypes.Length == 0)
        {
            // 沒有限制時使用基礎 Reference
            return isArray ? "List<Reference>?" : "Reference?";
        }

        var referenceType = allowedTargetTypes.Length switch
        {
            1 => $"Reference<{allowedTargetTypes[0]}>",
            2 => $"Reference<{allowedTargetTypes[0]}, {allowedTargetTypes[1]}>",
            3 => $"Reference<{allowedTargetTypes[0]}, {allowedTargetTypes[1]}, {allowedTargetTypes[2]}>",
            4 => $"Reference<{allowedTargetTypes[0]}, {allowedTargetTypes[1]}, {allowedTargetTypes[2]}, {allowedTargetTypes[3]}>",
            _ => "Reference"  // 超過 4 個型別時使用基礎 Reference
        };

        return isArray ? $"List<{referenceType}>?" : $"{referenceType}?";
    }

    /// <summary>
    /// 從 FHIR ElementDefinition 中提取 Reference 的目標型別
    /// </summary>
    /// <param name="elementDefinition">FHIR ElementDefinition</param>
    /// <returns>允許的目標型別陣列</returns>
    public string[] ExtractReferenceTargetTypes(object elementDefinition)
    {
        // 這裡需要根據實際的 FHIR StructureDefinition 解析邏輯
        // 從 ElementDefinition.type.targetProfile 中提取允許的型別

        // 暫時返回空陣列，實際實作時會從 FHIR 定義中解析
        return Array.Empty<string>();
    }

    /// <summary>
    /// 檢查是否為 Reference 型別
    /// </summary>
    public bool IsReferenceType(string fhirType)
    {
        return fhirType == "Reference" || fhirType.StartsWith("Reference<");
    }

    /// <summary>
    /// 從 Reference 型別字串中提取目標型別
    /// </summary>
    /// <param name="referenceType">Reference 型別字串（如 "Reference<Patient, Group>"）</param>
    /// <returns>目標型別陣列</returns>
    public string[] ExtractTargetTypesFromReferenceType(string referenceType)
    {
        if (!referenceType.StartsWith("Reference<") || !referenceType.EndsWith(">"))
        {
            return Array.Empty<string>();
        }

        var typesPart = referenceType.Substring(10, referenceType.Length - 11); // 移除 "Reference<" 和 ">"
        return typesPart.Split(',').Select(t => t.Trim()).ToArray();
    }

    /// <summary>
    /// 映射 Choice Type 到強型別泛型 ChoiceType
    /// </summary>
    /// <param name="allowedTypes">允許的型別列表</param>
    /// <param name="isArray">是否為陣列（Choice Type 通常不是陣列）</param>
    /// <returns>強型別的 ChoiceType 型別字串</returns>
    public string MapChoiceType(string[] allowedTypes, bool isArray = false)
    {
        if (allowedTypes == null || allowedTypes.Length == 0)
        {
            return isArray ? "List<object>?" : "object?";
        }

        // 將 FHIR 型別名稱轉換為 C# 型別名稱
        var csharpTypes = allowedTypes.Select(MapFhirTypeToCSharpTypeName).ToArray();

        var choiceType = csharpTypes.Length switch
        {
            1 => $"ChoiceType<{csharpTypes[0]}>",
            2 => $"ChoiceType<{csharpTypes[0]}, {csharpTypes[1]}>",
            3 => $"ChoiceType<{csharpTypes[0]}, {csharpTypes[1]}, {csharpTypes[2]}>",
            4 => $"ChoiceType<{csharpTypes[0]}, {csharpTypes[1]}, {csharpTypes[2]}, {csharpTypes[3]}>",
            _ => "object"  // 超過 4 個型別時使用 object
        };

        return isArray ? $"List<{choiceType}>?" : $"{choiceType}?";
    }

    /// <summary>
    /// 將 FHIR 型別名稱轉換為 C# 型別名稱（用於 Choice Type）
    /// </summary>
    private string MapFhirTypeToCSharpTypeName(string fhirType)
    {
        // 檢查是否為 Primitive Type
        if (IsPrimitiveType(fhirType))
        {
            return "Fhir" + char.ToUpperInvariant(fhirType[0]) + fhirType.Substring(1);
        }

        // 檢查是否為 Complex Type
        var mapping = GetTypeMapping(fhirType);
        if (mapping != null)
        {
            return mapping.CSharpType;
        }

        // 預設使用原名稱
        return fhirType;
    }

    /// <summary>
    /// 檢查是否為 Choice Type 屬性
    /// </summary>
    /// <param name="propertyName">屬性名稱</param>
    /// <returns>是否為 Choice Type</returns>
    public bool IsChoiceTypeProperty(string propertyName)
    {
        return propertyName.EndsWith("[x]") ||
               propertyName.Contains("[x]") ||
               IsKnownChoiceTypeProperty(propertyName);
    }

    /// <summary>
    /// 檢查是否為已知的 Choice Type 屬性
    /// </summary>
    private bool IsKnownChoiceTypeProperty(string propertyName)
    {
        return propertyName switch
        {
            "value" => true,        // Extension.value[x]
            "onset" => true,        // Condition.onset[x]
            "abatement" => true,    // Condition.abatement[x]
            "deceased" => true,     // Patient.deceased[x]
            "multipleBirth" => true, // Patient.multipleBirth[x]
            "effective" => true,    // Observation.effective[x]
            "performed" => true,    // Procedure.performed[x]
            "occurrence" => true,   // MedicationRequest.dosageInstruction.timing.repeat.bounds[x]
            _ => false
        };
    }

    /// <summary>
    /// 映射 Choice Type 到強型別泛型 ChoiceType
    /// </summary>
    /// <param name="allowedTypes">允許的型別列表</param>
    /// <param name="isArray">是否為陣列（Choice Type 通常不是陣列）</param>
    /// <returns>強型別的 ChoiceType 型別字串</returns>
    public string MapChoiceType(string[] allowedTypes, bool isArray = false)
    {
        if (allowedTypes == null || allowedTypes.Length == 0)
        {
            return isArray ? "List<object>?" : "object?";
        }

        // 將 FHIR 型別名稱轉換為 C# 型別名稱
        var csharpTypes = allowedTypes.Select(MapFhirTypeToCSharpTypeName).ToArray();

        var choiceType = csharpTypes.Length switch
        {
            1 => $"ChoiceType<{csharpTypes[0]}>",
            2 => $"ChoiceType<{csharpTypes[0]}, {csharpTypes[1]}>",
            3 => $"ChoiceType<{csharpTypes[0]}, {csharpTypes[1]}, {csharpTypes[2]}>",
            4 => $"ChoiceType<{csharpTypes[0]}, {csharpTypes[1]}, {csharpTypes[2]}, {csharpTypes[3]}>",
            _ => "object"  // 超過 4 個型別時使用 object
        };

        return isArray ? $"List<{choiceType}>?" : $"{choiceType}?";
    }

    /// <summary>
    /// 將 FHIR 型別名稱轉換為 C# 型別名稱（用於 Choice Type）
    /// </summary>
    private string MapFhirTypeToCSharpTypeName(string fhirType)
    {
        // 檢查是否為 Primitive Type
        if (IsPrimitiveType(fhirType))
        {
            return "Fhir" + char.ToUpperInvariant(fhirType[0]) + fhirType.Substring(1);
        }

        // 檢查是否為 Complex Type
        var mapping = GetTypeMapping(fhirType);
        if (mapping != null)
        {
            return mapping.CSharpType;
        }

        // 預設使用原名稱
        return fhirType;
    }

    /// <summary>
    /// 從 Choice Type 屬性名稱中提取基礎名稱
    /// </summary>
    /// <param name="choicePropertyName">Choice Type 屬性名稱（如 "value[x]"）</param>
    /// <returns>基礎名稱（如 "value"）</returns>
    public string ExtractChoiceTypeBaseName(string choicePropertyName)
    {
        if (choicePropertyName.EndsWith("[x]"))
        {
            return choicePropertyName.Substring(0, choicePropertyName.Length - 3);
        }

        return choicePropertyName;
    }

    /// <summary>
    /// 生成 Choice Type 的 JSON 屬性名稱
    /// </summary>
    /// <param name="baseName">基礎名稱（如 "value"）</param>
    /// <param name="typeName">型別名稱（如 "String"）</param>
    /// <returns>JSON 屬性名稱（如 "valueString"）</returns>
    public string GenerateChoiceTypeJsonPropertyName(string baseName, string typeName)
    {
        return baseName + char.ToUpperInvariant(typeName[0]) + typeName.Substring(1);
    }

    /// <summary>
    /// 取得常見 Choice Type 的允許型別
    /// </summary>
    public string[] GetCommonChoiceTypeAllowedTypes(string baseName)
    {
        return baseName switch
        {
            "value" => new[] // Extension.value[x]
            {
                "base64Binary", "boolean", "canonical", "code", "date", "dateTime",
                "decimal", "id", "instant", "integer", "markdown", "oid",
                "positiveInt", "string", "time", "unsignedInt", "uri", "url", "uuid",
                "Address", "Age", "Annotation", "Attachment", "CodeableConcept",
                "Coding", "ContactPoint", "Count", "Distance", "Duration",
                "HumanName", "Identifier", "Money", "Period", "Quantity",
                "Range", "Ratio", "Reference", "SampledData", "Signature", "Timing"
            },
            "onset" => new[] // Condition.onset[x]
            {
                "dateTime", "Age", "Period", "Range", "string"
            },
            "abatement" => new[] // Condition.abatement[x]
            {
                "dateTime", "Age", "Period", "Range", "string"
            },
            "deceased" => new[] // Patient.deceased[x]
            {
                "boolean", "dateTime"
            },
            "multipleBirth" => new[] // Patient.multipleBirth[x]
            {
                "boolean", "integer"
            },
            "effective" => new[] // Observation.effective[x]
            {
                "dateTime", "Period", "Timing", "instant"
            },
            "performed" => new[] // Procedure.performed[x]
            {
                "dateTime", "Period", "string", "Age", "Range"
            },
            _ => Array.Empty<string>()
        };
    }

    /// <summary>
    /// 初始化抽象型別映射
    /// 處理 FHIR 中抽象定義但需要具體實例的型別
    /// </summary>
    private Dictionary<string, AbstractTypeMapping> InitializeAbstractTypeMappings()
    {
        return new Dictionary<string, AbstractTypeMapping>
        {
            // Quantity 系列 - 抽象基礎但經常需要具體實例
            ["Quantity"] = new AbstractTypeMapping
            {
                AbstractType = "Quantity",
                ImplType = "QuantityImpl",
                SpecializedTypes = new[] { "Age", "Distance", "Duration", "Count", "Money" },
                Description = "A measured amount (or an amount that can potentially be measured)"
            },

            // Reference - 雖然不是抽象的，但為了一致性也提供 Impl
            ["Reference"] = new AbstractTypeMapping
            {
                AbstractType = "Reference",
                ImplType = "ReferenceImpl",
                SpecializedTypes = new string[0],
                Description = "A reference from one resource to another"
            },

            // Resource - 抽象類別但在 Bundle.entry.resource 等地方需要具體實例
            ["Resource"] = new AbstractTypeMapping
            {
                AbstractType = "Resource",
                ImplType = "ResourceWrapper",
                SpecializedTypes = new[] { "DomainResource", "Bundle", "OperationOutcome", "Parameters" },
                Description = "Base Resource - use ResourceWrapper for concrete instances"
            },

            // DomainResource - 抽象類別，大部分應用資源的基礎
            ["DomainResource"] = new AbstractTypeMapping
            {
                AbstractType = "DomainResource",
                ImplType = "ResourceWrapper",  // 也使用 ResourceWrapper
                SpecializedTypes = new[] { "Patient", "Observation", "Practitioner", "Organization" },
                Description = "Domain Resource - use ResourceWrapper for concrete instances"
            },

            // 其他可能需要的抽象型別
            // 根據實際 FHIR 定義和使用情況添加
        };
    }

    /// <summary>
    /// 生成類別的 XML 文件註解
    /// </summary>
    /// <param name="fhirType">FHIR 型別名稱</param>
    /// <param name="description">描述</param>
    /// <param name="fhirVersion">FHIR 版本</param>
    /// <returns>格式化的 XML 註解</returns>
    public string GenerateClassDocumentation(string fhirType, string description, string fhirVersion = "R4")
    {
        var mapping = GetTypeMapping(fhirType);
        var category = mapping?.Category.ToString() ?? "Unknown";

        var remarks = $"FHIR {fhirVersion} {fhirType} {category}";
        if (mapping?.IsAbstract == true)
        {
            remarks += " (Abstract)";
        }

        return _docGenerator.GenerateClassDocumentation(
            summary: description,
            remarks: remarks
        );
    }

    /// <summary>
    /// 生成屬性的 XML 文件註解
    /// </summary>
    /// <param name="propertyName">屬性名稱</param>
    /// <param name="fhirPath">FHIR 路徑</param>
    /// <param name="description">描述</param>
    /// <param name="cardinality">基數</param>
    /// <param name="fhirType">FHIR 型別</param>
    /// <param name="isRequired">是否必要</param>
    /// <returns>格式化的 XML 註解</returns>
    public string GeneratePropertyDocumentation(string propertyName, string fhirPath,
        string description, string cardinality, string fhirType, bool isRequired = false)
    {
        // 檢查是否為 Choice Type
        if (IsChoiceTypeProperty(propertyName))
        {
            var baseName = ExtractChoiceTypeBaseName(propertyName);
            var allowedTypes = GetCommonChoiceTypeAllowedTypes(baseName);

            if (allowedTypes.Length > 0)
            {
                return _docGenerator.GenerateChoiceTypeDocumentation(baseName, allowedTypes, description);
            }
        }

        // 檢查是否為 Reference Type
        if (IsReferenceType(fhirType))
        {
            // 這裡需要從實際的 FHIR 定義中提取允許的目標型別
            // 暫時使用空陣列，實際實作時會從 StructureDefinition 中解析
            var referenceTargets = Array.Empty<string>();

            if (referenceTargets.Length > 0)
            {
                return _docGenerator.GenerateReferenceDocumentation(referenceTargets, description);
            }
        }

        return _docGenerator.GeneratePropertyDocumentation(
            summary: description,
            fhirPath: fhirPath,
            cardinality: cardinality,
            isRequired: isRequired
        );
    }

    /// <summary>
    /// 生成方法的 XML 文件註解
    /// </summary>
    /// <param name="methodName">方法名稱</param>
    /// <param name="description">描述</param>
    /// <param name="parameters">參數描述</param>
    /// <param name="returns">返回值描述</param>
    /// <returns>格式化的 XML 註解</returns>
    public string GenerateMethodDocumentation(string methodName, string description,
        Dictionary<string, string>? parameters = null, string? returns = null)
    {
        return _docGenerator.GenerateMethodDocumentation(
            summary: description,
            parameters: parameters,
            returns: returns
        );
    }

    /// <summary>
    /// 生成 BackboneElement 的 XML 文件註解
    /// </summary>
    /// <param name="resourceName">資源名稱</param>
    /// <param name="elementName">元素名稱</param>
    /// <param name="description">描述</param>
    /// <returns>格式化的 XML 註解</returns>
    public string GenerateBackboneElementDocumentation(string resourceName, string elementName, string description)
    {
        return _docGenerator.GenerateBackboneElementDocumentation(resourceName, elementName, description);
    }

    /// <summary>
    /// 驗證生成的 XML 註解是否有效
    /// </summary>
    /// <param name="xmlDocumentation">XML 註解內容</param>
    /// <returns>是否有效</returns>
    public bool ValidateXmlDocumentation(string xmlDocumentation)
    {
        return _docGenerator.ValidateXmlDocumentation(xmlDocumentation);
    }
}

/// <summary>
/// 抽象型別映射定義
/// 用於處理 FHIR 中抽象定義但需要具體實例的型別
/// </summary>
public class AbstractTypeMapping
{
    /// <summary>
    /// 抽象型別名稱
    /// </summary>
    public string AbstractType { get; set; } = string.Empty;

    /// <summary>
    /// 具體實作類別名稱（加上 Impl 後綴）
    /// </summary>
    public string ImplType { get; set; } = string.Empty;

    /// <summary>
    /// 特化類別列表（如 Age, Distance 等）
    /// </summary>
    public string[] SpecializedTypes { get; set; } = Array.Empty<string>();

    /// <summary>
    /// 型別描述
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
