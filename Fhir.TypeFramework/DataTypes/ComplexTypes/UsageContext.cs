using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// UsageContext - 使用上下文
/// 用於描述資源的使用上下文
/// </summary>
/// <remarks>
/// FHIR R5 UsageContext (Complex Type)
/// Specifies the clinical/business/etc. context of this resource.
/// 
/// Structure:
/// - code: Coding (1..1) - Type of context being specified
/// - value[x]: CodeableConcept|Quantity|Range|Reference (1..1) - Value that defines the context
/// </remarks>
public class UsageContext : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// Type of context being specified
    /// FHIR Path: UsageContext.code
    /// Cardinality: 1..1
    /// Type: Coding
    /// </summary>
    [JsonPropertyName("code")]
    public Coding Code { get; set; } = new();

    /// <summary>
    /// Value that defines the context
    /// FHIR Path: UsageContext.value[x]
    /// Cardinality: 1..1
    /// Type: CodeableConcept|Quantity|Range|Reference
    /// </summary>
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept? ValueCodeableConcept { get; set; }

    [JsonPropertyName("valueQuantity")]
    public Quantity? ValueQuantity { get; set; }

    [JsonPropertyName("valueRange")]
    public Range? ValueRange { get; set; }

    [JsonPropertyName("valueReference")]
    public Reference? ValueReference { get; set; }

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => ValueCodeableConcept != null || ValueQuantity != null || ValueRange != null || ValueReference != null;

    /// <summary>
    /// 設定 CodeableConcept 值
    /// </summary>
    /// <param name="value">CodeableConcept 值</param>
    public void SetValue(CodeableConcept value)
    {
        ValueCodeableConcept = value;
        ValueQuantity = null;
        ValueRange = null;
        ValueReference = null;
    }

    /// <summary>
    /// 設定 Quantity 值
    /// </summary>
    /// <param name="value">Quantity 值</param>
    public void SetValue(Quantity value)
    {
        ValueCodeableConcept = null;
        ValueQuantity = value;
        ValueRange = null;
        ValueReference = null;
    }

    /// <summary>
    /// 設定 Range 值
    /// </summary>
    /// <param name="value">Range 值</param>
    public void SetValue(Range value)
    {
        ValueCodeableConcept = null;
        ValueQuantity = null;
        ValueRange = value;
        ValueReference = null;
    }

    /// <summary>
    /// 設定 Reference 值
    /// </summary>
    /// <param name="value">Reference 值</param>
    public void SetValue(Reference value)
    {
        ValueCodeableConcept = null;
        ValueQuantity = null;
        ValueRange = null;
        ValueReference = value;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>UsageContext 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new UsageContext
        {
            Id = Id,
            Code = Code.DeepCopy() as Coding ?? new Coding()
        };

        if (ValueCodeableConcept != null)
        {
            copy.ValueCodeableConcept = ValueCodeableConcept.DeepCopy() as CodeableConcept;
        }

        if (ValueQuantity != null)
        {
            copy.ValueQuantity = ValueQuantity.DeepCopy() as Quantity;
        }

        if (ValueRange != null)
        {
            copy.ValueRange = ValueRange.DeepCopy() as Range;
        }

        if (ValueReference != null)
        {
            copy.ValueReference = ValueReference.DeepCopy() as Reference;
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 UsageContext 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not UsageContext otherUsage)
            return false;

        return base.IsExactly(other) &&
               Code.IsExactly(otherUsage.Code) &&
               Equals(ValueCodeableConcept, otherUsage.ValueCodeableConcept) &&
               Equals(ValueQuantity, otherUsage.ValueQuantity) &&
               Equals(ValueRange, otherUsage.ValueRange) &&
               Equals(ValueReference, otherUsage.ValueReference);
    }

    /// <summary>
    /// 驗證 UsageContext 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 Code
        var codeValidationContext = new ValidationContext(Code);
        foreach (var result in Code.Validate(codeValidationContext))
        {
            yield return result;
        }

        // 驗證值（必須有且僅有一個值）
        var valueCount = 0;
        if (ValueCodeableConcept != null) valueCount++;
        if (ValueQuantity != null) valueCount++;
        if (ValueRange != null) valueCount++;
        if (ValueReference != null) valueCount++;

        if (valueCount == 0)
        {
            yield return new ValidationResult("UsageContext must have exactly one value");
        }
        else if (valueCount > 1)
        {
            yield return new ValidationResult("UsageContext can only have one value");
        }

        // 驗證各個值
        if (ValueCodeableConcept != null)
        {
            var valueValidationContext = new ValidationContext(ValueCodeableConcept);
            foreach (var result in ValueCodeableConcept.Validate(valueValidationContext))
            {
                yield return result;
            }
        }

        if (ValueQuantity != null)
        {
            var valueValidationContext = new ValidationContext(ValueQuantity);
            foreach (var result in ValueQuantity.Validate(valueValidationContext))
            {
                yield return result;
            }
        }

        if (ValueRange != null)
        {
            var valueValidationContext = new ValidationContext(ValueRange);
            foreach (var result in ValueRange.Validate(valueValidationContext))
            {
                yield return result;
            }
        }

        if (ValueReference != null)
        {
            var valueValidationContext = new ValidationContext(ValueReference);
            foreach (var result in ValueReference.Validate(valueValidationContext))
            {
                yield return result;
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 