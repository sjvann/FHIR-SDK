namespace Fhir.Support.Attributes;

/// <summary>
/// 標記 FHIR Choice Type 屬性，用於指定基礎名稱和型別對應
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class FhirChoiceTypeAttribute : Attribute
{
    /// <summary>
    /// Choice Type 的基礎名稱（不含 [x] 後綴）
    /// </summary>
    public string BaseName { get; }

    /// <summary>
    /// 型別對應字典，Key 是 .NET 型別，Value 是 FHIR 型別後綴
    /// </summary>
    public Dictionary<Type, string> TypeMapping { get; }

    public FhirChoiceTypeAttribute(string baseName)
    {
        BaseName = baseName;
        TypeMapping = new Dictionary<Type, string>();
    }

    /// <summary>
    /// 添加型別對應
    /// </summary>
    public void AddTypeMapping(Type type, string suffix)
    {
        TypeMapping[type] = suffix;
    }
}

/// <summary>
/// 用於建構 Choice Type 型別對應的建構器
/// </summary>
public class ChoiceTypeBuilder
{
    private readonly Dictionary<Type, string> _typeMapping = new();

    public ChoiceTypeBuilder Add<T>(string suffix)
    {
        _typeMapping[typeof(T)] = suffix;
        return this;
    }

    public Dictionary<Type, string> Build() => _typeMapping;

    public static ChoiceTypeBuilder Create() => new();
}
