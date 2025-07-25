namespace Fhir.Generator.Models;

public class FhirSchema
{
    public Dictionary<string, TypeDefinition> DataTypes { get; set; } = new();
    public Dictionary<string, ResourceDefinition> Resources { get; set; } = new();
    public Dictionary<string, ValueSetDefinition> ValueSets { get; set; } = new();
    public string Version { get; set; } = string.Empty;
}

public class TypeDefinition
{
    public string Name { get; set; } = string.Empty;
    public string BaseType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<PropertyDefinition> Properties { get; set; } = new();
    public List<ValidationRule> ValidationRules { get; set; } = new();
    public bool IsAbstract { get; set; }
    public TypeKind Kind { get; set; }
}

public class ResourceDefinition : TypeDefinition
{
    public string ResourceType { get; set; } = string.Empty;
}

public class PropertyDefinition
{
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int MinCardinality { get; set; }
    public string MaxCardinality { get; set; } = "1";
    public bool IsArray => MaxCardinality == "*" || (int.TryParse(MaxCardinality, out var max) && max > 1);
    public bool IsRequired => MinCardinality > 0;
    public bool IsChoiceType { get; set; }
    public List<string> ChoiceTypes { get; set; } = new();
    public int Order { get; set; }

    // OneOf Choice Type 支援
    public bool IsOneOfChoiceType { get; set; }
    public string ChoiceBaseName { get; set; } = string.Empty;
    public Dictionary<string, string> ChoiceTypeMapping { get; set; } = new();
    
    // 指示是否需要 override 關鍵字來覆寫基底類別成員
    public bool NeedsNewKeyword { get; set; }
    
    // Reference 類型的目標限制
    public List<string> TargetProfiles { get; set; } = new();
}

public class ValueSetDefinition
{
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<ValueSetConcept> Concepts { get; set; } = new();
    public List<string> Values { get; set; } = new(); // 簡化的值列表
}

public class ValueSetConcept
{
    public string Code { get; set; } = string.Empty;
    public string Display { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
}

public enum TypeKind
{
    PrimitiveType,
    ComplexType,
    Resource,
    BackboneElement
}

public class ValidationRule
{
    public ValidationRuleType Type { get; set; }
    public string ElementPath { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;

    // Cardinality 相關
    public int MinCardinality { get; set; }
    public string MaxCardinality { get; set; } = "1";

    // ValueSet 綁定相關
    public string? ValueSetUrl { get; set; }
    public string? BindingStrength { get; set; }

    // Constraint 相關
    public string? ConstraintKey { get; set; }
    public string? ConstraintExpression { get; set; }
    public string? Severity { get; set; }

    // 型別驗證相關
    public List<string> AllowedTypes { get; set; } = new();
}

public enum ValidationRuleType
{
    Cardinality,
    ValueSetBinding,
    Constraint,
    TypeValidation
}

