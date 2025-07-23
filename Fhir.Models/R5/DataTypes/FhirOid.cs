// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// An OID represented as a URI
/// </summary>
public class FhirOid : FhirStringType
{
    /// <summary>
    /// 建立新的 FhirOid 實例
    /// </summary>
    public FhirOid() { }

    /// <summary>
    /// 建立新的 FhirOid 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirOid(string value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 string
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirOid?(string value)
    {
        return value == null ? null : new FhirOid(value);
    }

    /// <summary>
    /// 隱式轉換到 string
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator string(FhirOid? fhirValue)
    {
        return fhirValue?.Value;
    }
}
