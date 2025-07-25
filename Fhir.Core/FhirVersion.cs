namespace Fhir.Core;

/// <summary>
/// FHIR 版本管理
/// </summary>
public static class FhirVersion
{
    /// <summary>
    /// 目前使用的 FHIR 版本
    /// </summary>
    public static string Current { get; private set; } = "R4";
    
    /// <summary>
    /// 設定使用 R4 版本
    /// </summary>
    public static void UseR4()
    {
        Current = "R4";
    }
    
    /// <summary>
    /// 設定使用 R5 版本
    /// </summary>
    public static void UseR5()
    {
        Current = "R5";
    }
    
    /// <summary>
    /// 檢查是否為指定版本
    /// </summary>
    /// <param name="version">版本名稱</param>
    /// <returns>是否為指定版本</returns>
    public static bool Is(string version)
    {
        return string.Equals(Current, version, StringComparison.OrdinalIgnoreCase);
    }
    
    /// <summary>
    /// 取得版本資訊
    /// </summary>
    /// <returns>版本資訊</returns>
    public static VersionInfo GetVersionInfo()
    {
        return Current.ToUpper() switch
        {
            "R4" => new VersionInfo("R4", "4.0.1", "FHIR R4"),
            "R5" => new VersionInfo("R5", "5.0.0", "FHIR R5"),
            _ => throw new NotSupportedException($"Unsupported FHIR version: {Current}")
        };
    }
}

/// <summary>
/// 版本資訊
/// </summary>
/// <param name="Name">版本名稱</param>
/// <param name="Number">版本號</param>
/// <param name="Description">版本描述</param>
public record VersionInfo(string Name, string Number, string Description);
