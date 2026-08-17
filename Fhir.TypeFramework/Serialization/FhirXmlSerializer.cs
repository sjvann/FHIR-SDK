using Fhir.TypeFramework.Bases;

namespace Fhir.TypeFramework.Serialization;

/// <summary>
/// FHIR XML 讀寫，與 <see cref="FhirJsonSerializer"/> 對等：寫入同一 POCO 物件圖，禁止 JSON↔XML 字串對翻。
/// </summary>
public static class FhirXmlSerializer
{
    public const string FhirNamespace = "http://hl7.org/fhir";
    public const string XhtmlNamespace = "http://www.w3.org/1999/xhtml";

    public static string Serialize(Base instance) => FhirXmlWriter.Write(instance);

    public static string Serialize<T>(T instance) where T : Base => FhirXmlWriter.Write(instance);

    public static T? Deserialize<T>(string xml) where T : Base
        => Deserialize<T>(xml, InferResourceTypes(typeof(T)));

    public static T? Deserialize<T>(string xml, IReadOnlyDictionary<string, Type>? resourceTypes)
        where T : Base
        => FhirXmlReader.Read<T>(xml, resourceTypes);

    /// <summary>
    /// 將任意資源 XML（根元素為 resourceType）解析為具體 <see cref="Resource"/> 子類別。
    /// </summary>
    public static Resource? DeserializeResource(string xml, IReadOnlyDictionary<string, Type> resourceTypes)
        => FhirXmlReader.ReadResource(xml, resourceTypes);

    /// <summary>
    /// 序列化含 <see cref="Resource"/> 多型欄位（例如 Bundle.entry.resource）的圖形。
    /// XML 寫出依具體執行期型別，不需對照表。
    /// </summary>
    public static string SerializeWithResourcePolymorphism<T>(T instance, IReadOnlyDictionary<string, Type> resourceTypes)
        where T : Base
    {
        _ = resourceTypes;
        return Serialize(instance);
    }

    private static IReadOnlyDictionary<string, Type>? InferResourceTypes(Type modelType)
    {
        if (!typeof(Resource).IsAssignableFrom(modelType))
            return null;
        return FhirResourceTypeMap.FromResourceAssembly(modelType.Assembly, typeof(Resource));
    }
}
