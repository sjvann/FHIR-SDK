namespace FhirResourceGenerator.Core;

/// <summary>
/// 模板引擎介面
/// 
/// <para>
/// 負責根據模板和資料生成程式碼片段。
/// </para>
/// </summary>
public interface ITemplateEngine
{
    /// <summary>
    /// 生成資源類別程式碼
    /// </summary>
    /// <param name="definition">資源定義</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的程式碼</returns>
    string GenerateResourceClass(ResourceDefinition definition, TemplateContext context);

    /// <summary>
    /// 生成屬性程式碼
    /// </summary>
    /// <param name="property">屬性定義</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的程式碼</returns>
    string GenerateProperty(PropertyDefinition property, TemplateContext context);

    /// <summary>
    /// 生成文檔註解
    /// </summary>
    /// <param name="docs">文檔資料</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的程式碼</returns>
    string GenerateDocumentation(DocumentationData docs, TemplateContext context);

    /// <summary>
    /// 生成工廠方法程式碼
    /// </summary>
    /// <param name="definition">資源定義</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的程式碼</returns>
    string GenerateFactoryMethods(ResourceDefinition definition, TemplateContext context);

    /// <summary>
    /// 生成專案檔案
    /// </summary>
    /// <param name="projectInfo">專案資訊</param>
    /// <param name="context">模板上下文</param>
    /// <returns>生成的專案檔內容</returns>
    string GenerateProjectFile(ProjectInfo projectInfo, TemplateContext context);
}