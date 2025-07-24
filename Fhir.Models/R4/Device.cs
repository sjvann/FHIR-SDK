// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A type of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity
/// </summary>
public class Device : SimpleDomainResource
{
    /// <summary>
    /// Instance identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// The reference to the definition for the device
    /// </summary>
    [JsonPropertyName("definition")]
    public SimpleReference? Definition { get; set; }

    /// <summary>
    /// Unique Device Identifier (UDI) Barcode string
    /// </summary>
    [JsonPropertyName("udiCarrier")]
    public SimpleBackboneElement? UdiCarrier { get; set; }

    /// <summary>
    /// active | inactive | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// online | paused | standby | offline | not-ready | transduc-discon | hw-discon
    /// </summary>
    [JsonPropertyName("statusReason")]
    public SimpleCodeableConcept? StatusReason { get; set; }

    /// <summary>
    /// The distinct identification string
    /// </summary>
    [JsonPropertyName("distinctIdentifier")]
    public string? DistinctIdentifier { get; set; }

    /// <summary>
    /// Name of device manufacturer
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    /// <summary>
    /// Date when the device was made
    /// </summary>
    [JsonPropertyName("manufactureDate")]
    public DateTime? ManufactureDate { get; set; }

    /// <summary>
    /// Date and time of expiry of this device
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Lot number of manufacture
    /// </summary>
    [JsonPropertyName("lotNumber")]
    public string? LotNumber { get; set; }

    /// <summary>
    /// Serial number assigned by the manufacturer
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The name used to display the device
    /// </summary>
    [JsonPropertyName("deviceName")]
    public SimpleBackboneElement? DeviceName { get; set; }

    /// <summary>
    /// The model number for the device
    /// </summary>
    [JsonPropertyName("modelNumber")]
    public string? ModelNumber { get; set; }

    /// <summary>
    /// The part number of the device
    /// </summary>
    [JsonPropertyName("partNumber")]
    public string? PartNumber { get; set; }

    /// <summary>
    /// The kind or type of device
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// The capabilities supported on a device
    /// </summary>
    [JsonPropertyName("specialization")]
    public SimpleBackboneElement? Specialization { get; set; }

    /// <summary>
    /// The actual design of the device or software version running on the device
    /// </summary>
    [JsonPropertyName("version")]
    public SimpleBackboneElement? Version { get; set; }

    /// <summary>
    /// The actual configuration settings of a device
    /// </summary>
    [JsonPropertyName("property")]
    public SimpleBackboneElement? Property { get; set; }

    /// <summary>
    /// Patient to whom Device is affixed
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Organization responsible for device
    /// </summary>
    [JsonPropertyName("owner")]
    public SimpleReference? Owner { get; set; }

    /// <summary>
    /// Details for human/organization for support
    /// </summary>
    [JsonPropertyName("contact")]
    public SimpleContactPoint? Contact { get; set; }

    /// <summary>
    /// Where the device is located
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleReference? Location { get; set; }

    /// <summary>
    /// Network address for communication
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Device notes and comments
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Safety Characteristics of Device
    /// </summary>
    [JsonPropertyName("safety")]
    public SimpleCodeableConcept? Safety { get; set; }

    /// <summary>
    /// The parent device
    /// </summary>
    [JsonPropertyName("parent")]
    public SimpleReference? Parent { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Device";

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 自訂驗證邏輯
        // 子類別可以覆寫此方法來添加特定的驗證邏輯
    }
}
