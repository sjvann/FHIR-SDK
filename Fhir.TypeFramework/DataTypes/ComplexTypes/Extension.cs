using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Extension - 擴展型別
/// 用於在 FHIR 資源中添加額外資訊
/// </summary>
/// <remarks>
/// FHIR R5 Extension (Complex Type)
/// Optional Extensions Element - found in all resources.
/// Must have either extensions or value[x], not both.
/// 
/// Structure:
/// - url: uri (1..1) - identifies the meaning of the extension
/// - value[x]: * (0..1) - Value of extension
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Extension : Element, IExtension, IExtensibleTypeFramework
{
    /// <summary>
    /// 擴展的 URL - 必須提供
    /// FHIR Path: Extension.url
    /// Cardinality: 1..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("url")]
    [Required(ErrorMessage = "Extension URL is required")]
    public FhirUri? Url { get; set; }

    /// <summary>
    /// 擴展的值 - 使用 Choice Type 來支援多種資料型態
    /// FHIR Path: Extension.value[x]
    /// Cardinality: 0..1
    /// Type: * (any FHIR data type)
    /// 根據 FHIR R5 規範，value[x] 可以接受所有 FHIR 資料型別
    /// </summary>
    [JsonPropertyName("value")]
    public ExtensionValueChoice? Value { get; set; }

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => Value != null;

    /// <summary>
    /// 取得擴展值（如果存在）
    /// </summary>
    /// <typeparam name="T">期望的型別</typeparam>
    /// <returns>轉換後的值，如果型別不匹配則返回 null</returns>
    public T? GetValue<T>() where T : class
    {
        if (Value == null) return null;
        
        return Value.Match(
            t0 => t0 as T,
            t1 => t1 as T,
            t2 => t2 as T,
            t3 => t3 as T,
            t4 => t4 as T
        );
    }

    /// <summary>
    /// 設定擴展值
    /// </summary>
    /// <param name="value">要設定的值</param>
    public void SetValue(ExtensionValueChoice value)
    {
        Value = value;
    }

    /// <summary>
    /// 設定擴展值（泛型版本）
    /// </summary>
    /// <typeparam name="T">值的型別</typeparam>
    /// <param name="value">要設定的值</param>
    public void SetValue<T>(T value) where T : class
    {
        Value = value;
    }

    /// <summary>
    /// 設定字串值
    /// </summary>
    /// <param name="value">字串值</param>
    public void SetStringValue(string value)
    {
        Value = new FhirString(value);
    }

    /// <summary>
    /// 設定整數值
    /// </summary>
    /// <param name="value">整數值</param>
    public void SetIntegerValue(int value)
    {
        Value = new FhirInteger(value);
    }

    /// <summary>
    /// 設定布林值
    /// </summary>
    /// <param name="value">布林值</param>
    public void SetBooleanValue(bool value)
    {
        Value = new FhirBoolean(value);
    }

    /// <summary>
    /// 設定小數值
    /// </summary>
    /// <param name="value">小數值</param>
    public void SetDecimalValue(decimal value)
    {
        Value = new FhirDecimal(value);
    }

    /// <summary>
    /// 設定日期時間值
    /// </summary>
    /// <param name="value">日期時間值</param>
    public void SetDateTimeValue(DateTime value)
    {
        Value = new FhirDateTime(value);
    }

    /// <summary>
    /// 取得字串值
    /// </summary>
    /// <returns>字串值，如果不是字串型別則返回 null</returns>
    public string? GetStringValue()
    {
        return GetValue<FhirString>()?.Value;
    }

    /// <summary>
    /// 取得整數值
    /// </summary>
    /// <returns>整數值，如果不是整數型別則返回 null</returns>
    public int? GetIntegerValue()
    {
        return GetValue<FhirInteger>()?.Value;
    }

    /// <summary>
    /// 取得布林值
    /// </summary>
    /// <returns>布林值，如果不是布林型別則返回 null</returns>
    public bool? GetBooleanValue()
    {
        return GetValue<FhirBoolean>()?.Value;
    }

    /// <summary>
    /// 取得小數值
    /// </summary>
    /// <returns>小數值，如果不是小數型別則返回 null</returns>
    public decimal? GetDecimalValue()
    {
        return GetValue<FhirDecimal>()?.Value;
    }

    /// <summary>
    /// 取得日期時間值
    /// </summary>
    /// <returns>日期時間值，如果不是日期時間型別則返回 null</returns>
    public DateTime? GetDateTimeValue()
    {
        return GetValue<FhirDateTime>()?.Value;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Extension 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Extension
        {
            Id = Id,
            Url = Url
        };

        if (Value != null)
        {
            copy.Value = Value;
        }

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Extension 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Extension otherExtension)
            return false;

        return base.IsExactly(other) &&
               Equals(Url, otherExtension.Url) &&
               Equals(Value, otherExtension.Value);
    }

    /// <summary>
    /// 驗證 Extension 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證 URL
        if (string.IsNullOrEmpty(Url))
        {
            yield return new ValidationResult("Extension URL is required");
        }

        // 驗證 Extension 不能同時有 value 和 nested extensions
        if (Value != null && Extension?.Any() == true)
        {
            yield return new ValidationResult("Extension cannot have both value and nested extensions");
        }

        // 驗證 nested extensions
        if (Extension != null)
        {
            foreach (var ext in Extension)
            {
                if (string.IsNullOrEmpty(ext.Url))
                {
                    yield return new ValidationResult("Nested Extension must have a URL");
                }
                
                var extValidationContext = new ValidationContext(ext);
                foreach (var extResult in ext.Validate(extValidationContext))
                {
                    yield return extResult;
                }
            }
        }

        // 呼叫基礎驗證
        foreach (var result in base.Validate(validationContext))
        {
            yield return result;
        }
    }
} 