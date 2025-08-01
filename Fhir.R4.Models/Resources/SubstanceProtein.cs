// <auto-generated />
// FHIR R4 Resource: SubstanceProtein
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A SubstanceProtein is defined as a single unit of a linear amino acid sequence, or a combination of subunits that are either covalently linked or have a defined invariant stoichiometric relationship. This includes all synthetic, recombinant and purified SubstanceProteins of defined sequence, whether the use is therapeutic or prophylactic. This set of elements will be used to describe albumins, coagulation factors, cytokines, growth factors, peptide/SubstanceProtein hormones, enzymes, toxins, toxoids, recombinant vaccines, and immunomodulators.
/// </summary>
public class SubstanceProtein : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "SubstanceProtein";

    /// <summary>
    /// The SubstanceProtein descriptive elements will only be used when a complete or partial amino acid sequence is available or derivable from a nucleic acid sequence
    /// </summary>
    [JsonPropertyName("sequenceType")]
    public CodeableConcept SequenceType { get; set; }

    /// <summary>
    /// Number of linear sequences of amino acids linked through peptide bonds. The number of subunits constituting the SubstanceProtein shall be described. It is possible that the number of subunits can be variable
    /// </summary>
    [JsonPropertyName("numberOfSubunits")]
    public FhirInteger NumberOfSubunits { get; set; }

    /// <summary>
    /// The disulphide bond between two cysteine residues either on the same subunit or on two different subunits shall be described. The position of the disulfide bonds in the SubstanceProtein shall be listed in increasing order of subunit number and position within subunit followed by the abbreviation of the amino acids involved. The disulfide linkage positions shall actually contain the amino acid Cysteine at the respective positions
    /// </summary>
    [JsonPropertyName("disulfideLinkage")]
    public List<FhirString>? DisulfideLinkage { get; set; }

    /// <summary>
    /// This subclause refers to the description of each subunit constituting the SubstanceProtein. A subunit is a linear sequence of amino acids linked through peptide bonds. The Subunit information shall be provided when the finished SubstanceProtein is a complex of multiple sequences; subunits are not used to delineate domains within a single sequence. Subunits are listed in order of decreasing length; sequences of the same length will be ordered by decreasing molecular weight; subunits that have identical sequences will be repeated multiple times
    /// </summary>
    [JsonPropertyName("subunit")]
    public List<BackboneElement>? Subunit { get; set; }

    /// <summary>
    /// Index of primary sequences of amino acids linked through peptide bonds in order of decreasing length. Sequences of the same length will be ordered by molecular weight. Subunits that have identical sequences will be repeated and have sequential subscripts
    /// </summary>
    [JsonPropertyName("subunit")]
    public FhirInteger Subunit { get; set; }

    /// <summary>
    /// The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence
    /// </summary>
    [JsonPropertyName("sequence")]
    public FhirString Sequence { get; set; }

    /// <summary>
    /// Length of linear sequences of amino acids contained in the subunit
    /// </summary>
    [JsonPropertyName("length")]
    public FhirInteger Length { get; set; }

    /// <summary>
    /// The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence
    /// </summary>
    [JsonPropertyName("sequenceAttachment")]
    public Attachment SequenceAttachment { get; set; }

    /// <summary>
    /// Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID
    /// </summary>
    [JsonPropertyName("nTerminalModificationId")]
    public Identifier NTerminalModificationId { get; set; }

    /// <summary>
    /// The name of the fragment modified at the N-terminal of the SubstanceProtein shall be specified
    /// </summary>
    [JsonPropertyName("nTerminalModification")]
    public FhirString NTerminalModification { get; set; }

    /// <summary>
    /// Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID
    /// </summary>
    [JsonPropertyName("cTerminalModificationId")]
    public Identifier CTerminalModificationId { get; set; }

    /// <summary>
    /// The modification at the C-terminal shall be specified
    /// </summary>
    [JsonPropertyName("cTerminalModification")]
    public FhirString CTerminalModification { get; set; }

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
