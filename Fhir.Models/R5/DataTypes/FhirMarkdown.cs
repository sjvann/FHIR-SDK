// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A string that may contain Github Flavored Markdown syntax
/// </summary>
public class FhirMarkdown : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirMarkdown 實例
    /// </summary>
    public FhirMarkdown() { }

    /// <summary>
    /// 建立新的 FhirMarkdown 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirMarkdown(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirMarkdown?(string value)
    {
        return value == null ? null : new FhirMarkdown(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirMarkdown? fhirValue)
    {
        return fhirValue?.Value;
    }
}
