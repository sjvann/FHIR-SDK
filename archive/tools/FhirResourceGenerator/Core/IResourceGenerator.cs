namespace FhirResourceGenerator.Core;

/// <summary>
/// 資源生成器介面
/// 
/// <para>
/// 負責根據資源定義生成 C# 資源類別程式碼。
/// </para>
/// </summary>
public interface IResourceGenerator
{
    /// <summary>
    /// 生成單一資源
    /// </summary>
    /// <param name="definition">資源定義</param>
    /// <param name="context">生成上下文</param>
    /// <returns>生成結果</returns>
    Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context);

    /// <summary>
    /// 生成多個資源
    /// </summary>
    /// <param name="definitions">資源定義集合</param>
    /// <param name="context">生成上下文</param>
    /// <returns>生成結果</returns>
    Task<GenerationResult> GenerateResourcesAsync(IEnumerable<ResourceDefinition> definitions, GeneratorContext context);
}

/// <summary>
/// 專案生成器介面
/// 
/// <para>
/// 負責生成完整的 FHIR 資源專案，包括專案檔、工廠類別和測試。
/// </para>
/// </summary>
public interface IProjectGenerator
{
    /// <summary>
    /// 生成完整專案
    /// </summary>
    /// <param name="context">生成上下文</param>
    /// <returns>生成結果</returns>
    Task<GenerationResult> GenerateProjectAsync(GeneratorContext context);
}