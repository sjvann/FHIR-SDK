namespace FhirResourceGenerator.Core;

/// <summary>
/// 定義檔解析器介面
/// </summary>
/// <remarks>
/// 負責解析 FHIR StructureDefinition JSON 檔案，提取資源定義資訊
/// </remarks>
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

/// <summary>
/// 資源生成器介面
/// </summary>
/// <remarks>
/// 負責根據資源定義生成 C# 資源類別
/// </remarks>
public interface IResourceGenerator
{
    /// <summary>
    /// 生成單一資源
    /// </summary>
    /// <param name="context">生成上下文</param>
    /// <returns>生成結果</returns>
    Task<GenerationResult> GenerateProjectAsync(GeneratorContext context);

    /// <summary>
    /// 生成專案
    /// </summary>
    /// <param name="definitions">資源定義集合</param>
    /// <param name="context">生成上下文</param>
    /// <returns>生成結果</returns>
    Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context);
}

/// <summary>
/// 模板引擎介面
/// </summary>
/// <remarks>
/// 負責根據模板生成程式碼
/// </remarks>
public interface ITemplateEngine
{
    /// <summary>
    /// 生成資源類別
    /// </summary>
    /// <param name="definition">資源定義</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的 C# 程式碼</returns>
    string GenerateResourceClass(ResourceDefinition definition, TemplateContext context);

    /// <summary>
    /// 生成屬性
    /// </summary>
    /// <param name="property">屬性定義</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的屬性程式碼</returns>
    string GenerateProperty(PropertyDefinition property, TemplateContext context);

    /// <summary>
    /// 生成文檔註解
    /// </summary>
    /// <param name="docs">文檔資料</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的文檔註解</returns>
    string GenerateDocumentation(DocumentationData docs, TemplateContext context);

    /// <summary>
    /// 生成工廠方法
    /// </summary>
    /// <param name="definition">資源定義</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的工廠方法程式碼</returns>
    string GenerateFactoryMethod(ResourceDefinition definition, TemplateContext context);
}