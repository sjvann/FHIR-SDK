using System.ComponentModel.DataAnnotations;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Abstractions;

/// <summary>
/// Interface for FHIR Canonical Resources
/// 規範資源介面，定義具有規範性質的 FHIR 資源
/// </summary>
/// <remarks>
/// FHIR R5 CanonicalResource Interface
/// Canonical resources are those that have a canonical URL and can be referenced by other resources.
/// They include resources like StructureDefinition, ValueSet, CodeSystem, etc.
/// </remarks>
public interface ICanonicalResource : IDomainResource
{
    /// <summary>
    /// Canonical identifier for this resource, represented as a URI
    /// FHIR Path: CanonicalResource.url
    /// Cardinality: 0..1
    /// Type: uri
    /// </summary>
    FhirUri? Url { get; set; }

    /// <summary>
    /// Additional identifier for the resource
    /// FHIR Path: CanonicalResource.identifier
    /// Cardinality: 0..*
    /// Type: Identifier[]
    /// </summary>
    IList<Identifier>? Identifier { get; set; }

    /// <summary>
    /// Business version of the resource
    /// FHIR Path: CanonicalResource.version
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    FhirString? Version { get; set; }

    /// <summary>
    /// How to compare versions
    /// FHIR Path: CanonicalResource.versionAlgorithm[x]
    /// Cardinality: 0..1
    /// Type: string|Coding
    /// </summary>
    object? VersionAlgorithm { get; set; }

    /// <summary>
    /// Name for this resource (computer friendly)
    /// FHIR Path: CanonicalResource.name
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    FhirString? Name { get; set; }

    /// <summary>
    /// Name for this resource (human friendly)
    /// FHIR Path: CanonicalResource.title
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    FhirString? Title { get; set; }

    /// <summary>
    /// draft | active | retired | unknown
    /// FHIR Path: CanonicalResource.status
    /// Cardinality: 1..1
    /// Type: code
    /// </summary>
    FhirCode Status { get; set; }

    /// <summary>
    /// For testing purposes, not real usage
    /// FHIR Path: CanonicalResource.experimental
    /// Cardinality: 0..1
    /// Type: boolean
    /// </summary>
    FhirBoolean? Experimental { get; set; }

    /// <summary>
    /// Date last changed
    /// FHIR Path: CanonicalResource.date
    /// Cardinality: 0..1
    /// Type: dateTime
    /// </summary>
    FhirDateTime? Date { get; set; }

    /// <summary>
    /// Name of the publisher (organization or individual)
    /// FHIR Path: CanonicalResource.publisher
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    FhirString? Publisher { get; set; }

    /// <summary>
    /// Contact details for the publisher
    /// FHIR Path: CanonicalResource.contact
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    IList<ContactDetail>? Contact { get; set; }

    /// <summary>
    /// Natural language description of the resource
    /// FHIR Path: CanonicalResource.description
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    FhirMarkdown? Description { get; set; }

    /// <summary>
    /// The context that the content is intended to support
    /// FHIR Path: CanonicalResource.useContext
    /// Cardinality: 0..*
    /// Type: UsageContext[]
    /// </summary>
    IList<UsageContext>? UseContext { get; set; }

    /// <summary>
    /// Intended jurisdiction for resource (if applicable)
    /// FHIR Path: CanonicalResource.jurisdiction
    /// Cardinality: 0..*
    /// Type: CodeableConcept[]
    /// </summary>
    IList<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// Why this resource is defined
    /// FHIR Path: CanonicalResource.purpose
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    FhirMarkdown? Purpose { get; set; }

    /// <summary>
    /// Use and/or publishing restrictions
    /// FHIR Path: CanonicalResource.copyright
    /// Cardinality: 0..1
    /// Type: markdown
    /// </summary>
    FhirMarkdown? Copyright { get; set; }

    /// <summary>
    /// Copyright holder and year(s)
    /// FHIR Path: CanonicalResource.copyrightLabel
    /// Cardinality: 0..1
    /// Type: string
    /// </summary>
    FhirString? CopyrightLabel { get; set; }
} 