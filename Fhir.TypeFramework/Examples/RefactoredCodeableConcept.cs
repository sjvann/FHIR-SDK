using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// CodeableConcept - 可編碼概念型別
/// 用於在 FHIR 資源中表示可編碼的概念
/// </summary>
/// <remarks>
/// FHIR R5 CodeableConcept (Complex Type)
/// A concept that may be defined by a formal reference to a terminology or ontology
/// or may be provided by text.
/// 
/// Structure:
/// - coding: Coding[] (0..*) - Code defined by a terminology system
/// - text: string (0..1) - Plain text representation of the concept
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// 
/// 重構後使用 ComplexTypeBase 基礎類別，大幅減少重複程式碼。
/// </remarks>
public class CodeableConcept : ComplexTypeBase
{
    /// <summary>
    /// 由術語系統定義的編碼
    /// FHIR Path: CodeableConcept.coding
    /// Cardinality: 0..*
    /// Type: Coding[]
    /// </summary>
    [JsonPropertyName("coding")]
    public IList<Coding>? Coding { get; set; }

    /// <summary>
    /// 概念的純文字表示
    /// FHIR Path: CodeableConcept.text
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// 檢查是否有編碼
    /// </summary>
    /// <returns>如果存在編碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCoding => Coding?.Any() == true;

    /// <summary>
    /// 檢查是否有文字
    /// </summary>
    /// <returns>如果存在文字則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasText => !string.IsNullOrEmpty(Text?.Value);

    /// <summary>
    /// 取得顯示文字
    /// </summary>
    /// <returns>顯示文字</returns>
    [JsonIgnore]
    public string? DisplayText => Text?.Value ?? Coding?.FirstOrDefault()?.Display?.Value;

    /// <summary>
    /// 取得指定系統的編碼
    /// </summary>
    /// <param name="system">編碼系統</param>
    /// <returns>找到的編碼，如果不存在則為 null</returns>
    public Coding? GetCoding(string system)
    {
        return Coding?.FirstOrDefault(c => c.System?.Value == system);
    }

    /// <summary>
    /// 添加編碼
    /// </summary>
    /// <param name="coding">要添加的編碼</param>
    public void AddCoding(Coding coding)
    {
        Coding ??= new List<Coding>();
        Coding.Add(coding);
    }

    /// <summary>
    /// 移除指定系統的編碼
    /// </summary>
    /// <param name="system">要移除的編碼系統</param>
    /// <returns>如果成功移除則為 true，否則為 false</returns>
    public bool RemoveCoding(string system)
    {
        if (Coding == null) return false;
        
        var toRemove = Coding.Where(c => c.System?.Value == system).ToList();
        foreach (var coding in toRemove)
        {
            Coding.Remove(coding);
        }
        
        return toRemove.Any();
    }

    /// <summary>
    /// 深層複製內部邏輯
    /// </summary>
    /// <param name="copy">要複製的目標物件</param>
    protected override void DeepCopyInternal(ComplexTypeBase copy)
    {
        var typedCopy = (CodeableConcept)copy;
        
        // 使用基礎類別的輔助方法
        typedCopy.Coding = DeepCopyList(Coding);
        typedCopy.Text = Text?.DeepCopy() as FhirString;
    }

    /// <summary>
    /// 相等性比較內部邏輯
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果相等則為 true，否則為 false</returns>
    protected override bool IsExactlyInternal(ComplexTypeBase other)
    {
        var typedOther = (CodeableConcept)other;
        
        // 使用基礎類別的輔助方法
        return Equals(Text, typedOther.Text) && AreListsEqual(Coding, typedOther.Coding);
    }

    /// <summary>
    /// 驗證內部邏輯
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    protected override IEnumerable<ValidationResult> ValidateInternal(ValidationContext validationContext)
    {
        // 使用基礎類別的輔助方法
        return ValidateList(Coding, validationContext);
    }
} 