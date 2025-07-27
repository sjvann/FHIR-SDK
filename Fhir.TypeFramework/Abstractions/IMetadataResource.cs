using System.ComponentModel.DataAnnotations;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Abstractions;

/// <summary>
/// Interface for FHIR Metadata Resources
/// 元資料資源介面，定義具有元資料性質的 FHIR 資源
/// </summary>
/// <remarks>
/// FHIR R5 MetadataResource Interface
/// Metadata resources are those that contain metadata about other resources or the system.
/// They include resources like StructureDefinition, ValueSet, CodeSystem, etc.
/// </remarks>
public interface IMetadataResource : IDomainResource
{
    /// <summary>
    /// When the resource was approved by publisher
    /// FHIR Path: MetadataResource.approvalDate
    /// Cardinality: 0..1
    /// Type: date
    /// </summary>
    FhirDate? ApprovalDate { get; set; }

    /// <summary>
    /// When the resource was last reviewed
    /// FHIR Path: MetadataResource.lastReviewDate
    /// Cardinality: 0..1
    /// Type: date
    /// </summary>
    FhirDate? LastReviewDate { get; set; }

    /// <summary>
    /// When the resource is expected to be used
    /// FHIR Path: MetadataResource.effectivePeriod
    /// Cardinality: 0..1
    /// Type: Period
    /// </summary>
    Period? EffectivePeriod { get; set; }

    /// <summary>
    /// E.g. Education, Treatment, Assessment, etc.
    /// FHIR Path: MetadataResource.topic
    /// Cardinality: 0..*
    /// Type: CodeableConcept[]
    /// </summary>
    IList<CodeableConcept>? Topic { get; set; }

    /// <summary>
    /// Who authored the resource
    /// FHIR Path: MetadataResource.author
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    IList<ContactDetail>? Author { get; set; }

    /// <summary>
    /// Who edited the resource
    /// FHIR Path: MetadataResource.editor
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    IList<ContactDetail>? Editor { get; set; }

    /// <summary>
    /// Who reviewed the resource
    /// FHIR Path: MetadataResource.reviewer
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    IList<ContactDetail>? Reviewer { get; set; }

    /// <summary>
    /// Who endorsed the resource
    /// FHIR Path: MetadataResource.endorser
    /// Cardinality: 0..*
    /// Type: ContactDetail[]
    /// </summary>
    IList<ContactDetail>? Endorser { get; set; }

    /// <summary>
    /// Additional documentation, citations, etc.
    /// FHIR Path: MetadataResource.relatedArtifact
    /// Cardinality: 0..*
    /// Type: RelatedArtifact[]
    /// </summary>
    IList<RelatedArtifact>? RelatedArtifact { get; set; }
} 