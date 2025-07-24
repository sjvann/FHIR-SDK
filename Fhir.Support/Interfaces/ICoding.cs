namespace Fhir.Support.Interfaces;

/// <summary>
/// 代表一個 FHIR Coding 元素
/// </summary>
public interface ICoding : IElement
{
    /// <summary>
    /// 編碼系統
    /// </summary>
    string? System { get; set; }

    /// <summary>
    /// 版本
    /// </summary>
    string? Version { get; set; }

    /// <summary>
    /// 代碼
    /// </summary>
    string? Code { get; set; }

    /// <summary>
    /// 顯示名稱
    /// </summary>
    string? Display { get; set; }

    /// <summary>
    /// 是否為使用者選擇
    /// </summary>
    bool? UserSelected { get; set; }
} 