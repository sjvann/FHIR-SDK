using Fhir.Support.Interfaces;

namespace Fhir.Support.Serialization;

/// <summary>
/// 定義 FHIR 序列化器的通用介面。
/// </summary>
public interface IFhirSerializer
{
    /// <summary>
    /// 將 FHIR 資源物件序列化為字串。
    /// </summary>
    /// <param name="resource">要序列化的 FHIR 資源物件。</param>
    /// <returns>一個包含 FHIR 資源的字串（JSON 或 XML）。</returns>
    string Serialize(IResource resource);
} 