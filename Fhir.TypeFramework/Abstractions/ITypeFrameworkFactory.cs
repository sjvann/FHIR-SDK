using Fhir.TypeFramework.Abstractions;

namespace Fhir.TypeFramework.Abstractions;

/// <summary>
/// FHIR 型別工廠介面
/// 用於建立各種 FHIR 型別的實例
/// </summary>
/// <remarks>
/// 提供建立 FHIR 型別實例的工廠方法，支援泛型和型別名稱兩種方式。
/// </remarks>
public interface ITypeFrameworkFactory
{
    /// <summary>
    /// 建立指定型別的實例
    /// </summary>
    /// <typeparam name="T">要建立的型別</typeparam>
    /// <returns>型別實例</returns>
    T Create<T>() where T : ITypeFramework, new();

    /// <summary>
    /// 建立指定型別的實例（使用型別名稱）
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <returns>型別實例，如果找不到型別則為 null</returns>
    ITypeFramework? Create(string typeName);

    /// <summary>
    /// 建立 Extension 實例
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <param name="value">擴展值</param>
    /// <returns>Extension 實例</returns>
    IExtension CreateExtension(string url, object? value);

    /// <summary>
    /// 從 JSON 建立型別實例
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="json">JSON 字串</param>
    /// <returns>型別實例，如果反序列化失敗則為 null</returns>
    T? CreateFromJson<T>(string json) where T : ITypeFramework;

    /// <summary>
    /// 從 JSON 建立型別實例（使用型別名稱）
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <param name="json">JSON 字串</param>
    /// <returns>型別實例，如果找不到型別或反序列化失敗則為 null</returns>
    ITypeFramework? CreateFromJson(string typeName, string json);
}

/// <summary>
/// 型別註冊器介面
/// </summary>
/// <remarks>
/// 提供型別註冊和管理功能，支援動態型別發現。
/// </remarks>
public interface ITypeRegistry
{
    /// <summary>
    /// 註冊型別
    /// </summary>
    /// <typeparam name="T">要註冊的型別</typeparam>
    void Register<T>() where T : ITypeFramework, new();

    /// <summary>
    /// 註冊型別（使用自訂名稱）
    /// </summary>
    /// <typeparam name="T">要註冊的型別</typeparam>
    /// <param name="typeName">型別名稱</param>
    void Register<T>(string typeName) where T : ITypeFramework, new();

    /// <summary>
    /// 取得已註冊的型別
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <returns>型別，如果未註冊則為 null</returns>
    Type? GetType(string typeName);

    /// <summary>
    /// 取得所有已註冊的型別名稱
    /// </summary>
    /// <returns>型別名稱集合</returns>
    IEnumerable<string> GetRegisteredTypeNames();
} 