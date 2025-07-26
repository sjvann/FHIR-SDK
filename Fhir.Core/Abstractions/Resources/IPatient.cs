using System.ComponentModel.DataAnnotations;

namespace Fhir.Core.Abstractions.Resources;

/// <summary>
/// Patient 資源的抽象介面
/// 定義所有版本的 Patient 共通屬性
/// </summary>
public interface IPatient : IDomainResource
{
    /// <summary>
    /// 患者識別碼
    /// </summary>
    IList<object>? Identifier { get; set; }
    
    /// <summary>
    /// 是否為活躍狀態
    /// </summary>
    bool? Active { get; set; }
    
    /// <summary>
    /// 患者姓名
    /// </summary>
    IList<object>? Name { get; set; }
    
    /// <summary>
    /// 聯絡方式
    /// </summary>
    IList<object>? Telecom { get; set; }
    
    /// <summary>
    /// 性別
    /// </summary>
    string? Gender { get; set; }
    
    /// <summary>
    /// 出生日期
    /// </summary>
    string? BirthDate { get; set; }
    
    /// <summary>
    /// 地址
    /// </summary>
    IList<object>? Address { get; set; }
}
