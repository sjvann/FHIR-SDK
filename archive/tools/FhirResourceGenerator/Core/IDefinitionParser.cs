namespace FhirResourceGenerator.Core;

/// <summary>
/// 定義檔解析器介面
/// 
/// <para>
/// 負責解析 FHIR StructureDefinition JSON 檔案，提取資源定義、資料類型和版本元資料。
/// </para>
/// </summary>
public interface IDefinitionParser
{
    /// <summary>
    /// 解析資源定義檔
    /// </summary>
    /// <param name="definitionPath">定義檔路徑</param>
    /// <returns>資源定義集合</returns>
    Task<IEnumerable<ResourceDefinition>> ParseResourceDefinitionsAsync(string definitionPath);

    /// <summary>
    /// 解析資料類型定義檔
    /// </summary>
    /// <param name="definitionPath">定義檔路徑</param>
    /// <returns>資料類型定義集合</returns>
    Task<IEnumerable<DataTypeDefinition>> ParseDataTypeDefinitionsAsync(string definitionPath);

    /// <summary>
    /// 提取版本元資料
    /// </summary>
    /// <param name="definitionPath">定義檔路徑</param>
    /// <returns>版本元資料</returns>
    Task<VersionMetadata> ExtractVersionMetadataAsync(string definitionPath);
}