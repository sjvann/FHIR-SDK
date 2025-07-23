// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A URI that is a reference to a canonical URL on a FHIR resource
/// </summary>
public class FhirCanonical : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirCanonical 實例
    /// </summary>
    public FhirCanonical() { }

    /// <summary>
    /// 建立新的 FhirCanonical 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirCanonical(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirCanonical?(string value)
    {
        return value == null ? null : new FhirCanonical(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirCanonical? fhirValue)
    {
        return fhirValue?.Value;
    }
}
