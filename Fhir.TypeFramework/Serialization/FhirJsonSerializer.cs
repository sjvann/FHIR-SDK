using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.Serialization;

public static class FhirJsonSerializer
{
    private static readonly JsonSerializerOptions _options = CreateDefaultOptions(indented: true);

    public static JsonSerializerOptions Options => _options;

    public static string Serialize(Base instance) => Serialize(instance, FhirSerializerOptions.Lenient);

    public static string Serialize(Base instance, FhirSerializerOptions options)
        => JsonSerializer.Serialize(instance, instance.GetType(), JsonOptionsFor(options));

    public static string Serialize<T>(T instance) where T : Base
        => Serialize(instance, FhirSerializerOptions.Lenient);

    public static string Serialize<T>(T instance, FhirSerializerOptions options) where T : Base
        => JsonSerializer.Serialize(instance, JsonOptionsFor(options));

    public static T? Deserialize<T>(string json) where T : Base
        => Deserialize<T>(json, FhirSerializerOptions.Lenient);

    public static T? Deserialize<T>(string json, FhirSerializerOptions options) where T : Base
    {
        var result = JsonSerializer.Deserialize<T>(json, JsonOptionsFor(options));
        if (result is not null)
            ApplyHandling(result, options);
        return result;
    }

    /// <summary>
    /// 複製預設 FHIR JSON 選項並附加依 <paramref name="resourceTypes"/> 分派的 <see cref="Resource"/> 多型別反序列化。
    /// </summary>
    public static JsonSerializerOptions OptionsWithPolymorphicResources(IReadOnlyDictionary<string, Type> resourceTypes)
        => OptionsWithPolymorphicResources(resourceTypes, FhirSerializerOptions.Lenient);

    public static JsonSerializerOptions OptionsWithPolymorphicResources(
        IReadOnlyDictionary<string, Type> resourceTypes,
        FhirSerializerOptions serializerOptions)
    {
        var options = new JsonSerializerOptions(JsonOptionsFor(serializerOptions));
        options.Converters.Add(new FhirResourcePolymorphicJsonConverterFactory(resourceTypes));
        return options;
    }

    /// <summary>
    /// 將任意資源 JSON（須含 resourceType）解析為具體 <see cref="Resource"/> 子類別。
    /// </summary>
    public static Resource? DeserializeResource(string json, IReadOnlyDictionary<string, Type> resourceTypes)
        => DeserializeResource(json, resourceTypes, FhirSerializerOptions.Lenient);

    public static Resource? DeserializeResource(
        string json,
        IReadOnlyDictionary<string, Type> resourceTypes,
        FhirSerializerOptions options)
    {
        var result = JsonSerializer.Deserialize<Resource>(json, OptionsWithPolymorphicResources(resourceTypes, options));
        if (result is not null)
            ApplyHandling(result, options);
        return result;
    }

    /// <summary>
    /// 序列化含 <see cref="Resource"/> 多型欄位（例如 Bundle.entry.resource）的圖形。
    /// </summary>
    public static string SerializeWithResourcePolymorphism<T>(T instance, IReadOnlyDictionary<string, Type> resourceTypes)
        where T : Base
        => JsonSerializer.Serialize(instance, instance.GetType(), OptionsWithPolymorphicResources(resourceTypes));

    private static JsonSerializerOptions JsonOptionsFor(FhirSerializerOptions? options)
    {
        options ??= FhirSerializerOptions.Lenient;
        return options.WriteIndented ? _options : CreateDefaultOptions(indented: false);
    }

    private static void ApplyHandling(Base instance, FhirSerializerOptions options)
    {
        if (options.Handling != FhirSerializationHandling.Strict)
            return;

        var unknown = new List<string>();
        CollectUnknown(instance, "", unknown);
        if (unknown.Count == 0)
            return;

        throw new FhirSerializationException($"Unknown element(s): {string.Join(", ", unknown)}")
        {
            UnknownElements = unknown
        };
    }

    private static void CollectUnknown(Base instance, string prefix, List<string> unknown)
    {
        foreach (var name in instance.UnknownElementNames)
            unknown.Add(string.IsNullOrEmpty(prefix) ? name : $"{prefix}.{name}");

        foreach (var kv in instance.EnumerateElements())
        {
            if (kv.Value is Base child)
                CollectUnknown(child, AppendPath(prefix, kv.Key), unknown);
            else if (kv.Value is System.Collections.IEnumerable list and not string)
            {
                var i = 0;
                foreach (var item in list)
                {
                    if (item is Base nested)
                        CollectUnknown(nested, $"{AppendPath(prefix, kv.Key)}[{i}]", unknown);
                    i++;
                }
            }
        }
    }

    private static string AppendPath(string prefix, string name)
        => string.IsNullOrEmpty(prefix) ? name : $"{prefix}.{name}";

    private static JsonSerializerOptions CreateDefaultOptions(bool indented)
    {
        var resolver = new DefaultJsonTypeInfoResolver();
        resolver.Modifiers.Add(ApplyFhirJsonContract);

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = indented,
            TypeInfoResolver = resolver
        };

        options.Converters.Add(new FhirPrimitiveJsonConverterFactory());
        options.Converters.Add(new FhirExtensionListJsonConverterFactory());

        return options;
    }

    /// <summary>
    /// FHIR 線上 JSON：<c>resourceType</c> 必須最先寫出；choice 的 <c>Has*</c> 輔助屬性不得出現。
    /// </summary>
    private static void ApplyFhirJsonContract(JsonTypeInfo typeInfo)
    {
        if (typeInfo.Kind != JsonTypeInfoKind.Object)
            return;

        foreach (var prop in typeInfo.Properties)
        {
            if (string.Equals(prop.Name, "resourceType", StringComparison.Ordinal))
            {
                prop.Order = int.MinValue;
                continue;
            }

            if (IsChoiceHelperProperty(prop))
                prop.ShouldSerialize = static (_, _) => false;
        }
    }

    private static bool IsChoiceHelperProperty(JsonPropertyInfo prop)
    {
        if (prop.PropertyType != typeof(bool))
            return false;
        if (prop.AttributeProvider?.GetCustomAttributes(typeof(JsonPropertyNameAttribute), true) is { Length: > 0 })
            return false;
        return prop.Name.StartsWith("has", StringComparison.Ordinal)
               && prop.Name.Length > 3
               && char.IsUpper(prop.Name[3]);
    }
}
