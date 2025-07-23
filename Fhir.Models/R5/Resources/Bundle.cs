// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// A container for a collection of resources.
/// </summary>
public class Bundle : Resource
{
    public override string ResourceType => "Bundle";

    /// <summary>
    /// The logical id of the resource, as used in the URL for the resource. Once assigned, this value never
    /// changes.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// The metadata about the resource. This is content that is maintained by the infrastructure. Changes
    /// to the content might not always be associated with version changes to the resource.
    /// </summary>
    [FhirElement("meta", Order = 11)]
    [Cardinality(0, 1)]
    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    /// <summary>
    /// A reference to a set of rules that were followed when the resource was constructed, and which must
    /// be understood when processing the content. Often, this is a reference to an implementation guide
    /// that defines the special rules along with other profiles etc.
    /// </summary>
    [FhirElement("implicitRules", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("implicitRules")]
    public FhirUri? ImplicitRules { get; set; }

    /// <summary>
    /// The base language in which the resource is written.
    /// </summary>
    [FhirElement("language", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }

    /// <summary>
    /// A persistent identifier for the bundle that won&apos;t change as a bundle is copied from server to
    /// server.
    /// </summary>
    [FhirElement("identifier", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("identifier")]
    public Identifier Identifier { get; set; }

    /// <summary>
    /// Indicates the purpose of this bundle - how it is intended to be used.
    /// </summary>
    [FhirElement("type", Order = 15)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// The date/time that the bundle was assembled - i.e. when the resources were placed in the bundle.
    /// </summary>
    [FhirElement("timestamp", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("timestamp")]
    public FhirInstant? Timestamp { get; set; }

    /// <summary>
    /// If a set of search matches, this is the (potentially estimated) total number of entries of type
    /// &apos;match&apos; across all pages in the search. It does not include search.mode =
    /// &apos;include&apos; or &apos;outcome&apos; entries and it does not provide a count of the number of
    /// entries in the Bundle.
    /// </summary>
    [FhirElement("total", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("total")]
    public FhirUnsignedInt? Total { get; set; }

    /// <summary>
    /// A series of links that provide context to this bundle.
    /// </summary>
    [FhirElement("link", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("link")]
    public List<BackboneElement>? Link { get; set; }

    /// <summary>
    /// An entry in a bundle resource - will either contain a resource or information about a resource
    /// (transactions and history only).
    /// </summary>
    [FhirElement("entry", Order = 19)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("entry")]
    public List<BackboneElement>? Entry { get; set; }

    /// <summary>
    /// Digital Signature - base64 encoded. XML-DSig or a JWS.
    /// </summary>
    [FhirElement("signature", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("signature")]
    public Signature Signature { get; set; }

    /// <summary>
    /// Captures issues and warnings that relate to the construction of the Bundle and the content within
    /// it.
    /// </summary>
    [FhirElement("issues", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("issues")]
    public Resource Issues { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Bundle cardinality
        var bundleCount = Bundle?.Count ?? 0;
        if (bundleCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle' cardinality must be 0..*", new[] { nameof(Bundle) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'Bundle.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate Link cardinality
        var linkCount = Link?.Count ?? 0;
        if (linkCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.link' cardinality must be 0..*", new[] { nameof(Link) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.link.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.link.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Relation == null)
        {
            yield return new ValidationResult("Element 'Bundle.link.relation' cardinality must be 1..1", new[] { nameof(Relation) });
        }
        if (Url == null)
        {
            yield return new ValidationResult("Element 'Bundle.link.url' cardinality must be 1..1", new[] { nameof(Url) });
        }
        // Validate Entry cardinality
        var entryCount = Entry?.Count ?? 0;
        if (entryCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry' cardinality must be 0..*", new[] { nameof(Entry) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Link cardinality
        var linkCount = Link?.Count ?? 0;
        if (linkCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.link' cardinality must be 0..*", new[] { nameof(Link) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.search.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.search.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.request.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.request.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Method == null)
        {
            yield return new ValidationResult("Element 'Bundle.entry.request.method' cardinality must be 1..1", new[] { nameof(Method) });
        }
        if (Url == null)
        {
            yield return new ValidationResult("Element 'Bundle.entry.request.url' cardinality must be 1..1", new[] { nameof(Url) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.response.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Bundle.entry.response.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'Bundle.entry.response.status' cardinality must be 1..1", new[] { nameof(Status) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/bundle-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Relation ValueSet binding
        if (Relation != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/iana-link-relations|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Mode ValueSet binding
        if (Mode != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/search-entry-mode|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Method ValueSet binding
        if (Method != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/http-verb|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: bdl-1
        // Expression: total.empty() or (type = 'searchset') or (type = 'history')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("total.empty() or (type = 'searchset') or (type = 'history')"))
        // {
        //     yield return new ValidationResult("total only when a search or history", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-2
        // Expression: (type = 'searchset') or entry.search.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(type = 'searchset') or entry.search.empty()"))
        // {
        //     yield return new ValidationResult("entry.search only when a search", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-7
        // Expression: (type = 'history') or entry.where(fullUrl.exists()).select(fullUrl&iif(resource.meta.versionId.exists(), resource.meta.versionId, '')).isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(type = 'history') or entry.where(fullUrl.exists()).select(fullUrl&iif(resource.meta.versionId.exists(), resource.meta.versionId, '')).isDistinct()"))
        // {
        //     yield return new ValidationResult("FullUrl must be unique in a bundle, or else entries with the same fullUrl must have different meta.versionId (except in history bundles)", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-9
        // Expression: type = 'document' implies (identifier.system.exists() and identifier.value.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'document' implies (identifier.system.exists() and identifier.value.exists())"))
        // {
        //     yield return new ValidationResult("A document must have an identifier with a system and a value", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-10
        // Expression: type = 'document' implies (timestamp.hasValue())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'document' implies (timestamp.hasValue())"))
        // {
        //     yield return new ValidationResult("A document must have a date", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-11
        // Expression: type = 'document' implies entry.first().resource.is(Composition)
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'document' implies entry.first().resource.is(Composition)"))
        // {
        //     yield return new ValidationResult("A document must have a Composition as the first resource", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-12
        // Expression: type = 'message' implies entry.first().resource.is(MessageHeader)
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'message' implies entry.first().resource.is(MessageHeader)"))
        // {
        //     yield return new ValidationResult("A message must have a MessageHeader as the first resource", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-13
        // Expression: type = 'subscription-notification' implies entry.first().resource.is(SubscriptionStatus)
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'subscription-notification' implies entry.first().resource.is(SubscriptionStatus)"))
        // {
        //     yield return new ValidationResult("A subscription-notification must have a SubscriptionStatus as the first resource", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-14
        // Expression: type = 'history' implies entry.request.method != 'PATCH'
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'history' implies entry.request.method != 'PATCH'"))
        // {
        //     yield return new ValidationResult("entry.request.method PATCH not allowed for history", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-15
        // Expression: type='transaction' or type='transaction-response' or type='batch' or type='batch-response' or entry.all(fullUrl.exists() or request.method='POST')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type='transaction' or type='transaction-response' or type='batch' or type='batch-response' or entry.all(fullUrl.exists() or request.method='POST')"))
        // {
        //     yield return new ValidationResult("Bundle resources where type is not transaction, transaction-response, batch, or batch-response or when the request is a POST SHALL have Bundle.entry.fullUrl populated", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-16
        // Expression: issues.exists() implies (issues.issue.severity = 'information' or issues.issue.severity = 'warning')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("issues.exists() implies (issues.issue.severity = 'information' or issues.issue.severity = 'warning')"))
        // {
        //     yield return new ValidationResult("Issue.severity for all issues within the OperationOutcome must be either 'information' or 'warning'.", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-17
        // Expression: type = 'document' implies issues.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'document' implies issues.empty()"))
        // {
        //     yield return new ValidationResult("Use and meaning of issues for documents has not been validated because the content will not be rendered in the document.", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-18
        // Expression: type = 'searchset' implies link.where(relation = 'self' and url.exists()).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'searchset' implies link.where(relation = 'self' and url.exists()).exists()"))
        // {
        //     yield return new ValidationResult("Self link is required for searchsets.", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-3a
        // Expression: type in ('document' | 'message' | 'searchset' | 'collection') implies entry.all(resource.exists() and request.empty() and response.empty())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type in ('document' | 'message' | 'searchset' | 'collection') implies entry.all(resource.exists() and request.empty() and response.empty())"))
        // {
        //     yield return new ValidationResult("For collections of type document, message, searchset or collection, all entries must contain resources, and not have request or response elements", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-3b
        // Expression: type = 'history' implies entry.all(request.exists() and response.exists() and ((request.method in ('POST' | 'PATCH' | 'PUT')) = resource.exists()))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type = 'history' implies entry.all(request.exists() and response.exists() and ((request.method in ('POST' | 'PATCH' | 'PUT')) = resource.exists()))"))
        // {
        //     yield return new ValidationResult("For collections of type history, all entries must contain request or response elements, and resources if the method is POST, PUT or PATCH", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-3c
        // Expression: type in ('transaction' | 'batch') implies entry.all(request.method.exists() and ((request.method in ('POST' | 'PATCH' | 'PUT')) = resource.exists()))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type in ('transaction' | 'batch') implies entry.all(request.method.exists() and ((request.method in ('POST' | 'PATCH' | 'PUT')) = resource.exists()))"))
        // {
        //     yield return new ValidationResult("For collections of type transaction or batch, all entries must contain request elements, and resources if the method is POST, PUT or PATCH", new[] { nameof(Bundle) });
        // }
        // Constraint: bdl-3d
        // Expression: type in ('transaction-response' | 'batch-response') implies entry.all(response.exists())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type in ('transaction-response' | 'batch-response') implies entry.all(response.exists())"))
        // {
        //     yield return new ValidationResult("For collections of type transaction-response or batch-response, all entries must contain response elements", new[] { nameof(Bundle) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Meta) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ImplicitRules) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Language) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Identifier) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Timestamp) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Total) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Link) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Relation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Url) });
        // }
        // Constraint: bdl-5
        // Expression: resource.exists() or request.exists() or response.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("resource.exists() or request.exists() or response.exists()"))
        // {
        //     yield return new ValidationResult("must be a resource unless there's a request or response", new[] { nameof(Entry) });
        // }
        // Constraint: bdl-8
        // Expression: fullUrl.exists() implies fullUrl.contains('/_history/').not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("fullUrl.exists() implies fullUrl.contains('/_history/').not()"))
        // {
        //     yield return new ValidationResult("fullUrl cannot be a version specific reference", new[] { nameof(Entry) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Entry) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Link) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(FullUrl) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Search) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Mode) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Score) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Request) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Method) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Url) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IfNoneMatch) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IfModifiedSince) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IfMatch) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IfNoneExist) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Response) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Location) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Etag) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(LastModified) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Signature) });
        // }
    }

}
