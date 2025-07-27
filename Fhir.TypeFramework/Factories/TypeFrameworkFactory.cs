using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes;
using System.Text.Json;

namespace Fhir.TypeFramework.Factories;

/// <summary>
/// FHIR 型別工廠實作
/// </summary>
/// <remarks>
/// 提供建立 FHIR 型別實例的工廠方法實作，支援泛型和型別名稱兩種方式。
/// </remarks>
public class TypeFrameworkFactory : ITypeFrameworkFactory
{
    private readonly ITypeRegistry _typeRegistry;

    /// <summary>
    /// 初始化 TypeFrameworkFactory
    /// </summary>
    /// <param name="typeRegistry">型別註冊器</param>
    public TypeFrameworkFactory(ITypeRegistry typeRegistry)
    {
        _typeRegistry = typeRegistry;
    }

    /// <summary>
    /// 建立指定型別的實例
    /// </summary>
    /// <typeparam name="T">要建立的型別</typeparam>
    /// <returns>型別實例</returns>
    public T Create<T>() where T : ITypeFramework, new()
    {
        return new T();
    }

    /// <summary>
    /// 建立指定型別的實例（使用型別名稱）
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <returns>型別實例，如果找不到型別則為 null</returns>
    public ITypeFramework? Create(string typeName)
    {
        var type = _typeRegistry.GetType(typeName);
        if (type == null)
            return null;

        return Activator.CreateInstance(type) as ITypeFramework;
    }

    /// <summary>
    /// 建立 Extension 實例
    /// </summary>
    /// <param name="url">擴展 URL</param>
    /// <param name="value">擴展值</param>
    /// <returns>Extension 實例</returns>
    public IExtension CreateExtension(string url, object? value)
    {
        return new Extension { Url = url, Value = value };
    }

    /// <summary>
    /// 從 JSON 建立型別實例
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="json">JSON 字串</param>
    /// <returns>型別實例，如果反序列化失敗則為 null</returns>
    public T? CreateFromJson<T>(string json) where T : ITypeFramework
    {
        try
        {
            return JsonSerializer.Deserialize<T>(json);
        }
        catch
        {
            return default;
        }
    }

    /// <summary>
    /// 從 JSON 建立型別實例（使用型別名稱）
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <param name="json">JSON 字串</param>
    /// <returns>型別實例，如果找不到型別或反序列化失敗則為 null</returns>
    public ITypeFramework? CreateFromJson(string typeName, string json)
    {
        var type = _typeRegistry.GetType(typeName);
        if (type == null)
            return null;

        try
        {
            return JsonSerializer.Deserialize(json, type) as ITypeFramework;
        }
        catch
        {
            return null;
        }
    }
}

/// <summary>
/// 型別註冊器實作
/// </summary>
/// <remarks>
/// 提供型別註冊和管理功能的實作，支援動態型別發現。
/// </remarks>
public class TypeRegistry : ITypeRegistry
{
    private readonly Dictionary<string, Type> _registeredTypes = new();

    /// <summary>
    /// 註冊型別
    /// </summary>
    /// <typeparam name="T">要註冊的型別</typeparam>
    public void Register<T>() where T : ITypeFramework, new()
    {
        var typeName = typeof(T).Name;
        _registeredTypes[typeName] = typeof(T);
    }

    /// <summary>
    /// 註冊型別（使用自訂名稱）
    /// </summary>
    /// <typeparam name="T">要註冊的型別</typeparam>
    /// <param name="typeName">型別名稱</param>
    public void Register<T>(string typeName) where T : ITypeFramework, new()
    {
        _registeredTypes[typeName] = typeof(T);
    }

    /// <summary>
    /// 取得已註冊的型別
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <returns>型別，如果未註冊則為 null</returns>
    public Type? GetType(string typeName)
    {
        return _registeredTypes.TryGetValue(typeName, out var type) ? type : null;
    }

    /// <summary>
    /// 取得所有已註冊的型別名稱
    /// </summary>
    /// <returns>型別名稱集合</returns>
    public IEnumerable<string> GetRegisteredTypeNames()
    {
        return _registeredTypes.Keys;
    }
} 