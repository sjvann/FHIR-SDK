using Fhir.Support.Interfaces;

namespace Fhir.Support.Serialization;

/// <summary>
/// 定義 FHIR 解析器的通用介面。
/// </summary>
public interface IFhirParser
{
    /// <summary>
    /// 將輸入字串解析為指定的 FHIR 資源型別。
    /// </summary>
    /// <typeparam name="T">要解析成的資源型別，必須實作 <see cref="IResource"/>。</typeparam>
    /// <param name="input">包含 FHIR 資源的輸入字串（JSON 或 XML）。</param>
    /// <returns>一個解析後的 FHIR 資源物件。</returns>
    T Parse<T>(string input) where T : IResource;
} 