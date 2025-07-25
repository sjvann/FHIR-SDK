namespace Fhir.Abstractions.Resources;

/// <summary>
/// Patient 資源的共通介面
/// 定義所有 FHIR 版本中 Patient 的共通屬性
/// </summary>
public interface IPatient : IDomainResource
{
    /// <summary>
    /// 病患是否為啟用狀態
    /// </summary>
    bool? Active { get; set; }
    
    /// <summary>
    /// 病患姓名
    /// 使用 object 類型以支援不同版本的 HumanName 實作
    /// </summary>
    IList<object>? Name { get; set; }
    
    /// <summary>
    /// 性別
    /// 使用 string 以支援不同版本的列舉值
    /// </summary>
    string? Gender { get; set; }
    
    /// <summary>
    /// 出生日期
    /// </summary>
    string? BirthDate { get; set; }
    
    /// <summary>
    /// 是否已過世
    /// </summary>
    bool? Deceased { get; set; }
    
    /// <summary>
    /// 聯絡資訊
    /// </summary>
    IList<object>? Telecom { get; set; }
    
    /// <summary>
    /// 地址
    /// </summary>
    IList<object>? Address { get; set; }
}
