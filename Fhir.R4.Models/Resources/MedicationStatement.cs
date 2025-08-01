// <auto-generated />
// FHIR R4 Resource: MedicationStatement
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A record of a medication that is being consumed by a patient.   A MedicationStatement may indicate that the patient may be taking the medication now or has taken the medication in the past or will be taking the medication in the future.  The source of this information can be the patient, significant other (such as a family member or spouse), or a clinician.  A common scenario where this information is captured is during the history taking process during a patient visit or stay.   The medication information may come from sources such as the patient's memory, from a prescription bottle,  or from a list of medications the patient, clinician or other party maintains. 

The primary difference between a medication statement and a medication administration is that the medication administration has complete administration information and is based on actual administration information from the person who administered the medication.  A medication statement is often, if not always, less specific.  There is no required date/time when the medication was administered, in fact we only know that a source has reported the patient is taking this medication, where details such as time, quantity, or rate or even medication product may be incomplete or missing or less precise.  As stated earlier, the medication statement information may come from the patient's memory, from a prescription bottle or from a list of medications the patient, clinician or other party maintains.  Medication administration is more formal and is not missing detailed information.
/// </summary>
public class MedicationStatement : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "MedicationStatement";

    /// <summary>
    /// External identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Fulfils plan, proposal or order
    /// </summary>
    [JsonPropertyName("basedOn")]
    public List<Reference>? BasedOn { get; set; }

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [JsonPropertyName("partOf")]
    public List<Reference>? PartOf { get; set; }

    /// <summary>
    /// active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken
    /// </summary>
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [JsonPropertyName("statusReason")]
    public List<CodeableConcept>? StatusReason { get; set; }

    /// <summary>
    /// Type of medication usage
    /// </summary>
    [JsonPropertyName("category")]
    public CodeableConcept Category { get; set; }

    /// <summary>
    /// Who is/was taking  the medication
    /// </summary>
    [Required]
    [JsonPropertyName("subject")]
    public Reference Subject { get; set; }

    /// <summary>
    /// Encounter / Episode associated with MedicationStatement
    /// </summary>
    [JsonPropertyName("context")]
    public Reference Context { get; set; }

    /// <summary>
    /// When the statement was asserted?
    /// </summary>
    [JsonPropertyName("dateAsserted")]
    public FhirDateTime DateAsserted { get; set; }

    /// <summary>
    /// Person or organization that provided the information about the taking of this medication
    /// </summary>
    [JsonPropertyName("informationSource")]
    public Reference InformationSource { get; set; }

    /// <summary>
    /// Additional supporting information
    /// </summary>
    [JsonPropertyName("derivedFrom")]
    public List<Reference>? DerivedFrom { get; set; }

    /// <summary>
    /// Reason for why the medication is being/was taken
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public List<CodeableConcept>? ReasonCode { get; set; }

    /// <summary>
    /// Condition or observation that supports why the medication is being/was taken
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public List<Reference>? ReasonReference { get; set; }

    /// <summary>
    /// Further information about the statement
    /// </summary>
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Details of how medication is/was taken or should be taken
    /// </summary>
    [JsonPropertyName("dosage")]
    public List<Dosage>? DosageValue { get; set; }

    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // TODO: Add specific validation rules
    }

}
