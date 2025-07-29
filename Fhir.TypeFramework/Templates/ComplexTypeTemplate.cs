using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// {TypeName} - {Description}
/// </summary>
/// <remarks>
/// FHIR R5 {TypeName} (Complex Type)
/// {DetailedDescription}
/// 
/// Structure:
/// {StructureDescription}
/// 
/// JSON Representation:
/// {JsonExample}
/// </remarks>
public class {ClassName} : ComplexTypeBase
{
    // ============================================================================
    // 屬性定義
    // ============================================================================

    {Properties}

    // ============================================================================
    // 計算屬性
    // ============================================================================

    {ComputedProperties}

    // ============================================================================
    // 建構函式
    // ============================================================================

    /// <summary>
    /// 預設建構函式
    /// </summary>
    public {ClassName}() { }

    // ============================================================================
    // 輔助方法
    // ============================================================================

    {HelperMethods}

    // ============================================================================
    // 深層複製內部邏輯
    // ============================================================================

    /// <summary>
    /// 深層複製內部邏輯
    /// </summary>
    /// <param name="copy">要複製的目標物件</param>
    protected override void DeepCopyInternal(ComplexTypeBase copy)
    {
        var typedCopy = ({ClassName})copy;
        
        {DeepCopyLogic}
    }

    // ============================================================================
    // 相等性比較內部邏輯
    // ============================================================================

    /// <summary>
    /// 相等性比較內部邏輯
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果相等則為 true，否則為 false</returns>
    protected override bool IsExactlyInternal(ComplexTypeBase other)
    {
        var typedOther = ({ClassName})other;
        
        {EqualityLogic}
    }

    // ============================================================================
    // 驗證內部邏輯
    // ============================================================================

    /// <summary>
    /// 驗證內部邏輯
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    protected override IEnumerable<ValidationResult> ValidateInternal(ValidationContext validationContext)
    {
        {ValidationLogic}
    }
} 