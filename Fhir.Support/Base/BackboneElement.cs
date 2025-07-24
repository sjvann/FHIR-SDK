using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Interfaces;

namespace Fhir.Support.Base;

/// <summary>
/// FHIR BackboneElement 類別 - 用於 Resource 中的群組元素
/// </summary>
public abstract class BackboneElement : Element, IBackboneElement
{
    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the element and that modifies the understanding of the element in which it is contained and/or the understanding of the containing element's descendants.
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public List<IExtension>? ModifierExtension { get; set; }

    /// <summary>
    /// 建立新的 BackboneElement 實例
    /// </summary>
    protected BackboneElement() { }

    /// <summary>
    /// 建立新的 BackboneElement 實例
    /// </summary>
    /// <param name="element">基礎元素</param>
    protected BackboneElement(Element? element = null) : base(element) { }

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證修飾符擴展
        if (ModifierExtension != null)
        {
            foreach (var modifierExtension in ModifierExtension)
            {
                if (modifierExtension is Element element)
                {
                    Validator.TryValidateObject(element, new ValidationContext(element), new List<ValidationResult>(), true);
                }
            }
        }
    }
} 