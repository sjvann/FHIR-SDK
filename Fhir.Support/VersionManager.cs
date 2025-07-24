using System.Reflection;

namespace Fhir.Support;

/// <summary>
/// FHIR 版本管理器
/// </summary>
public static class VersionManager
{
    /// <summary>
    /// 目前使用的 FHIR 版本
    /// </summary>
    public static string CurrentVersion { get; private set; } = "R5";

    /// <summary>
    /// 支援的 FHIR 版本
    /// </summary>
    public static readonly string[] SupportedVersions = { "R4", "R5", "R6" };

    /// <summary>
    /// 設定目前版本
    /// </summary>
    /// <param name="version">FHIR 版本</param>
    public static void SetCurrentVersion(string version)
    {
        if (!SupportedVersions.Contains(version))
        {
            throw new ArgumentException($"Unsupported FHIR version: {version}. Supported versions: {string.Join(", ", SupportedVersions)}");
        }
        CurrentVersion = version;
    }

    /// <summary>
    /// 取得指定版本的命名空間
    /// </summary>
    /// <param name="version">FHIR 版本</param>
    /// <returns>命名空間</returns>
    public static string GetNamespace(string version)
    {
        return $"Fhir.{version}.Models";
    }

    /// <summary>
    /// 取得目前版本的命名空間
    /// </summary>
    /// <returns>命名空間</returns>
    public static string GetCurrentNamespace()
    {
        return GetNamespace(CurrentVersion);
    }

    /// <summary>
    /// 取得指定版本的型別
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <param name="version">FHIR 版本</param>
    /// <returns>型別</returns>
    public static Type? GetType(string typeName, string version)
    {
        var namespaceName = GetNamespace(version);
        var fullTypeName = $"{namespaceName}.{typeName}";
        
        // 嘗試從已載入的組件中取得型別
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            var type = assembly.GetType(fullTypeName);
            if (type != null)
            {
                return type;
            }
        }
        
        return null;
    }

    /// <summary>
    /// 取得目前版本的型別
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <returns>型別</returns>
    public static Type? GetCurrentType(string typeName)
    {
        return GetType(typeName, CurrentVersion);
    }

    /// <summary>
    /// 建立指定版本的實例
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <param name="version">FHIR 版本</param>
    /// <param name="args">建構函式參數</param>
    /// <returns>實例</returns>
    public static object? CreateInstance(string typeName, string version, params object[] args)
    {
        var type = GetType(typeName, version);
        if (type == null)
        {
            return null;
        }
        
        return Activator.CreateInstance(type, args);
    }

    /// <summary>
    /// 建立目前版本的實例
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <param name="args">建構函式參數</param>
    /// <returns>實例</returns>
    public static object? CreateCurrentInstance(string typeName, params object[] args)
    {
        return CreateInstance(typeName, CurrentVersion, args);
    }

    /// <summary>
    /// 檢查指定版本是否支援
    /// </summary>
    /// <param name="version">FHIR 版本</param>
    /// <returns>是否支援</returns>
    public static bool IsVersionSupported(string version)
    {
        return SupportedVersions.Contains(version);
    }

    /// <summary>
    /// 取得版本目錄路徑
    /// </summary>
    /// <param name="version">FHIR 版本</param>
    /// <returns>目錄路徑</returns>
    public static string GetVersionDirectory(string version)
    {
        return Path.Combine("Fhir.Models", version);
    }

    /// <summary>
    /// 取得目前版本的目錄路徑
    /// </summary>
    /// <returns>目錄路徑</returns>
    public static string GetCurrentVersionDirectory()
    {
        return GetVersionDirectory(CurrentVersion);
    }
} 