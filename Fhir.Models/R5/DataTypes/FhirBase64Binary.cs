// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;
using Fhir.Support.Attributes;

namespace Fhir.R5.Models;

/// <summary>
/// A stream of bytes
/// </summary>
public class FhirBase64Binary : FhirPrimitiveType<byte[]>
{
    /// <summary>
    /// 建立新的 FhirBase64Binary 實例
    /// </summary>
    public FhirBase64Binary() { }

    /// <summary>
    /// 建立新的 FhirBase64Binary 實例
    /// </summary>
    /// <param name="value">初始值</param>
    public FhirBase64Binary(byte[] value) : base(value) { }

    /// <summary>
    /// 隱式轉換從 byte[]
    /// </summary>
    /// <param name="value">原生值</param>
    public static implicit operator FhirBase64Binary?(byte[] value)
    {
        return value == null ? null : new FhirBase64Binary(value);
    }

    /// <summary>
    /// 隱式轉換到 byte[]
    /// </summary>
    /// <param name="fhirValue">FHIR 值</param>
    public static implicit operator byte[](FhirBase64Binary? fhirValue)
    {
        return fhirValue?.Value;
    }

    /// <summary>
    /// 轉換為 Base64 字串
    /// </summary>
    /// <returns>Base64 字串</returns>
    public string ToBase64String() => Value != null ? Convert.ToBase64String(Value) : string.Empty;

    /// <summary>
    /// 從 Base64 字串建立
    /// </summary>
    /// <param name="base64String">Base64 字串</param>
    /// <returns>FhirBase64Binary 實例</returns>
    public static FhirBase64Binary FromBase64String(string base64String)
    {
        return new FhirBase64Binary(Convert.FromBase64String(base64String));
    }
}
