using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.DataTypes;

/// <summary>
/// Count - 計數
/// 用於描述計數值
/// </summary>
/// <remarks>
/// FHIR R5 Count (Complex Type)
/// A measured amount (or an amount that can potentially be measured).
/// 
/// Structure:
/// - value: decimal (0..1) - Numerical value (with implicit precision)
/// - comparator: code (0..1) - < | <= | >= | > - how to understand the value
/// - unit: string (0..1) - Unit representation
/// - system: uri (0..1) - System that defines coded unit form
/// - code: code (0..1) - Coded form of the unit
/// - id: string (0..1) - inherited from Element
/// - extension: Extension[] (0..*) - inherited from Element
/// </remarks>
public class Count : Element, IExtensibleTypeFramework
{
    /// <summary>
    /// 數值（隱含精度）
    /// FHIR Path: Count.value
    /// Cardinality: 0..1
    /// Type: decimal
    /// </summary>
    [JsonPropertyName("value")]
    public FhirDecimal? Value { get; set; }

    /// <summary>
    /// 比較器
    /// FHIR Path: Count.comparator
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("comparator")]
    public FhirCode? Comparator { get; set; }

    /// <summary>
    /// 單位表示
    /// FHIR Path: Count.unit
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    [JsonPropertyName("unit")]
    public FhirString? Unit { get; set; }

    /// <summary>
    /// 定義編碼單位形式的系統
    /// FHIR Path: Count.system
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    [JsonPropertyName("system")]
    public FhirUri? System { get; set; }

    /// <summary>
    /// 單位的編碼形式
    /// FHIR Path: Count.code
    /// Cardinality: 0..1
    /// Type: code
    /// </summary>
    [JsonPropertyName("code")]
    public FhirCode? Code { get; set; }

    /// <summary>
    /// 檢查是否有值
    /// </summary>
    /// <returns>如果存在值則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasValue => Value != null;

    /// <summary>
    /// 檢查是否有比較器
    /// </summary>
    /// <returns>如果存在比較器則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasComparator => !string.IsNullOrEmpty(Comparator);

    /// <summary>
    /// 檢查是否有單位
    /// </summary>
    /// <returns>如果存在單位則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasUnit => !string.IsNullOrEmpty(Unit);

    /// <summary>
    /// 檢查是否有系統
    /// </summary>
    /// <returns>如果存在系統則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasSystem => !string.IsNullOrEmpty(System);

    /// <summary>
    /// 檢查是否有代碼
    /// </summary>
    /// <returns>如果存在代碼則為 true，否則為 false</returns>
    [JsonIgnore]
    public bool HasCode => !string.IsNullOrEmpty(Code);

    /// <summary>
    /// 設定值
    /// </summary>
    /// <param name="value">數值</param>
    public void SetValue(decimal value)
    {
        Value = new FhirDecimal(value);
    }

    /// <summary>
    /// 設定比較器
    /// </summary>
    /// <param name="comparator">比較器代碼</param>
    public void SetComparator(string comparator)
    {
        Comparator = new FhirCode(comparator);
    }

    /// <summary>
    /// 設定單位
    /// </summary>
    /// <param name="unit">單位字串</param>
    public void SetUnit(string unit)
    {
        Unit = new FhirString(unit);
    }

    /// <summary>
    /// 設定系統
    /// </summary>
    /// <param name="system">系統 URI</param>
    public void SetSystem(string system)
    {
        System = new FhirUri(system);
    }

    /// <summary>
    /// 設定代碼
    /// </summary>
    /// <param name="code">代碼</param>
    public void SetCode(string code)
    {
        Code = new FhirCode(code);
    }

    /// <summary>
    /// 取得數值
    /// </summary>
    /// <returns>數值，如果不存在則返回 null</returns>
    public decimal? GetValue()
    {
        return Value?.Value;
    }

    /// <summary>
    /// 取得比較器
    /// </summary>
    /// <returns>比較器代碼，如果不存在則返回 null</returns>
    public string? GetComparator()
    {
        return Comparator?.Value;
    }

    /// <summary>
    /// 取得單位
    /// </summary>
    /// <returns>單位字串，如果不存在則返回 null</returns>
    public string? GetUnit()
    {
        return Unit?.Value;
    }

    /// <summary>
    /// 取得系統
    /// </summary>
    /// <returns>系統 URI，如果不存在則返回 null</returns>
    public string? GetSystem()
    {
        return System?.Value;
    }

    /// <summary>
    /// 取得代碼
    /// </summary>
    /// <returns>代碼，如果不存在則返回 null</returns>
    public string? GetCode()
    {
        return Code?.Value;
    }

    /// <summary>
    /// 建立物件的深層複本
    /// </summary>
    /// <returns>Count 的深層複本</returns>
    public override Base DeepCopy()
    {
        var copy = new Count
        {
            Id = Id,
            Value = Value,
            Comparator = Comparator,
            Unit = Unit,
            System = System,
            Code = Code
        };

        if (Extension != null)
        {
            copy.Extension = Extension.Select(ext => ext.DeepCopy() as IExtension).ToList();
        }

        return copy;
    }

    /// <summary>
    /// 判斷與另一個 Count 物件是否相等
    /// </summary>
    /// <param name="other">要比較的物件</param>
    /// <returns>如果兩個物件相等則為 true，否則為 false</returns>
    public override bool IsExactly(Base other)
    {
        if (other is not Count otherCount)
            return false;

        return base.IsExactly(other) &&
               Equals(Value, otherCount.Value) &&
               Equals(Comparator, otherCount.Comparator) &&
               Equals(Unit, otherCount.Unit) &&
               Equals(System, otherCount.System) &&
               Equals(Code, otherCount.Code);
    }

    /// <summary>
    /// 驗證 Count 是否符合 FHIR 規範
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果集合</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // 驗證比較器
        if (!string.IsNullOrEmpty(Comparator))
        {
            var validComparators = new[] { "<", "<=", ">=", ">" };
            if (!validComparators.Contains(Comparator))
            {
                yield return new ValidationResult($"Count.comparator '{Comparator}' is not a valid comparator");
            }
        }

        // 驗證系統 URI
        if (!string.IsNullOrEmpty(System) && !Uri.IsWellFormedUriString(System, UriKind.Absolute))
        {
            yield return new ValidationResult("Count.system must be a valid absolute URI");
        }

        // 驗證值
        if (Value != null)
        {
            var valueValidationContext = new ValidationContext(Value);
            foreach (var result in Value.Validate(valueValidationContext))
            {
                yield return result;
            }
        }

        // 驗證單位
        if (Unit != null)
        {
            var unitValidationContext = new ValidationContext(Unit);
            foreach (var result in Unit.Validate(unitValidationContext))
            {
                yield return result;
            }
        }

        // 驗證比較器
        if (Comparator != null)
        {
            var comparatorValidationContext = new ValidationContext(Comparator);
            foreach (var result in Comparator.Validate(comparatorValidationContext))
            {
                yield return result;
            }
        }

        // 驗證系統
        if (System != null)
        {
            var systemValidationContext = new ValidationContext(System);
            foreach (var result in System.Validate(systemValidationContext))
            {
                yield return result;
            }
        }

        // 驗證代碼
        if (Code != null)
        {
            var codeValidationContext = new ValidationContext(Code);
            foreach (var result in Code.Validate(codeValidationContext))
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