using System.ComponentModel.DataAnnotations;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR 資料型別的基礎類別
/// </summary>
public abstract class DataType : Element, IDataType
{
    /// <summary>
    /// 建立新的 DataType 實例
    /// </summary>
    protected DataType() { }

    /// <summary>
    /// 建立新的 DataType 實例
    /// </summary>
    /// <param name="element">基礎元素</param>
    protected DataType(Element? element = null) : base(element) { }

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 子類別可以覆寫此方法來添加特定的驗證邏輯
    }
} 