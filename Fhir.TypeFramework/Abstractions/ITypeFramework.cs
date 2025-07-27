namespace Fhir.TypeFramework.Abstractions;

/// <summary>
/// FHIR Type Framework 核心介面
/// 定義所有 FHIR 型別的基本行為
/// </summary>
/// <remarks>
/// 這是所有 FHIR 型別的基礎介面，提供型別名稱、深層複製、相等性比較和驗證功能。
/// </remarks>
public interface ITypeFramework
{
    /// <summary>
    /// 取得型別名稱
    /// </summary>
    /// <returns>型別的名稱</returns>
    string TypeName { get; }
    
    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>ITypeFramework 物件的深層複本</returns>
    ITypeFramework DeepCopy();
    
    /// <summary>
    /// 判斷與另一個物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    bool IsExactly(ITypeFramework other);
    
    /// <summary>
    /// 驗證物件是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
}

/// <summary>
/// 可序列化的 FHIR 型別介面
/// </summary>
/// <remarks>
/// 提供 JSON 序列化和反序列化功能。
/// </remarks>
public interface ISerializableTypeFramework : ITypeFramework
{
    /// <summary>
    /// 序列化為 JSON
    /// </summary>
    /// <returns>JSON 字串</returns>
    string ToJson();
    
    /// <summary>
    /// 從 JSON 反序列化
    /// </summary>
    /// <param name="json">要反序列化的 JSON 字串</param>
    void FromJson(string json);
}

/// <summary>
/// 具有 ID 的 FHIR 型別介面
/// </summary>
/// <remarks>
/// 提供唯一識別碼功能。
/// </remarks>
public interface IIdentifiableTypeFramework : ITypeFramework
{
    /// <summary>
    /// 唯一識別碼
    /// </summary>
    /// <returns>物件的唯一識別碼</returns>
    string? Id { get; set; }
}

/// <summary>
/// 具有擴展功能的 FHIR 型別介面
/// </summary>
/// <remarks>
/// 提供擴展功能，允許添加額外的資訊。
/// </remarks>
public interface IExtensibleTypeFramework : ITypeFramework
{
    /// <summary>
    /// 擴展項目
    /// </summary>
    /// <returns>擴展項目列表</returns>
    IList<IExtension>? Extension { get; set; }
    
    /// <summary>
    /// 檢查是否有擴展
    /// </summary>
    /// <returns>如果存在擴展則為 true，否則為 false</returns>
    bool HasExtensions { get; }
    
    /// <summary>
    /// 取得指定 URL 的擴展
    /// </summary>
    /// <param name="url">要查詢的擴展 URL</param>
    /// <returns>找到的擴展，如果不存在則為 null</returns>
    IExtension? GetExtension(string url);
    
    /// <summary>
    /// 添加擴展
    /// </summary>
    /// <param name="url">擴展的 URL</param>
    /// <param name="value">擴展的值</param>
    void AddExtension(string url, object? value);
    
    /// <summary>
    /// 移除指定 URL 的擴展
    /// </summary>
    /// <param name="url">要移除的擴展 URL</param>
    /// <returns>如果成功移除則為 true，否則為 false</returns>
    bool RemoveExtension(string url);
}

/// <summary>
/// 擴展介面
/// </summary>
/// <remarks>
/// 定義擴展的基本結構，包含 URL 和值。
/// </remarks>
public interface IExtension : ITypeFramework
{
    /// <summary>
    /// 擴展的 URL
    /// </summary>
    /// <returns>擴展的 URL</returns>
    string? Url { get; set; }
    
    /// <summary>
    /// 擴展的值
    /// </summary>
    /// <returns>擴展的值</returns>
    object? Value { get; set; }
} 