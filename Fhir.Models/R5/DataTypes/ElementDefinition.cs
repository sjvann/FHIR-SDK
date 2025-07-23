// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// ElementDefinition Type: Captures constraints on each element within the resource, profile, or
/// extension.
/// </summary>
public class ElementDefinition : Element
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value
    /// that does not contain spaces.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 11)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element and that modifies the understanding of the element in which it is contained and/or the
    /// understanding of the containing element&apos;s descendants. Usually modifier elements provide
    /// negation or qualification. To make the use of extensions safe and managable, there is a strict set
    /// of governance applied to the definition and use of extensions. Though any implementer can define an
    /// extension, there is a set of requirements that SHALL be met as part of the definition of the
    /// extension. Applications processing a resource are required to check for modifier extensions.
    /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource
    /// (including cannot change the meaning of modifierExtension itself).
    /// </summary>
    [FhirElement("modifierExtension", Order = 12)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }

    /// <summary>
    /// The path identifies the element and is expressed as a &quot;.&quot;-separated list of ancestor
    /// elements, beginning with the name of the resource or extension.
    /// </summary>
    [FhirElement("path", Order = 13)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("path")]
    public FhirString Path { get; set; }

    /// <summary>
    /// Codes that define how this element is represented in instances, when the deviation varies from the
    /// normal case. No extensions are allowed on elements with a representation of &apos;xmlAttr&apos;, no
    /// matter what FHIR serialization format is used.
    /// </summary>
    [FhirElement("representation", Order = 14)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("representation")]
    public List<FhirCode>? Representation { get; set; }

    /// <summary>
    /// The name of this element definition slice, when slicing is working. The name must be a token with no
    /// dots or spaces. This is a unique name referring to a specific set of constraints applied to this
    /// element, used to provide a name to different slices of the same element.
    /// </summary>
    [FhirElement("sliceName", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName("sliceName")]
    public FhirString? SliceName { get; set; }

    /// <summary>
    /// If true, indicates that this slice definition is constraining a slice definition with the same name
    /// in an inherited profile. If false, the slice is not overriding any slice in an inherited profile. If
    /// missing, the slice might or might not be overriding a slice in an inherited profile, depending on
    /// the sliceName.
    /// </summary>
    [FhirElement("sliceIsConstraining", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("sliceIsConstraining")]
    public FhirBoolean? SliceIsConstraining { get; set; }

    /// <summary>
    /// A single preferred label which is the text to display beside the element indicating its meaning or
    /// to use to prompt for the element in a user display or form.
    /// </summary>
    [FhirElement("label", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("label")]
    public FhirString? Label { get; set; }

    /// <summary>
    /// A code that has the same meaning as the element in a particular terminology.
    /// </summary>
    [FhirElement("code", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("code")]
    public List<Coding>? Code { get; set; }

    /// <summary>
    /// Indicates that the element is sliced into a set of alternative definitions (i.e. in a structure
    /// definition, there are multiple different constraints on a single element in the base resource).
    /// Slicing can be used in any resource that has cardinality ..* on the base resource, or any resource
    /// with a choice of types. The set of slices is any elements that come after this in the element
    /// sequence that have the same path, until a shorter path occurs (the shorter path terminates the set).
    /// </summary>
    [FhirElement("slicing", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("slicing")]
    public Element Slicing { get; set; }

    /// <summary>
    /// A concise description of what this element means (e.g. for use in autogenerated summaries).
    /// </summary>
    [FhirElement("short", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("short")]
    public FhirString? Short { get; set; }

    /// <summary>
    /// Provides a complete explanation of the meaning of the data element for human readability. For the
    /// case of elements derived from existing elements (e.g. constraints), the definition SHALL be
    /// consistent with the base definition, but convey the meaning of the element in the particular context
    /// of use of the resource. (Note: The text you are reading is specified in
    /// ElementDefinition.definition).
    /// </summary>
    [FhirElement("definition", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("definition")]
    public FhirMarkdown? Definition { get; set; }

    /// <summary>
    /// Explanatory notes and implementation guidance about the data element, including notes about how to
    /// use the data properly, exceptions to proper use, etc. (Note: The text you are reading is specified
    /// in ElementDefinition.comment).
    /// </summary>
    [FhirElement("comment", Order = 22)]
    [Cardinality(0, 1)]
    [JsonPropertyName("comment")]
    public FhirMarkdown? Comment { get; set; }

    /// <summary>
    /// This element is for traceability of why the element was created and why the constraints exist as
    /// they do. This may be used to point to source materials or specifications that drove the structure of
    /// this element.
    /// </summary>
    [FhirElement("requirements", Order = 23)]
    [Cardinality(0, 1)]
    [JsonPropertyName("requirements")]
    public FhirMarkdown? Requirements { get; set; }

    /// <summary>
    /// Identifies additional names by which this element might also be known.
    /// </summary>
    [FhirElement("alias", Order = 24)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("alias")]
    public List<FhirString>? Alias { get; set; }

    /// <summary>
    /// The minimum number of times this element SHALL appear in the instance.
    /// </summary>
    [FhirElement("min", Order = 25)]
    [Cardinality(0, 1)]
    [JsonPropertyName("min")]
    public FhirUnsignedInt? Min { get; set; }

    /// <summary>
    /// The maximum number of times this element is permitted to appear in the instance.
    /// </summary>
    [FhirElement("max", Order = 26)]
    [Cardinality(0, 1)]
    [JsonPropertyName("max")]
    public FhirString? Max { get; set; }

    /// <summary>
    /// Information about the base definition of the element, provided to make it unnecessary for tools to
    /// trace the deviation of the element through the derived and related profiles. When the element
    /// definition is not the original definition of an element - e.g. either in a constraint on another
    /// type, or for elements from a super type in a snap shot - then the information in provided in the
    /// element definition may be different to the base definition. On the original definition of the
    /// element, it will be same.
    /// </summary>
    [FhirElement("base", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("base")]
    public Element Base { get; set; }

    /// <summary>
    /// Identifies an element defined elsewhere in the definition whose content rules should be applied to
    /// the current element. ContentReferences bring across all the rules that are in the ElementDefinition
    /// for the element, including definitions, cardinality constraints, bindings, invariants etc.
    /// </summary>
    [FhirElement("contentReference", Order = 28)]
    [Cardinality(0, 1)]
    [JsonPropertyName("contentReference")]
    public FhirUri? ContentReference { get; set; }

    /// <summary>
    /// The data type or resource that the value of this element is permitted to be.
    /// </summary>
    [FhirElement("type", Order = 29)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("type")]
    public List<Element>? Type { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as base64Binary)
    /// </summary>
    [FhirElement("defaultvaluebase64binaryUnknown", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluebase64binary", "unknown")]
    [JsonPropertyName("defaultvaluebase64binaryUnknown")]
    public FhirBase64Binary? DefaultValueBase64Binary { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as boolean)
    /// </summary>
    [FhirElement("defaultValueBoolean", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "boolean")]
    [JsonPropertyName("defaultValueBoolean")]
    public FhirBoolean? DefaultValueBoolean { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as canonical)
    /// </summary>
    [FhirElement("defaultvaluecanonicalUnknown", Order = 32)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluecanonical", "unknown")]
    [JsonPropertyName("defaultvaluecanonicalUnknown")]
    public FhirCanonical? DefaultValueCanonical { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as code)
    /// </summary>
    [FhirElement("defaultValueCode", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "code")]
    [JsonPropertyName("defaultValueCode")]
    public FhirCode? DefaultValueCode { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as date)
    /// </summary>
    [FhirElement("defaultvaluedateUnknown", Order = 34)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluedate", "unknown")]
    [JsonPropertyName("defaultvaluedateUnknown")]
    public FhirDate? DefaultValueDate { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as dateTime)
    /// </summary>
    [FhirElement("defaultValueDateTime", Order = 35)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "dateTime")]
    [JsonPropertyName("defaultValueDateTime")]
    public FhirDateTime? DefaultValueDateTime { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as decimal)
    /// </summary>
    [FhirElement("defaultValueDecimal", Order = 36)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "decimal")]
    [JsonPropertyName("defaultValueDecimal")]
    public FhirDecimal? DefaultValueDecimal { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as id)
    /// </summary>
    [FhirElement("defaultvalueidUnknown", Order = 37)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueid", "unknown")]
    [JsonPropertyName("defaultvalueidUnknown")]
    public FhirId? DefaultValueId { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as instant)
    /// </summary>
    [FhirElement("defaultvalueinstantUnknown", Order = 38)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueinstant", "unknown")]
    [JsonPropertyName("defaultvalueinstantUnknown")]
    public FhirInstant? DefaultValueInstant { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as integer)
    /// </summary>
    [FhirElement("defaultValueInteger", Order = 39)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "integer")]
    [JsonPropertyName("defaultValueInteger")]
    public FhirInteger? DefaultValueInteger { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as integer64)
    /// </summary>
    [FhirElement("defaultvalueinteger64Unknown", Order = 40)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueinteger64", "unknown")]
    [JsonPropertyName("defaultvalueinteger64Unknown")]
    public FhirInteger64? DefaultValueInteger64 { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as markdown)
    /// </summary>
    [FhirElement("defaultvaluemarkdownUnknown", Order = 41)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluemarkdown", "unknown")]
    [JsonPropertyName("defaultvaluemarkdownUnknown")]
    public FhirMarkdown? DefaultValueMarkdown { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as oid)
    /// </summary>
    [FhirElement("defaultvalueoidUnknown", Order = 42)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueoid", "unknown")]
    [JsonPropertyName("defaultvalueoidUnknown")]
    public FhirOid? DefaultValueOid { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as positiveInt)
    /// </summary>
    [FhirElement("defaultvaluepositiveintUnknown", Order = 43)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluepositiveint", "unknown")]
    [JsonPropertyName("defaultvaluepositiveintUnknown")]
    public FhirPositiveInt? DefaultValuePositiveInt { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as string)
    /// </summary>
    [FhirElement("defaultValueString", Order = 44)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "string")]
    [JsonPropertyName("defaultValueString")]
    public FhirString? DefaultValueString { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as time)
    /// </summary>
    [FhirElement("defaultvaluetimeUnknown", Order = 45)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluetime", "unknown")]
    [JsonPropertyName("defaultvaluetimeUnknown")]
    public FhirTime? DefaultValueTime { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as unsignedInt)
    /// </summary>
    [FhirElement("defaultvalueunsignedintUnknown", Order = 46)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueunsignedint", "unknown")]
    [JsonPropertyName("defaultvalueunsignedintUnknown")]
    public FhirUnsignedInt? DefaultValueUnsignedInt { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as uri)
    /// </summary>
    [FhirElement("defaultValueUri", Order = 47)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "uri")]
    [JsonPropertyName("defaultValueUri")]
    public FhirUri? DefaultValueUri { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as url)
    /// </summary>
    [FhirElement("defaultvalueurlUnknown", Order = 48)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueurl", "unknown")]
    [JsonPropertyName("defaultvalueurlUnknown")]
    public FhirUrl? DefaultValueUrl { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as uuid)
    /// </summary>
    [FhirElement("defaultvalueuuidUnknown", Order = 49)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueuuid", "unknown")]
    [JsonPropertyName("defaultvalueuuidUnknown")]
    public FhirUuid? DefaultValueUuid { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Address)
    /// </summary>
    [FhirElement("defaultValueAddress", Order = 50)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "address")]
    [JsonPropertyName("defaultValueAddress")]
    public Address DefaultValueAddress { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Age)
    /// </summary>
    [FhirElement("defaultvalueageUnknown", Order = 51)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueage", "unknown")]
    [JsonPropertyName("defaultvalueageUnknown")]
    public Age DefaultValueAge { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Annotation)
    /// </summary>
    [FhirElement("defaultValueAnnotation", Order = 52)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "annotation")]
    [JsonPropertyName("defaultValueAnnotation")]
    public Annotation DefaultValueAnnotation { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Attachment)
    /// </summary>
    [FhirElement("defaultValueAttachment", Order = 53)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "attachment")]
    [JsonPropertyName("defaultValueAttachment")]
    public Attachment DefaultValueAttachment { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as CodeableConcept)
    /// </summary>
    [FhirElement("defaultValueCodeableConcept", Order = 54)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "codeableConcept")]
    [JsonPropertyName("defaultValueCodeableConcept")]
    public CodeableConcept DefaultValueCodeableConcept { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as CodeableReference)
    /// </summary>
    [FhirElement("defaultValueCodeableReference", Order = 55)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValueCodeable", "reference")]
    [JsonPropertyName("defaultValueCodeableReference")]
    public CodeableReference DefaultValueCodeableReference { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Coding)
    /// </summary>
    [FhirElement("defaultValueCoding", Order = 56)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "coding")]
    [JsonPropertyName("defaultValueCoding")]
    public Coding DefaultValueCoding { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as ContactPoint)
    /// </summary>
    [FhirElement("defaultValueContactPoint", Order = 57)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "contactPoint")]
    [JsonPropertyName("defaultValueContactPoint")]
    public ContactPoint DefaultValueContactPoint { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Count)
    /// </summary>
    [FhirElement("defaultvaluecountUnknown", Order = 58)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluecount", "unknown")]
    [JsonPropertyName("defaultvaluecountUnknown")]
    public Count DefaultValueCount { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Distance)
    /// </summary>
    [FhirElement("defaultvaluedistanceUnknown", Order = 59)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluedistance", "unknown")]
    [JsonPropertyName("defaultvaluedistanceUnknown")]
    public Distance DefaultValueDistance { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Duration)
    /// </summary>
    [FhirElement("defaultvaluedurationUnknown", Order = 60)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueduration", "unknown")]
    [JsonPropertyName("defaultvaluedurationUnknown")]
    public Duration DefaultValueDuration { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as HumanName)
    /// </summary>
    [FhirElement("defaultValueHumanName", Order = 61)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "humanName")]
    [JsonPropertyName("defaultValueHumanName")]
    public HumanName DefaultValueHumanName { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Identifier)
    /// </summary>
    [FhirElement("defaultValueIdentifier", Order = 62)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "identifier")]
    [JsonPropertyName("defaultValueIdentifier")]
    public Identifier DefaultValueIdentifier { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Money)
    /// </summary>
    [FhirElement("defaultvaluemoneyUnknown", Order = 63)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluemoney", "unknown")]
    [JsonPropertyName("defaultvaluemoneyUnknown")]
    public Money DefaultValueMoney { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Period)
    /// </summary>
    [FhirElement("defaultValuePeriod", Order = 64)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "period")]
    [JsonPropertyName("defaultValuePeriod")]
    public Period DefaultValuePeriod { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Quantity)
    /// </summary>
    [FhirElement("defaultValueQuantity", Order = 65)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "quantity")]
    [JsonPropertyName("defaultValueQuantity")]
    public Quantity DefaultValueQuantity { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Range)
    /// </summary>
    [FhirElement("defaultValueRange", Order = 66)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "range")]
    [JsonPropertyName("defaultValueRange")]
    public Range DefaultValueRange { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Ratio)
    /// </summary>
    [FhirElement("defaultValueRatio", Order = 67)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "ratio")]
    [JsonPropertyName("defaultValueRatio")]
    public Ratio DefaultValueRatio { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as RatioRange)
    /// </summary>
    [FhirElement("defaultValueRatioRange", Order = 68)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValueRatio", "range")]
    [JsonPropertyName("defaultValueRatioRange")]
    public RatioRange DefaultValueRatioRange { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Reference)
    /// </summary>
    [FhirElement("defaultValueReference", Order = 69)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "reference")]
    [JsonPropertyName("defaultValueReference")]
    public Reference DefaultValueReference { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as SampledData)
    /// </summary>
    [FhirElement("defaultvaluesampleddataUnknown", Order = 70)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluesampleddata", "unknown")]
    [JsonPropertyName("defaultvaluesampleddataUnknown")]
    public SampledData DefaultValueSampledData { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Signature)
    /// </summary>
    [FhirElement("defaultValueSignature", Order = 71)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "signature")]
    [JsonPropertyName("defaultValueSignature")]
    public Signature DefaultValueSignature { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Timing)
    /// </summary>
    [FhirElement("defaultValueTiming", Order = 72)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultValue", "timing")]
    [JsonPropertyName("defaultValueTiming")]
    public Timing DefaultValueTiming { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as ContactDetail)
    /// </summary>
    [FhirElement("defaultvaluecontactdetailUnknown", Order = 73)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluecontactdetail", "unknown")]
    [JsonPropertyName("defaultvaluecontactdetailUnknown")]
    public ContactDetail DefaultValueContactDetail { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as DataRequirement)
    /// </summary>
    [FhirElement("defaultvaluedatarequirementUnknown", Order = 74)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluedatarequirement", "unknown")]
    [JsonPropertyName("defaultvaluedatarequirementUnknown")]
    public DataRequirement DefaultValueDataRequirement { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Expression)
    /// </summary>
    [FhirElement("defaultvalueexpressionUnknown", Order = 75)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueexpression", "unknown")]
    [JsonPropertyName("defaultvalueexpressionUnknown")]
    public Expression DefaultValueExpression { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as ParameterDefinition)
    /// </summary>
    [FhirElement("defaultvalueparameterdefinitionUnknown", Order = 76)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueparameterdefinition", "unknown")]
    [JsonPropertyName("defaultvalueparameterdefinitionUnknown")]
    public ParameterDefinition DefaultValueParameterDefinition { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as RelatedArtifact)
    /// </summary>
    [FhirElement("defaultvaluerelatedartifactUnknown", Order = 77)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluerelatedartifact", "unknown")]
    [JsonPropertyName("defaultvaluerelatedartifactUnknown")]
    public RelatedArtifact DefaultValueRelatedArtifact { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as TriggerDefinition)
    /// </summary>
    [FhirElement("defaultvaluetriggerdefinitionUnknown", Order = 78)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluetriggerdefinition", "unknown")]
    [JsonPropertyName("defaultvaluetriggerdefinitionUnknown")]
    public TriggerDefinition DefaultValueTriggerDefinition { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as UsageContext)
    /// </summary>
    [FhirElement("defaultvalueusagecontextUnknown", Order = 79)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueusagecontext", "unknown")]
    [JsonPropertyName("defaultvalueusagecontextUnknown")]
    public UsageContext DefaultValueUsageContext { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Availability)
    /// </summary>
    [FhirElement("defaultvalueavailabilityUnknown", Order = 80)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueavailability", "unknown")]
    [JsonPropertyName("defaultvalueavailabilityUnknown")]
    public Availability DefaultValueAvailability { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as ExtendedContactDetail)
    /// </summary>
    [FhirElement("defaultvalueextendedcontactdetailUnknown", Order = 81)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvalueextendedcontactdetail", "unknown")]
    [JsonPropertyName("defaultvalueextendedcontactdetailUnknown")]
    public ExtendedContactDetail DefaultValueExtendedContactDetail { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Dosage)
    /// </summary>
    [FhirElement("defaultvaluedosageUnknown", Order = 82)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluedosage", "unknown")]
    [JsonPropertyName("defaultvaluedosageUnknown")]
    public Dosage DefaultValueDosage { get; set; }

    /// <summary>
    /// The value that should be used if there is no value stated in the instance (e.g. &apos;if not
    /// otherwise specified, the abstract is false&apos;). (as Meta)
    /// </summary>
    [FhirElement("defaultvaluemetaUnknown", Order = 83)]
    [Cardinality(0, 1)]
    [ChoiceType("defaultvaluemeta", "unknown")]
    [JsonPropertyName("defaultvaluemetaUnknown")]
    public Meta DefaultValueMeta { get; set; }

    /// <summary>
    /// The Implicit meaning that is to be understood when this element is missing (e.g. &apos;when this
    /// element is missing, the period is ongoing&apos;).
    /// </summary>
    [FhirElement("meaningWhenMissing", Order = 84)]
    [Cardinality(0, 1)]
    [JsonPropertyName("meaningWhenMissing")]
    public FhirMarkdown? MeaningWhenMissing { get; set; }

    /// <summary>
    /// If present, indicates that the order of the repeating element has meaning and describes what that
    /// meaning is. If absent, it means that the order of the element has no meaning.
    /// </summary>
    [FhirElement("orderMeaning", Order = 85)]
    [Cardinality(0, 1)]
    [JsonPropertyName("orderMeaning")]
    public FhirString? OrderMeaning { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as base64Binary)
    /// </summary>
    [FhirElement("fixedbase64binaryUnknown", Order = 86)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedbase64binary", "unknown")]
    [JsonPropertyName("fixedbase64binaryUnknown")]
    public FhirBase64Binary? FixedBase64Binary { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as boolean)
    /// </summary>
    [FhirElement("fixedBoolean", Order = 87)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "boolean")]
    [JsonPropertyName("fixedBoolean")]
    public FhirBoolean? FixedBoolean { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as canonical)
    /// </summary>
    [FhirElement("fixedcanonicalUnknown", Order = 88)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedcanonical", "unknown")]
    [JsonPropertyName("fixedcanonicalUnknown")]
    public FhirCanonical? FixedCanonical { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as code)
    /// </summary>
    [FhirElement("fixedCode", Order = 89)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "code")]
    [JsonPropertyName("fixedCode")]
    public FhirCode? FixedCode { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as date)
    /// </summary>
    [FhirElement("fixeddateUnknown", Order = 90)]
    [Cardinality(0, 1)]
    [ChoiceType("fixeddate", "unknown")]
    [JsonPropertyName("fixeddateUnknown")]
    public FhirDate? FixedDate { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as dateTime)
    /// </summary>
    [FhirElement("fixedDateTime", Order = 91)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "dateTime")]
    [JsonPropertyName("fixedDateTime")]
    public FhirDateTime? FixedDateTime { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as decimal)
    /// </summary>
    [FhirElement("fixedDecimal", Order = 92)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "decimal")]
    [JsonPropertyName("fixedDecimal")]
    public FhirDecimal? FixedDecimal { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as id)
    /// </summary>
    [FhirElement("fixedidUnknown", Order = 93)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedid", "unknown")]
    [JsonPropertyName("fixedidUnknown")]
    public FhirId? FixedId { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as instant)
    /// </summary>
    [FhirElement("fixedinstantUnknown", Order = 94)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedinstant", "unknown")]
    [JsonPropertyName("fixedinstantUnknown")]
    public FhirInstant? FixedInstant { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as integer)
    /// </summary>
    [FhirElement("fixedInteger", Order = 95)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "integer")]
    [JsonPropertyName("fixedInteger")]
    public FhirInteger? FixedInteger { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as integer64)
    /// </summary>
    [FhirElement("fixedinteger64Unknown", Order = 96)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedinteger64", "unknown")]
    [JsonPropertyName("fixedinteger64Unknown")]
    public FhirInteger64? FixedInteger64 { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as markdown)
    /// </summary>
    [FhirElement("fixedmarkdownUnknown", Order = 97)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedmarkdown", "unknown")]
    [JsonPropertyName("fixedmarkdownUnknown")]
    public FhirMarkdown? FixedMarkdown { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as oid)
    /// </summary>
    [FhirElement("fixedoidUnknown", Order = 98)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedoid", "unknown")]
    [JsonPropertyName("fixedoidUnknown")]
    public FhirOid? FixedOid { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as positiveInt)
    /// </summary>
    [FhirElement("fixedpositiveintUnknown", Order = 99)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedpositiveint", "unknown")]
    [JsonPropertyName("fixedpositiveintUnknown")]
    public FhirPositiveInt? FixedPositiveInt { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as string)
    /// </summary>
    [FhirElement("fixedString", Order = 100)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "string")]
    [JsonPropertyName("fixedString")]
    public FhirString? FixedString { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as time)
    /// </summary>
    [FhirElement("fixedtimeUnknown", Order = 101)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedtime", "unknown")]
    [JsonPropertyName("fixedtimeUnknown")]
    public FhirTime? FixedTime { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as unsignedInt)
    /// </summary>
    [FhirElement("fixedunsignedintUnknown", Order = 102)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedunsignedint", "unknown")]
    [JsonPropertyName("fixedunsignedintUnknown")]
    public FhirUnsignedInt? FixedUnsignedInt { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as uri)
    /// </summary>
    [FhirElement("fixedUri", Order = 103)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "uri")]
    [JsonPropertyName("fixedUri")]
    public FhirUri? FixedUri { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as url)
    /// </summary>
    [FhirElement("fixedurlUnknown", Order = 104)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedurl", "unknown")]
    [JsonPropertyName("fixedurlUnknown")]
    public FhirUrl? FixedUrl { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as uuid)
    /// </summary>
    [FhirElement("fixeduuidUnknown", Order = 105)]
    [Cardinality(0, 1)]
    [ChoiceType("fixeduuid", "unknown")]
    [JsonPropertyName("fixeduuidUnknown")]
    public FhirUuid? FixedUuid { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Address)
    /// </summary>
    [FhirElement("fixedAddress", Order = 106)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "address")]
    [JsonPropertyName("fixedAddress")]
    public Address FixedAddress { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Age)
    /// </summary>
    [FhirElement("fixedageUnknown", Order = 107)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedage", "unknown")]
    [JsonPropertyName("fixedageUnknown")]
    public Age FixedAge { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Annotation)
    /// </summary>
    [FhirElement("fixedAnnotation", Order = 108)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "annotation")]
    [JsonPropertyName("fixedAnnotation")]
    public Annotation FixedAnnotation { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Attachment)
    /// </summary>
    [FhirElement("fixedAttachment", Order = 109)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "attachment")]
    [JsonPropertyName("fixedAttachment")]
    public Attachment FixedAttachment { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as CodeableConcept)
    /// </summary>
    [FhirElement("fixedCodeableConcept", Order = 110)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "codeableConcept")]
    [JsonPropertyName("fixedCodeableConcept")]
    public CodeableConcept FixedCodeableConcept { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as
    /// CodeableReference)
    /// </summary>
    [FhirElement("fixedCodeableReference", Order = 111)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedCodeable", "reference")]
    [JsonPropertyName("fixedCodeableReference")]
    public CodeableReference FixedCodeableReference { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Coding)
    /// </summary>
    [FhirElement("fixedCoding", Order = 112)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "coding")]
    [JsonPropertyName("fixedCoding")]
    public Coding FixedCoding { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as ContactPoint)
    /// </summary>
    [FhirElement("fixedContactPoint", Order = 113)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "contactPoint")]
    [JsonPropertyName("fixedContactPoint")]
    public ContactPoint FixedContactPoint { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Count)
    /// </summary>
    [FhirElement("fixedcountUnknown", Order = 114)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedcount", "unknown")]
    [JsonPropertyName("fixedcountUnknown")]
    public Count FixedCount { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Distance)
    /// </summary>
    [FhirElement("fixeddistanceUnknown", Order = 115)]
    [Cardinality(0, 1)]
    [ChoiceType("fixeddistance", "unknown")]
    [JsonPropertyName("fixeddistanceUnknown")]
    public Distance FixedDistance { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Duration)
    /// </summary>
    [FhirElement("fixeddurationUnknown", Order = 116)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedduration", "unknown")]
    [JsonPropertyName("fixeddurationUnknown")]
    public Duration FixedDuration { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as HumanName)
    /// </summary>
    [FhirElement("fixedHumanName", Order = 117)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "humanName")]
    [JsonPropertyName("fixedHumanName")]
    public HumanName FixedHumanName { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Identifier)
    /// </summary>
    [FhirElement("fixedIdentifier", Order = 118)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "identifier")]
    [JsonPropertyName("fixedIdentifier")]
    public Identifier FixedIdentifier { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Money)
    /// </summary>
    [FhirElement("fixedmoneyUnknown", Order = 119)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedmoney", "unknown")]
    [JsonPropertyName("fixedmoneyUnknown")]
    public Money FixedMoney { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Period)
    /// </summary>
    [FhirElement("fixedPeriod", Order = 120)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "period")]
    [JsonPropertyName("fixedPeriod")]
    public Period FixedPeriod { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Quantity)
    /// </summary>
    [FhirElement("fixedQuantity", Order = 121)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "quantity")]
    [JsonPropertyName("fixedQuantity")]
    public Quantity FixedQuantity { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Range)
    /// </summary>
    [FhirElement("fixedRange", Order = 122)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "range")]
    [JsonPropertyName("fixedRange")]
    public Range FixedRange { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Ratio)
    /// </summary>
    [FhirElement("fixedRatio", Order = 123)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "ratio")]
    [JsonPropertyName("fixedRatio")]
    public Ratio FixedRatio { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as RatioRange)
    /// </summary>
    [FhirElement("fixedRatioRange", Order = 124)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedRatio", "range")]
    [JsonPropertyName("fixedRatioRange")]
    public RatioRange FixedRatioRange { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Reference)
    /// </summary>
    [FhirElement("fixedReference", Order = 125)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "reference")]
    [JsonPropertyName("fixedReference")]
    public Reference FixedReference { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as SampledData)
    /// </summary>
    [FhirElement("fixedsampleddataUnknown", Order = 126)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedsampleddata", "unknown")]
    [JsonPropertyName("fixedsampleddataUnknown")]
    public SampledData FixedSampledData { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Signature)
    /// </summary>
    [FhirElement("fixedSignature", Order = 127)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "signature")]
    [JsonPropertyName("fixedSignature")]
    public Signature FixedSignature { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Timing)
    /// </summary>
    [FhirElement("fixedTiming", Order = 128)]
    [Cardinality(0, 1)]
    [ChoiceType("fixed", "timing")]
    [JsonPropertyName("fixedTiming")]
    public Timing FixedTiming { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as ContactDetail)
    /// </summary>
    [FhirElement("fixedcontactdetailUnknown", Order = 129)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedcontactdetail", "unknown")]
    [JsonPropertyName("fixedcontactdetailUnknown")]
    public ContactDetail FixedContactDetail { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as DataRequirement)
    /// </summary>
    [FhirElement("fixeddatarequirementUnknown", Order = 130)]
    [Cardinality(0, 1)]
    [ChoiceType("fixeddatarequirement", "unknown")]
    [JsonPropertyName("fixeddatarequirementUnknown")]
    public DataRequirement FixedDataRequirement { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Expression)
    /// </summary>
    [FhirElement("fixedexpressionUnknown", Order = 131)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedexpression", "unknown")]
    [JsonPropertyName("fixedexpressionUnknown")]
    public Expression FixedExpression { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as
    /// ParameterDefinition)
    /// </summary>
    [FhirElement("fixedparameterdefinitionUnknown", Order = 132)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedparameterdefinition", "unknown")]
    [JsonPropertyName("fixedparameterdefinitionUnknown")]
    public ParameterDefinition FixedParameterDefinition { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as RelatedArtifact)
    /// </summary>
    [FhirElement("fixedrelatedartifactUnknown", Order = 133)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedrelatedartifact", "unknown")]
    [JsonPropertyName("fixedrelatedartifactUnknown")]
    public RelatedArtifact FixedRelatedArtifact { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as
    /// TriggerDefinition)
    /// </summary>
    [FhirElement("fixedtriggerdefinitionUnknown", Order = 134)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedtriggerdefinition", "unknown")]
    [JsonPropertyName("fixedtriggerdefinitionUnknown")]
    public TriggerDefinition FixedTriggerDefinition { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as UsageContext)
    /// </summary>
    [FhirElement("fixedusagecontextUnknown", Order = 135)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedusagecontext", "unknown")]
    [JsonPropertyName("fixedusagecontextUnknown")]
    public UsageContext FixedUsageContext { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Availability)
    /// </summary>
    [FhirElement("fixedavailabilityUnknown", Order = 136)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedavailability", "unknown")]
    [JsonPropertyName("fixedavailabilityUnknown")]
    public Availability FixedAvailability { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as
    /// ExtendedContactDetail)
    /// </summary>
    [FhirElement("fixedextendedcontactdetailUnknown", Order = 137)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedextendedcontactdetail", "unknown")]
    [JsonPropertyName("fixedextendedcontactdetailUnknown")]
    public ExtendedContactDetail FixedExtendedContactDetail { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Dosage)
    /// </summary>
    [FhirElement("fixeddosageUnknown", Order = 138)]
    [Cardinality(0, 1)]
    [ChoiceType("fixeddosage", "unknown")]
    [JsonPropertyName("fixeddosageUnknown")]
    public Dosage FixedDosage { get; set; }

    /// <summary>
    /// Specifies a value that SHALL be exactly the value for this element in the instance, if present. For
    /// purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match
    /// (case and accent sensitive). Missing elements/attributes must also be missing. (as Meta)
    /// </summary>
    [FhirElement("fixedmetaUnknown", Order = 139)]
    [Cardinality(0, 1)]
    [ChoiceType("fixedmeta", "unknown")]
    [JsonPropertyName("fixedmetaUnknown")]
    public Meta FixedMeta { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as base64Binary)
    /// </summary>
    [FhirElement("patternbase64binaryUnknown", Order = 140)]
    [Cardinality(0, 1)]
    [ChoiceType("patternbase64binary", "unknown")]
    [JsonPropertyName("patternbase64binaryUnknown")]
    public FhirBase64Binary? PatternBase64Binary { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as boolean)
    /// </summary>
    [FhirElement("patternBoolean", Order = 141)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "boolean")]
    [JsonPropertyName("patternBoolean")]
    public FhirBoolean? PatternBoolean { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as canonical)
    /// </summary>
    [FhirElement("patterncanonicalUnknown", Order = 142)]
    [Cardinality(0, 1)]
    [ChoiceType("patterncanonical", "unknown")]
    [JsonPropertyName("patterncanonicalUnknown")]
    public FhirCanonical? PatternCanonical { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as code)
    /// </summary>
    [FhirElement("patternCode", Order = 143)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "code")]
    [JsonPropertyName("patternCode")]
    public FhirCode? PatternCode { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as date)
    /// </summary>
    [FhirElement("patterndateUnknown", Order = 144)]
    [Cardinality(0, 1)]
    [ChoiceType("patterndate", "unknown")]
    [JsonPropertyName("patterndateUnknown")]
    public FhirDate? PatternDate { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as dateTime)
    /// </summary>
    [FhirElement("patternDateTime", Order = 145)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "dateTime")]
    [JsonPropertyName("patternDateTime")]
    public FhirDateTime? PatternDateTime { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as decimal)
    /// </summary>
    [FhirElement("patternDecimal", Order = 146)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "decimal")]
    [JsonPropertyName("patternDecimal")]
    public FhirDecimal? PatternDecimal { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as id)
    /// </summary>
    [FhirElement("patternidUnknown", Order = 147)]
    [Cardinality(0, 1)]
    [ChoiceType("patternid", "unknown")]
    [JsonPropertyName("patternidUnknown")]
    public FhirId? PatternId { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as instant)
    /// </summary>
    [FhirElement("patterninstantUnknown", Order = 148)]
    [Cardinality(0, 1)]
    [ChoiceType("patterninstant", "unknown")]
    [JsonPropertyName("patterninstantUnknown")]
    public FhirInstant? PatternInstant { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as integer)
    /// </summary>
    [FhirElement("patternInteger", Order = 149)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "integer")]
    [JsonPropertyName("patternInteger")]
    public FhirInteger? PatternInteger { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as integer64)
    /// </summary>
    [FhirElement("patterninteger64Unknown", Order = 150)]
    [Cardinality(0, 1)]
    [ChoiceType("patterninteger64", "unknown")]
    [JsonPropertyName("patterninteger64Unknown")]
    public FhirInteger64? PatternInteger64 { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as markdown)
    /// </summary>
    [FhirElement("patternmarkdownUnknown", Order = 151)]
    [Cardinality(0, 1)]
    [ChoiceType("patternmarkdown", "unknown")]
    [JsonPropertyName("patternmarkdownUnknown")]
    public FhirMarkdown? PatternMarkdown { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as oid)
    /// </summary>
    [FhirElement("patternoidUnknown", Order = 152)]
    [Cardinality(0, 1)]
    [ChoiceType("patternoid", "unknown")]
    [JsonPropertyName("patternoidUnknown")]
    public FhirOid? PatternOid { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as positiveInt)
    /// </summary>
    [FhirElement("patternpositiveintUnknown", Order = 153)]
    [Cardinality(0, 1)]
    [ChoiceType("patternpositiveint", "unknown")]
    [JsonPropertyName("patternpositiveintUnknown")]
    public FhirPositiveInt? PatternPositiveInt { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as string)
    /// </summary>
    [FhirElement("patternString", Order = 154)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "string")]
    [JsonPropertyName("patternString")]
    public FhirString? PatternString { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as time)
    /// </summary>
    [FhirElement("patterntimeUnknown", Order = 155)]
    [Cardinality(0, 1)]
    [ChoiceType("patterntime", "unknown")]
    [JsonPropertyName("patterntimeUnknown")]
    public FhirTime? PatternTime { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as unsignedInt)
    /// </summary>
    [FhirElement("patternunsignedintUnknown", Order = 156)]
    [Cardinality(0, 1)]
    [ChoiceType("patternunsignedint", "unknown")]
    [JsonPropertyName("patternunsignedintUnknown")]
    public FhirUnsignedInt? PatternUnsignedInt { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as uri)
    /// </summary>
    [FhirElement("patternUri", Order = 157)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "uri")]
    [JsonPropertyName("patternUri")]
    public FhirUri? PatternUri { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as url)
    /// </summary>
    [FhirElement("patternurlUnknown", Order = 158)]
    [Cardinality(0, 1)]
    [ChoiceType("patternurl", "unknown")]
    [JsonPropertyName("patternurlUnknown")]
    public FhirUrl? PatternUrl { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as uuid)
    /// </summary>
    [FhirElement("patternuuidUnknown", Order = 159)]
    [Cardinality(0, 1)]
    [ChoiceType("patternuuid", "unknown")]
    [JsonPropertyName("patternuuidUnknown")]
    public FhirUuid? PatternUuid { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Address)
    /// </summary>
    [FhirElement("patternAddress", Order = 160)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "address")]
    [JsonPropertyName("patternAddress")]
    public Address PatternAddress { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Age)
    /// </summary>
    [FhirElement("patternageUnknown", Order = 161)]
    [Cardinality(0, 1)]
    [ChoiceType("patternage", "unknown")]
    [JsonPropertyName("patternageUnknown")]
    public Age PatternAge { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Annotation)
    /// </summary>
    [FhirElement("patternAnnotation", Order = 162)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "annotation")]
    [JsonPropertyName("patternAnnotation")]
    public Annotation PatternAnnotation { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Attachment)
    /// </summary>
    [FhirElement("patternAttachment", Order = 163)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "attachment")]
    [JsonPropertyName("patternAttachment")]
    public Attachment PatternAttachment { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as CodeableConcept)
    /// </summary>
    [FhirElement("patternCodeableConcept", Order = 164)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "codeableConcept")]
    [JsonPropertyName("patternCodeableConcept")]
    public CodeableConcept PatternCodeableConcept { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as CodeableReference)
    /// </summary>
    [FhirElement("patternCodeableReference", Order = 165)]
    [Cardinality(0, 1)]
    [ChoiceType("patternCodeable", "reference")]
    [JsonPropertyName("patternCodeableReference")]
    public CodeableReference PatternCodeableReference { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Coding)
    /// </summary>
    [FhirElement("patternCoding", Order = 166)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "coding")]
    [JsonPropertyName("patternCoding")]
    public Coding PatternCoding { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as ContactPoint)
    /// </summary>
    [FhirElement("patternContactPoint", Order = 167)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "contactPoint")]
    [JsonPropertyName("patternContactPoint")]
    public ContactPoint PatternContactPoint { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Count)
    /// </summary>
    [FhirElement("patterncountUnknown", Order = 168)]
    [Cardinality(0, 1)]
    [ChoiceType("patterncount", "unknown")]
    [JsonPropertyName("patterncountUnknown")]
    public Count PatternCount { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Distance)
    /// </summary>
    [FhirElement("patterndistanceUnknown", Order = 169)]
    [Cardinality(0, 1)]
    [ChoiceType("patterndistance", "unknown")]
    [JsonPropertyName("patterndistanceUnknown")]
    public Distance PatternDistance { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Duration)
    /// </summary>
    [FhirElement("patterndurationUnknown", Order = 170)]
    [Cardinality(0, 1)]
    [ChoiceType("patternduration", "unknown")]
    [JsonPropertyName("patterndurationUnknown")]
    public Duration PatternDuration { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as HumanName)
    /// </summary>
    [FhirElement("patternHumanName", Order = 171)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "humanName")]
    [JsonPropertyName("patternHumanName")]
    public HumanName PatternHumanName { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Identifier)
    /// </summary>
    [FhirElement("patternIdentifier", Order = 172)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "identifier")]
    [JsonPropertyName("patternIdentifier")]
    public Identifier PatternIdentifier { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Money)
    /// </summary>
    [FhirElement("patternmoneyUnknown", Order = 173)]
    [Cardinality(0, 1)]
    [ChoiceType("patternmoney", "unknown")]
    [JsonPropertyName("patternmoneyUnknown")]
    public Money PatternMoney { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Period)
    /// </summary>
    [FhirElement("patternPeriod", Order = 174)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "period")]
    [JsonPropertyName("patternPeriod")]
    public Period PatternPeriod { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Quantity)
    /// </summary>
    [FhirElement("patternQuantity", Order = 175)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "quantity")]
    [JsonPropertyName("patternQuantity")]
    public Quantity PatternQuantity { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Range)
    /// </summary>
    [FhirElement("patternRange", Order = 176)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "range")]
    [JsonPropertyName("patternRange")]
    public Range PatternRange { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Ratio)
    /// </summary>
    [FhirElement("patternRatio", Order = 177)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "ratio")]
    [JsonPropertyName("patternRatio")]
    public Ratio PatternRatio { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as RatioRange)
    /// </summary>
    [FhirElement("patternRatioRange", Order = 178)]
    [Cardinality(0, 1)]
    [ChoiceType("patternRatio", "range")]
    [JsonPropertyName("patternRatioRange")]
    public RatioRange PatternRatioRange { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Reference)
    /// </summary>
    [FhirElement("patternReference", Order = 179)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "reference")]
    [JsonPropertyName("patternReference")]
    public Reference PatternReference { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as SampledData)
    /// </summary>
    [FhirElement("patternsampleddataUnknown", Order = 180)]
    [Cardinality(0, 1)]
    [ChoiceType("patternsampleddata", "unknown")]
    [JsonPropertyName("patternsampleddataUnknown")]
    public SampledData PatternSampledData { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Signature)
    /// </summary>
    [FhirElement("patternSignature", Order = 181)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "signature")]
    [JsonPropertyName("patternSignature")]
    public Signature PatternSignature { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Timing)
    /// </summary>
    [FhirElement("patternTiming", Order = 182)]
    [Cardinality(0, 1)]
    [ChoiceType("pattern", "timing")]
    [JsonPropertyName("patternTiming")]
    public Timing PatternTiming { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as ContactDetail)
    /// </summary>
    [FhirElement("patterncontactdetailUnknown", Order = 183)]
    [Cardinality(0, 1)]
    [ChoiceType("patterncontactdetail", "unknown")]
    [JsonPropertyName("patterncontactdetailUnknown")]
    public ContactDetail PatternContactDetail { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as DataRequirement)
    /// </summary>
    [FhirElement("patterndatarequirementUnknown", Order = 184)]
    [Cardinality(0, 1)]
    [ChoiceType("patterndatarequirement", "unknown")]
    [JsonPropertyName("patterndatarequirementUnknown")]
    public DataRequirement PatternDataRequirement { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Expression)
    /// </summary>
    [FhirElement("patternexpressionUnknown", Order = 185)]
    [Cardinality(0, 1)]
    [ChoiceType("patternexpression", "unknown")]
    [JsonPropertyName("patternexpressionUnknown")]
    public Expression PatternExpression { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as ParameterDefinition)
    /// </summary>
    [FhirElement("patternparameterdefinitionUnknown", Order = 186)]
    [Cardinality(0, 1)]
    [ChoiceType("patternparameterdefinition", "unknown")]
    [JsonPropertyName("patternparameterdefinitionUnknown")]
    public ParameterDefinition PatternParameterDefinition { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as RelatedArtifact)
    /// </summary>
    [FhirElement("patternrelatedartifactUnknown", Order = 187)]
    [Cardinality(0, 1)]
    [ChoiceType("patternrelatedartifact", "unknown")]
    [JsonPropertyName("patternrelatedartifactUnknown")]
    public RelatedArtifact PatternRelatedArtifact { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as TriggerDefinition)
    /// </summary>
    [FhirElement("patterntriggerdefinitionUnknown", Order = 188)]
    [Cardinality(0, 1)]
    [ChoiceType("patterntriggerdefinition", "unknown")]
    [JsonPropertyName("patterntriggerdefinitionUnknown")]
    public TriggerDefinition PatternTriggerDefinition { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as UsageContext)
    /// </summary>
    [FhirElement("patternusagecontextUnknown", Order = 189)]
    [Cardinality(0, 1)]
    [ChoiceType("patternusagecontext", "unknown")]
    [JsonPropertyName("patternusagecontextUnknown")]
    public UsageContext PatternUsageContext { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Availability)
    /// </summary>
    [FhirElement("patternavailabilityUnknown", Order = 190)]
    [Cardinality(0, 1)]
    [ChoiceType("patternavailability", "unknown")]
    [JsonPropertyName("patternavailabilityUnknown")]
    public Availability PatternAvailability { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as ExtendedContactDetail)
    /// </summary>
    [FhirElement("patternextendedcontactdetailUnknown", Order = 191)]
    [Cardinality(0, 1)]
    [ChoiceType("patternextendedcontactdetail", "unknown")]
    [JsonPropertyName("patternextendedcontactdetailUnknown")]
    public ExtendedContactDetail PatternExtendedContactDetail { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Dosage)
    /// </summary>
    [FhirElement("patterndosageUnknown", Order = 192)]
    [Cardinality(0, 1)]
    [ChoiceType("patterndosage", "unknown")]
    [JsonPropertyName("patterndosageUnknown")]
    public Dosage PatternDosage { get; set; }

    /// <summary>
    /// Specifies a value that each occurrence of the element in the instance SHALL follow - that is, any
    /// value in the pattern must be found in the instance, if the element has a value. Other additional
    /// values may be found too. This is effectively constraint by example. When pattern[x] is used to
    /// constrain a primitive, it means that the value provided in the pattern[x] must match the instance
    /// value exactly. When an element within a pattern[x] is used to constrain an array, it means that each
    /// element provided in the pattern[x] must (recursively) match at least one element from the instance
    /// array. When pattern[x] is used to constrain a complex object, it means that each property in the
    /// pattern must be present in the complex object, and its value must recursively match -- i.e., 1. If
    /// primitive: it must match exactly the pattern value 2. If a complex object: it must match
    /// (recursively) the pattern value 3. If an array: it must match (recursively) the pattern value If a
    /// pattern[x] is declared on a repeating element, the pattern applies to all repetitions. If the desire
    /// is for a pattern to apply to only one element or a subset of elements, slicing must be used. See
    /// [Examples of Patterns](elementdefinition-examples.html#pattern-examples) for examples of pattern
    /// usage and the effect it will have. (as Meta)
    /// </summary>
    [FhirElement("patternmetaUnknown", Order = 193)]
    [Cardinality(0, 1)]
    [ChoiceType("patternmeta", "unknown")]
    [JsonPropertyName("patternmetaUnknown")]
    public Meta PatternMeta { get; set; }

    /// <summary>
    /// A sample value for this element demonstrating the type of information that would typically be found
    /// in the element.
    /// </summary>
    [FhirElement("example", Order = 194)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("example")]
    public List<Element>? Example { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as date)
    /// </summary>
    [FhirElement("minvaluedateUnknown", Order = 195)]
    [Cardinality(0, 1)]
    [ChoiceType("minvaluedate", "unknown")]
    [JsonPropertyName("minvaluedateUnknown")]
    public FhirDate? MinValueDate { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as dateTime)
    /// </summary>
    [FhirElement("minValueDateTime", Order = 196)]
    [Cardinality(0, 1)]
    [ChoiceType("minValue", "dateTime")]
    [JsonPropertyName("minValueDateTime")]
    public FhirDateTime? MinValueDateTime { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as instant)
    /// </summary>
    [FhirElement("minvalueinstantUnknown", Order = 197)]
    [Cardinality(0, 1)]
    [ChoiceType("minvalueinstant", "unknown")]
    [JsonPropertyName("minvalueinstantUnknown")]
    public FhirInstant? MinValueInstant { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as time)
    /// </summary>
    [FhirElement("minvaluetimeUnknown", Order = 198)]
    [Cardinality(0, 1)]
    [ChoiceType("minvaluetime", "unknown")]
    [JsonPropertyName("minvaluetimeUnknown")]
    public FhirTime? MinValueTime { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as decimal)
    /// </summary>
    [FhirElement("minValueDecimal", Order = 199)]
    [Cardinality(0, 1)]
    [ChoiceType("minValue", "decimal")]
    [JsonPropertyName("minValueDecimal")]
    public FhirDecimal? MinValueDecimal { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as integer)
    /// </summary>
    [FhirElement("minValueInteger", Order = 200)]
    [Cardinality(0, 1)]
    [ChoiceType("minValue", "integer")]
    [JsonPropertyName("minValueInteger")]
    public FhirInteger? MinValueInteger { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as integer64)
    /// </summary>
    [FhirElement("minvalueinteger64Unknown", Order = 201)]
    [Cardinality(0, 1)]
    [ChoiceType("minvalueinteger64", "unknown")]
    [JsonPropertyName("minvalueinteger64Unknown")]
    public FhirInteger64? MinValueInteger64 { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as positiveInt)
    /// </summary>
    [FhirElement("minvaluepositiveintUnknown", Order = 202)]
    [Cardinality(0, 1)]
    [ChoiceType("minvaluepositiveint", "unknown")]
    [JsonPropertyName("minvaluepositiveintUnknown")]
    public FhirPositiveInt? MinValuePositiveInt { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as unsignedInt)
    /// </summary>
    [FhirElement("minvalueunsignedintUnknown", Order = 203)]
    [Cardinality(0, 1)]
    [ChoiceType("minvalueunsignedint", "unknown")]
    [JsonPropertyName("minvalueunsignedintUnknown")]
    public FhirUnsignedInt? MinValueUnsignedInt { get; set; }

    /// <summary>
    /// The minimum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as Quantity)
    /// </summary>
    [FhirElement("minValueQuantity", Order = 204)]
    [Cardinality(0, 1)]
    [ChoiceType("minValue", "quantity")]
    [JsonPropertyName("minValueQuantity")]
    public Quantity MinValueQuantity { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as date)
    /// </summary>
    [FhirElement("maxvaluedateUnknown", Order = 205)]
    [Cardinality(0, 1)]
    [ChoiceType("maxvaluedate", "unknown")]
    [JsonPropertyName("maxvaluedateUnknown")]
    public FhirDate? MaxValueDate { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as dateTime)
    /// </summary>
    [FhirElement("maxValueDateTime", Order = 206)]
    [Cardinality(0, 1)]
    [ChoiceType("maxValue", "dateTime")]
    [JsonPropertyName("maxValueDateTime")]
    public FhirDateTime? MaxValueDateTime { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as instant)
    /// </summary>
    [FhirElement("maxvalueinstantUnknown", Order = 207)]
    [Cardinality(0, 1)]
    [ChoiceType("maxvalueinstant", "unknown")]
    [JsonPropertyName("maxvalueinstantUnknown")]
    public FhirInstant? MaxValueInstant { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as time)
    /// </summary>
    [FhirElement("maxvaluetimeUnknown", Order = 208)]
    [Cardinality(0, 1)]
    [ChoiceType("maxvaluetime", "unknown")]
    [JsonPropertyName("maxvaluetimeUnknown")]
    public FhirTime? MaxValueTime { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as decimal)
    /// </summary>
    [FhirElement("maxValueDecimal", Order = 209)]
    [Cardinality(0, 1)]
    [ChoiceType("maxValue", "decimal")]
    [JsonPropertyName("maxValueDecimal")]
    public FhirDecimal? MaxValueDecimal { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as integer)
    /// </summary>
    [FhirElement("maxValueInteger", Order = 210)]
    [Cardinality(0, 1)]
    [ChoiceType("maxValue", "integer")]
    [JsonPropertyName("maxValueInteger")]
    public FhirInteger? MaxValueInteger { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as integer64)
    /// </summary>
    [FhirElement("maxvalueinteger64Unknown", Order = 211)]
    [Cardinality(0, 1)]
    [ChoiceType("maxvalueinteger64", "unknown")]
    [JsonPropertyName("maxvalueinteger64Unknown")]
    public FhirInteger64? MaxValueInteger64 { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as positiveInt)
    /// </summary>
    [FhirElement("maxvaluepositiveintUnknown", Order = 212)]
    [Cardinality(0, 1)]
    [ChoiceType("maxvaluepositiveint", "unknown")]
    [JsonPropertyName("maxvaluepositiveintUnknown")]
    public FhirPositiveInt? MaxValuePositiveInt { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as unsignedInt)
    /// </summary>
    [FhirElement("maxvalueunsignedintUnknown", Order = 213)]
    [Cardinality(0, 1)]
    [ChoiceType("maxvalueunsignedint", "unknown")]
    [JsonPropertyName("maxvalueunsignedintUnknown")]
    public FhirUnsignedInt? MaxValueUnsignedInt { get; set; }

    /// <summary>
    /// The maximum allowed value for the element. The value is inclusive. This is allowed for the types
    /// date, dateTime, instant, time, decimal, integer, and Quantity. (as Quantity)
    /// </summary>
    [FhirElement("maxValueQuantity", Order = 214)]
    [Cardinality(0, 1)]
    [ChoiceType("maxValue", "quantity")]
    [JsonPropertyName("maxValueQuantity")]
    public Quantity MaxValueQuantity { get; set; }

    /// <summary>
    /// Indicates the maximum length in characters that is permitted to be present in conformant instances
    /// and which is expected to be supported by conformant consumers that support the element.
    /// ```maxLength``` SHOULD only be used on primitive data types that have a string representation (see
    /// [http://hl7.org/fhir/StructureDefinition/structuredefinition-type-characteristics](http://hl7.org/fhir/extensions/StructureDefinition-structuredefinition-type-characteristics.html)).
    /// </summary>
    [FhirElement("maxLength", Order = 215)]
    [Cardinality(0, 1)]
    [JsonPropertyName("maxLength")]
    public FhirInteger? MaxLength { get; set; }

    /// <summary>
    /// A reference to an invariant that may make additional statements about the cardinality or value in
    /// the instance.
    /// </summary>
    [FhirElement("condition", Order = 216)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("condition")]
    public List<FhirId>? Condition { get; set; }

    /// <summary>
    /// Formal constraints such as co-occurrence and other constraints that can be computationally evaluated
    /// within the context of the instance.
    /// </summary>
    [FhirElement("constraint", Order = 217)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("constraint")]
    public List<Element>? Constraint { get; set; }

    /// <summary>
    /// Specifies for a primitive data type that the value of the data type cannot be replaced by an
    /// extension.
    /// </summary>
    [FhirElement("mustHaveValue", Order = 218)]
    [Cardinality(0, 1)]
    [JsonPropertyName("mustHaveValue")]
    public FhirBoolean? MustHaveValue { get; set; }

    /// <summary>
    /// Specifies a list of extensions that can appear in place of a primitive value.
    /// </summary>
    [FhirElement("valueAlternatives", Order = 219)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("valueAlternatives")]
    public List<FhirCanonical>? ValueAlternatives { get; set; }

    /// <summary>
    /// If true, implementations that produce or consume resources SHALL provide &quot;support&quot; for the
    /// element in some meaningful way. Note that this is being phased out and replaced by obligations (see
    /// below). If false, the element may be ignored and not supported. If false, whether to populate or use
    /// the data element in any way is at the discretion of the implementation.
    /// </summary>
    [FhirElement("mustSupport", Order = 220)]
    [Cardinality(0, 1)]
    [JsonPropertyName("mustSupport")]
    public FhirBoolean? MustSupport { get; set; }

    /// <summary>
    /// If true, the value of this element affects the interpretation of the element or resource that
    /// contains it, and the value of the element cannot be ignored. Typically, this is used for status,
    /// negation and qualification codes. The effect of this is that the element cannot be ignored by
    /// systems: they SHALL either recognize the element and process it, and/or a pre-determination has been
    /// made that it is not relevant to their particular system. When used on the root element in an
    /// extension definition, this indicates whether or not the extension is a modifier extension.
    /// </summary>
    [FhirElement("isModifier", Order = 221)]
    [Cardinality(0, 1)]
    [JsonPropertyName("isModifier")]
    public FhirBoolean? IsModifier { get; set; }

    /// <summary>
    /// Explains how that element affects the interpretation of the resource or element that contains it.
    /// </summary>
    [FhirElement("isModifierReason", Order = 222)]
    [Cardinality(0, 1)]
    [JsonPropertyName("isModifierReason")]
    public FhirString? IsModifierReason { get; set; }

    /// <summary>
    /// Whether the element should be included if a client requests a search with the parameter
    /// _summary=true.
    /// </summary>
    [FhirElement("isSummary", Order = 223)]
    [Cardinality(0, 1)]
    [JsonPropertyName("isSummary")]
    public FhirBoolean? IsSummary { get; set; }

    /// <summary>
    /// Binds to a value set if this element is coded (code, Coding, CodeableConcept, Quantity), or the data
    /// types (string, uri).
    /// </summary>
    [FhirElement("binding", Order = 224)]
    [Cardinality(0, 1)]
    [JsonPropertyName("binding")]
    public Element Binding { get; set; }

    /// <summary>
    /// Identifies a concept from an external specification that roughly corresponds to this element.
    /// </summary>
    [FhirElement("mapping", Order = 225)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("mapping")]
    public List<Element>? Mapping { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for defaultvaluebase64binary[x]
        var defaultvaluebase64binaryProperties = new[] { nameof(DefaultValueBase64Binary) };
        var defaultvaluebase64binarySetCount = defaultvaluebase64binaryProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluebase64binarySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueBase64Binary may be specified",
                new[] { nameof(DefaultValueBase64Binary) });
        }

        // Choice Type validation for defaultValue[x]
        var defaultValueProperties = new[] { nameof(DefaultValueBoolean), nameof(DefaultValueCode), nameof(DefaultValueDateTime), nameof(DefaultValueDecimal), nameof(DefaultValueInteger), nameof(DefaultValueString), nameof(DefaultValueUri), nameof(DefaultValueAddress), nameof(DefaultValueAnnotation), nameof(DefaultValueAttachment), nameof(DefaultValueCodeableConcept), nameof(DefaultValueCoding), nameof(DefaultValueContactPoint), nameof(DefaultValueHumanName), nameof(DefaultValueIdentifier), nameof(DefaultValuePeriod), nameof(DefaultValueQuantity), nameof(DefaultValueRange), nameof(DefaultValueRatio), nameof(DefaultValueReference), nameof(DefaultValueSignature), nameof(DefaultValueTiming) };
        var defaultValueSetCount = defaultValueProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultValueSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueBoolean, DefaultValueCode, DefaultValueDateTime, DefaultValueDecimal, DefaultValueInteger, DefaultValueString, DefaultValueUri, DefaultValueAddress, DefaultValueAnnotation, DefaultValueAttachment, DefaultValueCodeableConcept, DefaultValueCoding, DefaultValueContactPoint, DefaultValueHumanName, DefaultValueIdentifier, DefaultValuePeriod, DefaultValueQuantity, DefaultValueRange, DefaultValueRatio, DefaultValueReference, DefaultValueSignature, DefaultValueTiming may be specified",
                new[] { nameof(DefaultValueBoolean), nameof(DefaultValueCode), nameof(DefaultValueDateTime), nameof(DefaultValueDecimal), nameof(DefaultValueInteger), nameof(DefaultValueString), nameof(DefaultValueUri), nameof(DefaultValueAddress), nameof(DefaultValueAnnotation), nameof(DefaultValueAttachment), nameof(DefaultValueCodeableConcept), nameof(DefaultValueCoding), nameof(DefaultValueContactPoint), nameof(DefaultValueHumanName), nameof(DefaultValueIdentifier), nameof(DefaultValuePeriod), nameof(DefaultValueQuantity), nameof(DefaultValueRange), nameof(DefaultValueRatio), nameof(DefaultValueReference), nameof(DefaultValueSignature), nameof(DefaultValueTiming) });
        }

        // Choice Type validation for defaultvaluecanonical[x]
        var defaultvaluecanonicalProperties = new[] { nameof(DefaultValueCanonical) };
        var defaultvaluecanonicalSetCount = defaultvaluecanonicalProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluecanonicalSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueCanonical may be specified",
                new[] { nameof(DefaultValueCanonical) });
        }

        // Choice Type validation for defaultvaluedate[x]
        var defaultvaluedateProperties = new[] { nameof(DefaultValueDate) };
        var defaultvaluedateSetCount = defaultvaluedateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluedateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueDate may be specified",
                new[] { nameof(DefaultValueDate) });
        }

        // Choice Type validation for defaultvalueid[x]
        var defaultvalueidProperties = new[] { nameof(DefaultValueId) };
        var defaultvalueidSetCount = defaultvalueidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueId may be specified",
                new[] { nameof(DefaultValueId) });
        }

        // Choice Type validation for defaultvalueinstant[x]
        var defaultvalueinstantProperties = new[] { nameof(DefaultValueInstant) };
        var defaultvalueinstantSetCount = defaultvalueinstantProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueinstantSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueInstant may be specified",
                new[] { nameof(DefaultValueInstant) });
        }

        // Choice Type validation for defaultvalueinteger64[x]
        var defaultvalueinteger64Properties = new[] { nameof(DefaultValueInteger64) };
        var defaultvalueinteger64SetCount = defaultvalueinteger64Properties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueinteger64SetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueInteger64 may be specified",
                new[] { nameof(DefaultValueInteger64) });
        }

        // Choice Type validation for defaultvaluemarkdown[x]
        var defaultvaluemarkdownProperties = new[] { nameof(DefaultValueMarkdown) };
        var defaultvaluemarkdownSetCount = defaultvaluemarkdownProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluemarkdownSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueMarkdown may be specified",
                new[] { nameof(DefaultValueMarkdown) });
        }

        // Choice Type validation for defaultvalueoid[x]
        var defaultvalueoidProperties = new[] { nameof(DefaultValueOid) };
        var defaultvalueoidSetCount = defaultvalueoidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueoidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueOid may be specified",
                new[] { nameof(DefaultValueOid) });
        }

        // Choice Type validation for defaultvaluepositiveint[x]
        var defaultvaluepositiveintProperties = new[] { nameof(DefaultValuePositiveInt) };
        var defaultvaluepositiveintSetCount = defaultvaluepositiveintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluepositiveintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValuePositiveInt may be specified",
                new[] { nameof(DefaultValuePositiveInt) });
        }

        // Choice Type validation for defaultvaluetime[x]
        var defaultvaluetimeProperties = new[] { nameof(DefaultValueTime) };
        var defaultvaluetimeSetCount = defaultvaluetimeProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluetimeSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueTime may be specified",
                new[] { nameof(DefaultValueTime) });
        }

        // Choice Type validation for defaultvalueunsignedint[x]
        var defaultvalueunsignedintProperties = new[] { nameof(DefaultValueUnsignedInt) };
        var defaultvalueunsignedintSetCount = defaultvalueunsignedintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueunsignedintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueUnsignedInt may be specified",
                new[] { nameof(DefaultValueUnsignedInt) });
        }

        // Choice Type validation for defaultvalueurl[x]
        var defaultvalueurlProperties = new[] { nameof(DefaultValueUrl) };
        var defaultvalueurlSetCount = defaultvalueurlProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueurlSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueUrl may be specified",
                new[] { nameof(DefaultValueUrl) });
        }

        // Choice Type validation for defaultvalueuuid[x]
        var defaultvalueuuidProperties = new[] { nameof(DefaultValueUuid) };
        var defaultvalueuuidSetCount = defaultvalueuuidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueuuidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueUuid may be specified",
                new[] { nameof(DefaultValueUuid) });
        }

        // Choice Type validation for defaultvalueage[x]
        var defaultvalueageProperties = new[] { nameof(DefaultValueAge) };
        var defaultvalueageSetCount = defaultvalueageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueAge may be specified",
                new[] { nameof(DefaultValueAge) });
        }

        // Choice Type validation for defaultValueCodeable[x]
        var defaultValueCodeableProperties = new[] { nameof(DefaultValueCodeableReference) };
        var defaultValueCodeableSetCount = defaultValueCodeableProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultValueCodeableSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueCodeableReference may be specified",
                new[] { nameof(DefaultValueCodeableReference) });
        }

        // Choice Type validation for defaultvaluecount[x]
        var defaultvaluecountProperties = new[] { nameof(DefaultValueCount) };
        var defaultvaluecountSetCount = defaultvaluecountProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluecountSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueCount may be specified",
                new[] { nameof(DefaultValueCount) });
        }

        // Choice Type validation for defaultvaluedistance[x]
        var defaultvaluedistanceProperties = new[] { nameof(DefaultValueDistance) };
        var defaultvaluedistanceSetCount = defaultvaluedistanceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluedistanceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueDistance may be specified",
                new[] { nameof(DefaultValueDistance) });
        }

        // Choice Type validation for defaultvalueduration[x]
        var defaultvaluedurationProperties = new[] { nameof(DefaultValueDuration) };
        var defaultvaluedurationSetCount = defaultvaluedurationProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluedurationSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueDuration may be specified",
                new[] { nameof(DefaultValueDuration) });
        }

        // Choice Type validation for defaultvaluemoney[x]
        var defaultvaluemoneyProperties = new[] { nameof(DefaultValueMoney) };
        var defaultvaluemoneySetCount = defaultvaluemoneyProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluemoneySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueMoney may be specified",
                new[] { nameof(DefaultValueMoney) });
        }

        // Choice Type validation for defaultValueRatio[x]
        var defaultValueRatioProperties = new[] { nameof(DefaultValueRatioRange) };
        var defaultValueRatioSetCount = defaultValueRatioProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultValueRatioSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueRatioRange may be specified",
                new[] { nameof(DefaultValueRatioRange) });
        }

        // Choice Type validation for defaultvaluesampleddata[x]
        var defaultvaluesampleddataProperties = new[] { nameof(DefaultValueSampledData) };
        var defaultvaluesampleddataSetCount = defaultvaluesampleddataProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluesampleddataSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueSampledData may be specified",
                new[] { nameof(DefaultValueSampledData) });
        }

        // Choice Type validation for defaultvaluecontactdetail[x]
        var defaultvaluecontactdetailProperties = new[] { nameof(DefaultValueContactDetail) };
        var defaultvaluecontactdetailSetCount = defaultvaluecontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluecontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueContactDetail may be specified",
                new[] { nameof(DefaultValueContactDetail) });
        }

        // Choice Type validation for defaultvaluedatarequirement[x]
        var defaultvaluedatarequirementProperties = new[] { nameof(DefaultValueDataRequirement) };
        var defaultvaluedatarequirementSetCount = defaultvaluedatarequirementProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluedatarequirementSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueDataRequirement may be specified",
                new[] { nameof(DefaultValueDataRequirement) });
        }

        // Choice Type validation for defaultvalueexpression[x]
        var defaultvalueexpressionProperties = new[] { nameof(DefaultValueExpression) };
        var defaultvalueexpressionSetCount = defaultvalueexpressionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueexpressionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueExpression may be specified",
                new[] { nameof(DefaultValueExpression) });
        }

        // Choice Type validation for defaultvalueparameterdefinition[x]
        var defaultvalueparameterdefinitionProperties = new[] { nameof(DefaultValueParameterDefinition) };
        var defaultvalueparameterdefinitionSetCount = defaultvalueparameterdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueparameterdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueParameterDefinition may be specified",
                new[] { nameof(DefaultValueParameterDefinition) });
        }

        // Choice Type validation for defaultvaluerelatedartifact[x]
        var defaultvaluerelatedartifactProperties = new[] { nameof(DefaultValueRelatedArtifact) };
        var defaultvaluerelatedartifactSetCount = defaultvaluerelatedartifactProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluerelatedartifactSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueRelatedArtifact may be specified",
                new[] { nameof(DefaultValueRelatedArtifact) });
        }

        // Choice Type validation for defaultvaluetriggerdefinition[x]
        var defaultvaluetriggerdefinitionProperties = new[] { nameof(DefaultValueTriggerDefinition) };
        var defaultvaluetriggerdefinitionSetCount = defaultvaluetriggerdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluetriggerdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueTriggerDefinition may be specified",
                new[] { nameof(DefaultValueTriggerDefinition) });
        }

        // Choice Type validation for defaultvalueusagecontext[x]
        var defaultvalueusagecontextProperties = new[] { nameof(DefaultValueUsageContext) };
        var defaultvalueusagecontextSetCount = defaultvalueusagecontextProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueusagecontextSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueUsageContext may be specified",
                new[] { nameof(DefaultValueUsageContext) });
        }

        // Choice Type validation for defaultvalueavailability[x]
        var defaultvalueavailabilityProperties = new[] { nameof(DefaultValueAvailability) };
        var defaultvalueavailabilitySetCount = defaultvalueavailabilityProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueavailabilitySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueAvailability may be specified",
                new[] { nameof(DefaultValueAvailability) });
        }

        // Choice Type validation for defaultvalueextendedcontactdetail[x]
        var defaultvalueextendedcontactdetailProperties = new[] { nameof(DefaultValueExtendedContactDetail) };
        var defaultvalueextendedcontactdetailSetCount = defaultvalueextendedcontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvalueextendedcontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueExtendedContactDetail may be specified",
                new[] { nameof(DefaultValueExtendedContactDetail) });
        }

        // Choice Type validation for defaultvaluedosage[x]
        var defaultvaluedosageProperties = new[] { nameof(DefaultValueDosage) };
        var defaultvaluedosageSetCount = defaultvaluedosageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluedosageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueDosage may be specified",
                new[] { nameof(DefaultValueDosage) });
        }

        // Choice Type validation for defaultvaluemeta[x]
        var defaultvaluemetaProperties = new[] { nameof(DefaultValueMeta) };
        var defaultvaluemetaSetCount = defaultvaluemetaProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (defaultvaluemetaSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of DefaultValueMeta may be specified",
                new[] { nameof(DefaultValueMeta) });
        }

        // Choice Type validation for fixedbase64binary[x]
        var fixedbase64binaryProperties = new[] { nameof(FixedBase64Binary) };
        var fixedbase64binarySetCount = fixedbase64binaryProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedbase64binarySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedBase64Binary may be specified",
                new[] { nameof(FixedBase64Binary) });
        }

        // Choice Type validation for fixed[x]
        var fixedProperties = new[] { nameof(FixedBoolean), nameof(FixedCode), nameof(FixedDateTime), nameof(FixedDecimal), nameof(FixedInteger), nameof(FixedString), nameof(FixedUri), nameof(FixedAddress), nameof(FixedAnnotation), nameof(FixedAttachment), nameof(FixedCodeableConcept), nameof(FixedCoding), nameof(FixedContactPoint), nameof(FixedHumanName), nameof(FixedIdentifier), nameof(FixedPeriod), nameof(FixedQuantity), nameof(FixedRange), nameof(FixedRatio), nameof(FixedReference), nameof(FixedSignature), nameof(FixedTiming) };
        var fixedSetCount = fixedProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedBoolean, FixedCode, FixedDateTime, FixedDecimal, FixedInteger, FixedString, FixedUri, FixedAddress, FixedAnnotation, FixedAttachment, FixedCodeableConcept, FixedCoding, FixedContactPoint, FixedHumanName, FixedIdentifier, FixedPeriod, FixedQuantity, FixedRange, FixedRatio, FixedReference, FixedSignature, FixedTiming may be specified",
                new[] { nameof(FixedBoolean), nameof(FixedCode), nameof(FixedDateTime), nameof(FixedDecimal), nameof(FixedInteger), nameof(FixedString), nameof(FixedUri), nameof(FixedAddress), nameof(FixedAnnotation), nameof(FixedAttachment), nameof(FixedCodeableConcept), nameof(FixedCoding), nameof(FixedContactPoint), nameof(FixedHumanName), nameof(FixedIdentifier), nameof(FixedPeriod), nameof(FixedQuantity), nameof(FixedRange), nameof(FixedRatio), nameof(FixedReference), nameof(FixedSignature), nameof(FixedTiming) });
        }

        // Choice Type validation for fixedcanonical[x]
        var fixedcanonicalProperties = new[] { nameof(FixedCanonical) };
        var fixedcanonicalSetCount = fixedcanonicalProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedcanonicalSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedCanonical may be specified",
                new[] { nameof(FixedCanonical) });
        }

        // Choice Type validation for fixeddate[x]
        var fixeddateProperties = new[] { nameof(FixedDate) };
        var fixeddateSetCount = fixeddateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixeddateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedDate may be specified",
                new[] { nameof(FixedDate) });
        }

        // Choice Type validation for fixedid[x]
        var fixedidProperties = new[] { nameof(FixedId) };
        var fixedidSetCount = fixedidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedId may be specified",
                new[] { nameof(FixedId) });
        }

        // Choice Type validation for fixedinstant[x]
        var fixedinstantProperties = new[] { nameof(FixedInstant) };
        var fixedinstantSetCount = fixedinstantProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedinstantSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedInstant may be specified",
                new[] { nameof(FixedInstant) });
        }

        // Choice Type validation for fixedinteger64[x]
        var fixedinteger64Properties = new[] { nameof(FixedInteger64) };
        var fixedinteger64SetCount = fixedinteger64Properties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedinteger64SetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedInteger64 may be specified",
                new[] { nameof(FixedInteger64) });
        }

        // Choice Type validation for fixedmarkdown[x]
        var fixedmarkdownProperties = new[] { nameof(FixedMarkdown) };
        var fixedmarkdownSetCount = fixedmarkdownProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedmarkdownSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedMarkdown may be specified",
                new[] { nameof(FixedMarkdown) });
        }

        // Choice Type validation for fixedoid[x]
        var fixedoidProperties = new[] { nameof(FixedOid) };
        var fixedoidSetCount = fixedoidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedoidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedOid may be specified",
                new[] { nameof(FixedOid) });
        }

        // Choice Type validation for fixedpositiveint[x]
        var fixedpositiveintProperties = new[] { nameof(FixedPositiveInt) };
        var fixedpositiveintSetCount = fixedpositiveintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedpositiveintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedPositiveInt may be specified",
                new[] { nameof(FixedPositiveInt) });
        }

        // Choice Type validation for fixedtime[x]
        var fixedtimeProperties = new[] { nameof(FixedTime) };
        var fixedtimeSetCount = fixedtimeProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedtimeSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedTime may be specified",
                new[] { nameof(FixedTime) });
        }

        // Choice Type validation for fixedunsignedint[x]
        var fixedunsignedintProperties = new[] { nameof(FixedUnsignedInt) };
        var fixedunsignedintSetCount = fixedunsignedintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedunsignedintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedUnsignedInt may be specified",
                new[] { nameof(FixedUnsignedInt) });
        }

        // Choice Type validation for fixedurl[x]
        var fixedurlProperties = new[] { nameof(FixedUrl) };
        var fixedurlSetCount = fixedurlProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedurlSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedUrl may be specified",
                new[] { nameof(FixedUrl) });
        }

        // Choice Type validation for fixeduuid[x]
        var fixeduuidProperties = new[] { nameof(FixedUuid) };
        var fixeduuidSetCount = fixeduuidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixeduuidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedUuid may be specified",
                new[] { nameof(FixedUuid) });
        }

        // Choice Type validation for fixedage[x]
        var fixedageProperties = new[] { nameof(FixedAge) };
        var fixedageSetCount = fixedageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedAge may be specified",
                new[] { nameof(FixedAge) });
        }

        // Choice Type validation for fixedCodeable[x]
        var fixedCodeableProperties = new[] { nameof(FixedCodeableReference) };
        var fixedCodeableSetCount = fixedCodeableProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedCodeableSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedCodeableReference may be specified",
                new[] { nameof(FixedCodeableReference) });
        }

        // Choice Type validation for fixedcount[x]
        var fixedcountProperties = new[] { nameof(FixedCount) };
        var fixedcountSetCount = fixedcountProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedcountSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedCount may be specified",
                new[] { nameof(FixedCount) });
        }

        // Choice Type validation for fixeddistance[x]
        var fixeddistanceProperties = new[] { nameof(FixedDistance) };
        var fixeddistanceSetCount = fixeddistanceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixeddistanceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedDistance may be specified",
                new[] { nameof(FixedDistance) });
        }

        // Choice Type validation for fixedduration[x]
        var fixeddurationProperties = new[] { nameof(FixedDuration) };
        var fixeddurationSetCount = fixeddurationProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixeddurationSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedDuration may be specified",
                new[] { nameof(FixedDuration) });
        }

        // Choice Type validation for fixedmoney[x]
        var fixedmoneyProperties = new[] { nameof(FixedMoney) };
        var fixedmoneySetCount = fixedmoneyProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedmoneySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedMoney may be specified",
                new[] { nameof(FixedMoney) });
        }

        // Choice Type validation for fixedRatio[x]
        var fixedRatioProperties = new[] { nameof(FixedRatioRange) };
        var fixedRatioSetCount = fixedRatioProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedRatioSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedRatioRange may be specified",
                new[] { nameof(FixedRatioRange) });
        }

        // Choice Type validation for fixedsampleddata[x]
        var fixedsampleddataProperties = new[] { nameof(FixedSampledData) };
        var fixedsampleddataSetCount = fixedsampleddataProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedsampleddataSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedSampledData may be specified",
                new[] { nameof(FixedSampledData) });
        }

        // Choice Type validation for fixedcontactdetail[x]
        var fixedcontactdetailProperties = new[] { nameof(FixedContactDetail) };
        var fixedcontactdetailSetCount = fixedcontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedcontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedContactDetail may be specified",
                new[] { nameof(FixedContactDetail) });
        }

        // Choice Type validation for fixeddatarequirement[x]
        var fixeddatarequirementProperties = new[] { nameof(FixedDataRequirement) };
        var fixeddatarequirementSetCount = fixeddatarequirementProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixeddatarequirementSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedDataRequirement may be specified",
                new[] { nameof(FixedDataRequirement) });
        }

        // Choice Type validation for fixedexpression[x]
        var fixedexpressionProperties = new[] { nameof(FixedExpression) };
        var fixedexpressionSetCount = fixedexpressionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedexpressionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedExpression may be specified",
                new[] { nameof(FixedExpression) });
        }

        // Choice Type validation for fixedparameterdefinition[x]
        var fixedparameterdefinitionProperties = new[] { nameof(FixedParameterDefinition) };
        var fixedparameterdefinitionSetCount = fixedparameterdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedparameterdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedParameterDefinition may be specified",
                new[] { nameof(FixedParameterDefinition) });
        }

        // Choice Type validation for fixedrelatedartifact[x]
        var fixedrelatedartifactProperties = new[] { nameof(FixedRelatedArtifact) };
        var fixedrelatedartifactSetCount = fixedrelatedartifactProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedrelatedartifactSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedRelatedArtifact may be specified",
                new[] { nameof(FixedRelatedArtifact) });
        }

        // Choice Type validation for fixedtriggerdefinition[x]
        var fixedtriggerdefinitionProperties = new[] { nameof(FixedTriggerDefinition) };
        var fixedtriggerdefinitionSetCount = fixedtriggerdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedtriggerdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedTriggerDefinition may be specified",
                new[] { nameof(FixedTriggerDefinition) });
        }

        // Choice Type validation for fixedusagecontext[x]
        var fixedusagecontextProperties = new[] { nameof(FixedUsageContext) };
        var fixedusagecontextSetCount = fixedusagecontextProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedusagecontextSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedUsageContext may be specified",
                new[] { nameof(FixedUsageContext) });
        }

        // Choice Type validation for fixedavailability[x]
        var fixedavailabilityProperties = new[] { nameof(FixedAvailability) };
        var fixedavailabilitySetCount = fixedavailabilityProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedavailabilitySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedAvailability may be specified",
                new[] { nameof(FixedAvailability) });
        }

        // Choice Type validation for fixedextendedcontactdetail[x]
        var fixedextendedcontactdetailProperties = new[] { nameof(FixedExtendedContactDetail) };
        var fixedextendedcontactdetailSetCount = fixedextendedcontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedextendedcontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedExtendedContactDetail may be specified",
                new[] { nameof(FixedExtendedContactDetail) });
        }

        // Choice Type validation for fixeddosage[x]
        var fixeddosageProperties = new[] { nameof(FixedDosage) };
        var fixeddosageSetCount = fixeddosageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixeddosageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedDosage may be specified",
                new[] { nameof(FixedDosage) });
        }

        // Choice Type validation for fixedmeta[x]
        var fixedmetaProperties = new[] { nameof(FixedMeta) };
        var fixedmetaSetCount = fixedmetaProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (fixedmetaSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of FixedMeta may be specified",
                new[] { nameof(FixedMeta) });
        }

        // Choice Type validation for patternbase64binary[x]
        var patternbase64binaryProperties = new[] { nameof(PatternBase64Binary) };
        var patternbase64binarySetCount = patternbase64binaryProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternbase64binarySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternBase64Binary may be specified",
                new[] { nameof(PatternBase64Binary) });
        }

        // Choice Type validation for pattern[x]
        var patternProperties = new[] { nameof(PatternBoolean), nameof(PatternCode), nameof(PatternDateTime), nameof(PatternDecimal), nameof(PatternInteger), nameof(PatternString), nameof(PatternUri), nameof(PatternAddress), nameof(PatternAnnotation), nameof(PatternAttachment), nameof(PatternCodeableConcept), nameof(PatternCoding), nameof(PatternContactPoint), nameof(PatternHumanName), nameof(PatternIdentifier), nameof(PatternPeriod), nameof(PatternQuantity), nameof(PatternRange), nameof(PatternRatio), nameof(PatternReference), nameof(PatternSignature), nameof(PatternTiming) };
        var patternSetCount = patternProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternBoolean, PatternCode, PatternDateTime, PatternDecimal, PatternInteger, PatternString, PatternUri, PatternAddress, PatternAnnotation, PatternAttachment, PatternCodeableConcept, PatternCoding, PatternContactPoint, PatternHumanName, PatternIdentifier, PatternPeriod, PatternQuantity, PatternRange, PatternRatio, PatternReference, PatternSignature, PatternTiming may be specified",
                new[] { nameof(PatternBoolean), nameof(PatternCode), nameof(PatternDateTime), nameof(PatternDecimal), nameof(PatternInteger), nameof(PatternString), nameof(PatternUri), nameof(PatternAddress), nameof(PatternAnnotation), nameof(PatternAttachment), nameof(PatternCodeableConcept), nameof(PatternCoding), nameof(PatternContactPoint), nameof(PatternHumanName), nameof(PatternIdentifier), nameof(PatternPeriod), nameof(PatternQuantity), nameof(PatternRange), nameof(PatternRatio), nameof(PatternReference), nameof(PatternSignature), nameof(PatternTiming) });
        }

        // Choice Type validation for patterncanonical[x]
        var patterncanonicalProperties = new[] { nameof(PatternCanonical) };
        var patterncanonicalSetCount = patterncanonicalProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterncanonicalSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternCanonical may be specified",
                new[] { nameof(PatternCanonical) });
        }

        // Choice Type validation for patterndate[x]
        var patterndateProperties = new[] { nameof(PatternDate) };
        var patterndateSetCount = patterndateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterndateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternDate may be specified",
                new[] { nameof(PatternDate) });
        }

        // Choice Type validation for patternid[x]
        var patternidProperties = new[] { nameof(PatternId) };
        var patternidSetCount = patternidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternId may be specified",
                new[] { nameof(PatternId) });
        }

        // Choice Type validation for patterninstant[x]
        var patterninstantProperties = new[] { nameof(PatternInstant) };
        var patterninstantSetCount = patterninstantProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterninstantSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternInstant may be specified",
                new[] { nameof(PatternInstant) });
        }

        // Choice Type validation for patterninteger64[x]
        var patterninteger64Properties = new[] { nameof(PatternInteger64) };
        var patterninteger64SetCount = patterninteger64Properties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterninteger64SetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternInteger64 may be specified",
                new[] { nameof(PatternInteger64) });
        }

        // Choice Type validation for patternmarkdown[x]
        var patternmarkdownProperties = new[] { nameof(PatternMarkdown) };
        var patternmarkdownSetCount = patternmarkdownProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternmarkdownSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternMarkdown may be specified",
                new[] { nameof(PatternMarkdown) });
        }

        // Choice Type validation for patternoid[x]
        var patternoidProperties = new[] { nameof(PatternOid) };
        var patternoidSetCount = patternoidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternoidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternOid may be specified",
                new[] { nameof(PatternOid) });
        }

        // Choice Type validation for patternpositiveint[x]
        var patternpositiveintProperties = new[] { nameof(PatternPositiveInt) };
        var patternpositiveintSetCount = patternpositiveintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternpositiveintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternPositiveInt may be specified",
                new[] { nameof(PatternPositiveInt) });
        }

        // Choice Type validation for patterntime[x]
        var patterntimeProperties = new[] { nameof(PatternTime) };
        var patterntimeSetCount = patterntimeProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterntimeSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternTime may be specified",
                new[] { nameof(PatternTime) });
        }

        // Choice Type validation for patternunsignedint[x]
        var patternunsignedintProperties = new[] { nameof(PatternUnsignedInt) };
        var patternunsignedintSetCount = patternunsignedintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternunsignedintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternUnsignedInt may be specified",
                new[] { nameof(PatternUnsignedInt) });
        }

        // Choice Type validation for patternurl[x]
        var patternurlProperties = new[] { nameof(PatternUrl) };
        var patternurlSetCount = patternurlProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternurlSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternUrl may be specified",
                new[] { nameof(PatternUrl) });
        }

        // Choice Type validation for patternuuid[x]
        var patternuuidProperties = new[] { nameof(PatternUuid) };
        var patternuuidSetCount = patternuuidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternuuidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternUuid may be specified",
                new[] { nameof(PatternUuid) });
        }

        // Choice Type validation for patternage[x]
        var patternageProperties = new[] { nameof(PatternAge) };
        var patternageSetCount = patternageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternAge may be specified",
                new[] { nameof(PatternAge) });
        }

        // Choice Type validation for patternCodeable[x]
        var patternCodeableProperties = new[] { nameof(PatternCodeableReference) };
        var patternCodeableSetCount = patternCodeableProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternCodeableSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternCodeableReference may be specified",
                new[] { nameof(PatternCodeableReference) });
        }

        // Choice Type validation for patterncount[x]
        var patterncountProperties = new[] { nameof(PatternCount) };
        var patterncountSetCount = patterncountProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterncountSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternCount may be specified",
                new[] { nameof(PatternCount) });
        }

        // Choice Type validation for patterndistance[x]
        var patterndistanceProperties = new[] { nameof(PatternDistance) };
        var patterndistanceSetCount = patterndistanceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterndistanceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternDistance may be specified",
                new[] { nameof(PatternDistance) });
        }

        // Choice Type validation for patternduration[x]
        var patterndurationProperties = new[] { nameof(PatternDuration) };
        var patterndurationSetCount = patterndurationProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterndurationSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternDuration may be specified",
                new[] { nameof(PatternDuration) });
        }

        // Choice Type validation for patternmoney[x]
        var patternmoneyProperties = new[] { nameof(PatternMoney) };
        var patternmoneySetCount = patternmoneyProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternmoneySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternMoney may be specified",
                new[] { nameof(PatternMoney) });
        }

        // Choice Type validation for patternRatio[x]
        var patternRatioProperties = new[] { nameof(PatternRatioRange) };
        var patternRatioSetCount = patternRatioProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternRatioSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternRatioRange may be specified",
                new[] { nameof(PatternRatioRange) });
        }

        // Choice Type validation for patternsampleddata[x]
        var patternsampleddataProperties = new[] { nameof(PatternSampledData) };
        var patternsampleddataSetCount = patternsampleddataProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternsampleddataSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternSampledData may be specified",
                new[] { nameof(PatternSampledData) });
        }

        // Choice Type validation for patterncontactdetail[x]
        var patterncontactdetailProperties = new[] { nameof(PatternContactDetail) };
        var patterncontactdetailSetCount = patterncontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterncontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternContactDetail may be specified",
                new[] { nameof(PatternContactDetail) });
        }

        // Choice Type validation for patterndatarequirement[x]
        var patterndatarequirementProperties = new[] { nameof(PatternDataRequirement) };
        var patterndatarequirementSetCount = patterndatarequirementProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterndatarequirementSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternDataRequirement may be specified",
                new[] { nameof(PatternDataRequirement) });
        }

        // Choice Type validation for patternexpression[x]
        var patternexpressionProperties = new[] { nameof(PatternExpression) };
        var patternexpressionSetCount = patternexpressionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternexpressionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternExpression may be specified",
                new[] { nameof(PatternExpression) });
        }

        // Choice Type validation for patternparameterdefinition[x]
        var patternparameterdefinitionProperties = new[] { nameof(PatternParameterDefinition) };
        var patternparameterdefinitionSetCount = patternparameterdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternparameterdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternParameterDefinition may be specified",
                new[] { nameof(PatternParameterDefinition) });
        }

        // Choice Type validation for patternrelatedartifact[x]
        var patternrelatedartifactProperties = new[] { nameof(PatternRelatedArtifact) };
        var patternrelatedartifactSetCount = patternrelatedartifactProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternrelatedartifactSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternRelatedArtifact may be specified",
                new[] { nameof(PatternRelatedArtifact) });
        }

        // Choice Type validation for patterntriggerdefinition[x]
        var patterntriggerdefinitionProperties = new[] { nameof(PatternTriggerDefinition) };
        var patterntriggerdefinitionSetCount = patterntriggerdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterntriggerdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternTriggerDefinition may be specified",
                new[] { nameof(PatternTriggerDefinition) });
        }

        // Choice Type validation for patternusagecontext[x]
        var patternusagecontextProperties = new[] { nameof(PatternUsageContext) };
        var patternusagecontextSetCount = patternusagecontextProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternusagecontextSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternUsageContext may be specified",
                new[] { nameof(PatternUsageContext) });
        }

        // Choice Type validation for patternavailability[x]
        var patternavailabilityProperties = new[] { nameof(PatternAvailability) };
        var patternavailabilitySetCount = patternavailabilityProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternavailabilitySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternAvailability may be specified",
                new[] { nameof(PatternAvailability) });
        }

        // Choice Type validation for patternextendedcontactdetail[x]
        var patternextendedcontactdetailProperties = new[] { nameof(PatternExtendedContactDetail) };
        var patternextendedcontactdetailSetCount = patternextendedcontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternextendedcontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternExtendedContactDetail may be specified",
                new[] { nameof(PatternExtendedContactDetail) });
        }

        // Choice Type validation for patterndosage[x]
        var patterndosageProperties = new[] { nameof(PatternDosage) };
        var patterndosageSetCount = patterndosageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patterndosageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternDosage may be specified",
                new[] { nameof(PatternDosage) });
        }

        // Choice Type validation for patternmeta[x]
        var patternmetaProperties = new[] { nameof(PatternMeta) };
        var patternmetaSetCount = patternmetaProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (patternmetaSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of PatternMeta may be specified",
                new[] { nameof(PatternMeta) });
        }

        // Choice Type validation for minvaluedate[x]
        var minvaluedateProperties = new[] { nameof(MinValueDate) };
        var minvaluedateSetCount = minvaluedateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (minvaluedateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MinValueDate may be specified",
                new[] { nameof(MinValueDate) });
        }

        // Choice Type validation for minValue[x]
        var minValueProperties = new[] { nameof(MinValueDateTime), nameof(MinValueDecimal), nameof(MinValueInteger), nameof(MinValueQuantity) };
        var minValueSetCount = minValueProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (minValueSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MinValueDateTime, MinValueDecimal, MinValueInteger, MinValueQuantity may be specified",
                new[] { nameof(MinValueDateTime), nameof(MinValueDecimal), nameof(MinValueInteger), nameof(MinValueQuantity) });
        }

        // Choice Type validation for minvalueinstant[x]
        var minvalueinstantProperties = new[] { nameof(MinValueInstant) };
        var minvalueinstantSetCount = minvalueinstantProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (minvalueinstantSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MinValueInstant may be specified",
                new[] { nameof(MinValueInstant) });
        }

        // Choice Type validation for minvaluetime[x]
        var minvaluetimeProperties = new[] { nameof(MinValueTime) };
        var minvaluetimeSetCount = minvaluetimeProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (minvaluetimeSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MinValueTime may be specified",
                new[] { nameof(MinValueTime) });
        }

        // Choice Type validation for minvalueinteger64[x]
        var minvalueinteger64Properties = new[] { nameof(MinValueInteger64) };
        var minvalueinteger64SetCount = minvalueinteger64Properties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (minvalueinteger64SetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MinValueInteger64 may be specified",
                new[] { nameof(MinValueInteger64) });
        }

        // Choice Type validation for minvaluepositiveint[x]
        var minvaluepositiveintProperties = new[] { nameof(MinValuePositiveInt) };
        var minvaluepositiveintSetCount = minvaluepositiveintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (minvaluepositiveintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MinValuePositiveInt may be specified",
                new[] { nameof(MinValuePositiveInt) });
        }

        // Choice Type validation for minvalueunsignedint[x]
        var minvalueunsignedintProperties = new[] { nameof(MinValueUnsignedInt) };
        var minvalueunsignedintSetCount = minvalueunsignedintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (minvalueunsignedintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MinValueUnsignedInt may be specified",
                new[] { nameof(MinValueUnsignedInt) });
        }

        // Choice Type validation for maxvaluedate[x]
        var maxvaluedateProperties = new[] { nameof(MaxValueDate) };
        var maxvaluedateSetCount = maxvaluedateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (maxvaluedateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MaxValueDate may be specified",
                new[] { nameof(MaxValueDate) });
        }

        // Choice Type validation for maxValue[x]
        var maxValueProperties = new[] { nameof(MaxValueDateTime), nameof(MaxValueDecimal), nameof(MaxValueInteger), nameof(MaxValueQuantity) };
        var maxValueSetCount = maxValueProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (maxValueSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MaxValueDateTime, MaxValueDecimal, MaxValueInteger, MaxValueQuantity may be specified",
                new[] { nameof(MaxValueDateTime), nameof(MaxValueDecimal), nameof(MaxValueInteger), nameof(MaxValueQuantity) });
        }

        // Choice Type validation for maxvalueinstant[x]
        var maxvalueinstantProperties = new[] { nameof(MaxValueInstant) };
        var maxvalueinstantSetCount = maxvalueinstantProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (maxvalueinstantSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MaxValueInstant may be specified",
                new[] { nameof(MaxValueInstant) });
        }

        // Choice Type validation for maxvaluetime[x]
        var maxvaluetimeProperties = new[] { nameof(MaxValueTime) };
        var maxvaluetimeSetCount = maxvaluetimeProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (maxvaluetimeSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MaxValueTime may be specified",
                new[] { nameof(MaxValueTime) });
        }

        // Choice Type validation for maxvalueinteger64[x]
        var maxvalueinteger64Properties = new[] { nameof(MaxValueInteger64) };
        var maxvalueinteger64SetCount = maxvalueinteger64Properties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (maxvalueinteger64SetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MaxValueInteger64 may be specified",
                new[] { nameof(MaxValueInteger64) });
        }

        // Choice Type validation for maxvaluepositiveint[x]
        var maxvaluepositiveintProperties = new[] { nameof(MaxValuePositiveInt) };
        var maxvaluepositiveintSetCount = maxvaluepositiveintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (maxvaluepositiveintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MaxValuePositiveInt may be specified",
                new[] { nameof(MaxValuePositiveInt) });
        }

        // Choice Type validation for maxvalueunsignedint[x]
        var maxvalueunsignedintProperties = new[] { nameof(MaxValueUnsignedInt) };
        var maxvalueunsignedintSetCount = maxvalueunsignedintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (maxvalueunsignedintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of MaxValueUnsignedInt may be specified",
                new[] { nameof(MaxValueUnsignedInt) });
        }

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate ElementDefinition cardinality
        var elementdefinitionCount = ElementDefinition?.Count ?? 0;
        if (elementdefinitionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition' cardinality must be 0..*", new[] { nameof(ElementDefinition) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Path == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.path' cardinality must be 1..1", new[] { nameof(Path) });
        }
        // Validate Representation cardinality
        var representationCount = Representation?.Count ?? 0;
        if (representationCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.representation' cardinality must be 0..*", new[] { nameof(Representation) });
        }
        // Validate Code cardinality
        var codeCount = Code?.Count ?? 0;
        if (codeCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.code' cardinality must be 0..*", new[] { nameof(Code) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.slicing.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Discriminator cardinality
        var discriminatorCount = Discriminator?.Count ?? 0;
        if (discriminatorCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.slicing.discriminator' cardinality must be 0..*", new[] { nameof(Discriminator) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.slicing.discriminator.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.slicing.discriminator.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        if (Path == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.slicing.discriminator.path' cardinality must be 1..1", new[] { nameof(Path) });
        }
        if (Rules == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.slicing.rules' cardinality must be 1..1", new[] { nameof(Rules) });
        }
        // Validate Alias cardinality
        var aliasCount = Alias?.Count ?? 0;
        if (aliasCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.alias' cardinality must be 0..*", new[] { nameof(Alias) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.base.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Path == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.base.path' cardinality must be 1..1", new[] { nameof(Path) });
        }
        if (Min == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.base.min' cardinality must be 1..1", new[] { nameof(Min) });
        }
        if (Max == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.base.max' cardinality must be 1..1", new[] { nameof(Max) });
        }
        // Validate Type cardinality
        var typeCount = Type?.Count ?? 0;
        if (typeCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.type' cardinality must be 0..*", new[] { nameof(Type) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.type.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.type.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Profile cardinality
        var profileCount = Profile?.Count ?? 0;
        if (profileCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.type.profile' cardinality must be 0..*", new[] { nameof(Profile) });
        }
        // Validate TargetProfile cardinality
        var targetprofileCount = TargetProfile?.Count ?? 0;
        if (targetprofileCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.type.targetProfile' cardinality must be 0..*", new[] { nameof(TargetProfile) });
        }
        // Validate Aggregation cardinality
        var aggregationCount = Aggregation?.Count ?? 0;
        if (aggregationCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.type.aggregation' cardinality must be 0..*", new[] { nameof(Aggregation) });
        }
        // Validate Example cardinality
        var exampleCount = Example?.Count ?? 0;
        if (exampleCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.example' cardinality must be 0..*", new[] { nameof(Example) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.example.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Label == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.example.label' cardinality must be 1..1", new[] { nameof(Label) });
        }
        if (Value == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.example.value[x]' cardinality must be 1..1", new[] { nameof(Value) });
        }
        // Validate Condition cardinality
        var conditionCount = Condition?.Count ?? 0;
        if (conditionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.condition' cardinality must be 0..*", new[] { nameof(Condition) });
        }
        // Validate Constraint cardinality
        var constraintCount = Constraint?.Count ?? 0;
        if (constraintCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.constraint' cardinality must be 0..*", new[] { nameof(Constraint) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.constraint.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Key == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.constraint.key' cardinality must be 1..1", new[] { nameof(Key) });
        }
        if (Severity == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.constraint.severity' cardinality must be 1..1", new[] { nameof(Severity) });
        }
        if (Human == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.constraint.human' cardinality must be 1..1", new[] { nameof(Human) });
        }
        // Validate ValueAlternatives cardinality
        var valuealternativesCount = ValueAlternatives?.Count ?? 0;
        if (valuealternativesCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.valueAlternatives' cardinality must be 0..*", new[] { nameof(ValueAlternatives) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.binding.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Strength == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.binding.strength' cardinality must be 1..1", new[] { nameof(Strength) });
        }
        // Validate Additional cardinality
        var additionalCount = Additional?.Count ?? 0;
        if (additionalCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.binding.additional' cardinality must be 0..*", new[] { nameof(Additional) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.binding.additional.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Purpose == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.binding.additional.purpose' cardinality must be 1..1", new[] { nameof(Purpose) });
        }
        if (ValueSet == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.binding.additional.valueSet' cardinality must be 1..1", new[] { nameof(ValueSet) });
        }
        // Validate Usage cardinality
        var usageCount = Usage?.Count ?? 0;
        if (usageCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.binding.additional.usage' cardinality must be 0..*", new[] { nameof(Usage) });
        }
        // Validate Mapping cardinality
        var mappingCount = Mapping?.Count ?? 0;
        if (mappingCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.mapping' cardinality must be 0..*", new[] { nameof(Mapping) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'ElementDefinition.mapping.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Identity == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.mapping.identity' cardinality must be 1..1", new[] { nameof(Identity) });
        }
        if (Map == null)
        {
            yield return new ValidationResult("Element 'ElementDefinition.mapping.map' cardinality must be 1..1", new[] { nameof(Map) });
        }

        // ValueSet binding validation
        // Validate Representation ValueSet binding
        if (Representation != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/property-representation|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/discriminator-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Rules ValueSet binding
        if (Rules != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/resource-slicing-rules|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Code ValueSet binding
        if (Code != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/elementdefinition-types
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Aggregation ValueSet binding
        if (Aggregation != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/resource-aggregation-mode|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Versioning ValueSet binding
        if (Versioning != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/reference-version-rules|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Severity ValueSet binding
        if (Severity != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/constraint-severity|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Strength ValueSet binding
        if (Strength != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/binding-strength|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Purpose ValueSet binding
        if (Purpose != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/additional-binding-purpose|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/mimetypes|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: eld-2
        // Expression: min.empty() or max.empty() or (max = '*') or iif(max != '*', min <= max.toInteger())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("min.empty() or max.empty() or (max = '*') or iif(max != '*', min <= max.toInteger())"))
        // {
        //     yield return new ValidationResult("Min <= Max", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-5
        // Expression: contentReference.empty() or (type.empty() and defaultValue.empty() and fixed.empty() and pattern.empty() and example.empty() and minValue.empty() and maxValue.empty() and maxLength.empty() and binding.empty())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contentReference.empty() or (type.empty() and defaultValue.empty() and fixed.empty() and pattern.empty() and example.empty() and minValue.empty() and maxValue.empty() and maxLength.empty() and binding.empty())"))
        // {
        //     yield return new ValidationResult("if the element definition has a contentReference, it cannot have type, defaultValue, fixed, pattern, example, minValue, maxValue, maxLength, or binding", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-6
        // Expression: fixed.empty() or (type.count()  <= 1)
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("fixed.empty() or (type.count()  <= 1)"))
        // {
        //     yield return new ValidationResult("Fixed value may only be specified if there is one type", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-7
        // Expression: pattern.empty() or (type.count() <= 1)
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("pattern.empty() or (type.count() <= 1)"))
        // {
        //     yield return new ValidationResult("Pattern may only be specified if there is one type", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-8
        // Expression: pattern.empty() or fixed.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("pattern.empty() or fixed.empty()"))
        // {
        //     yield return new ValidationResult("Pattern and fixed are mutually exclusive", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-11
        // Expression: binding.empty() or type.code.empty() or type.code.contains(":") or type.select((code = 'code') or (code = 'Coding') or (code='CodeableConcept') or (code = 'Quantity') or (code = 'string') or (code = 'uri') or (code = 'Duration')).exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("binding.empty() or type.code.empty() or type.code.contains(":") or type.select((code = 'code') or (code = 'Coding') or (code='CodeableConcept') or (code = 'Quantity') or (code = 'string') or (code = 'uri') or (code = 'Duration')).exists()"))
        // {
        //     yield return new ValidationResult("Binding can only be present for coded elements, string, and uri if using FHIR-defined types", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-13
        // Expression: type.select(code).isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("type.select(code).isDistinct()"))
        // {
        //     yield return new ValidationResult("Types must be unique by code", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-14
        // Expression: constraint.select(key).isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("constraint.select(key).isDistinct()"))
        // {
        //     yield return new ValidationResult("Constraints must be unique by key", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-15
        // Expression: defaultValue.empty() or meaningWhenMissing.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("defaultValue.empty() or meaningWhenMissing.empty()"))
        // {
        //     yield return new ValidationResult("default value and meaningWhenMissing are mutually exclusive", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-16
        // Expression: sliceName.empty() or sliceName.matches('^[a-zA-Z0-9\\/\\-_\\[\\]\\@]+$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("sliceName.empty() or sliceName.matches('^[a-zA-Z0-9\\/\\-_\\[\\]\\@]+$')"))
        // {
        //     yield return new ValidationResult("sliceName must be composed of proper tokens separated by "/"", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-18
        // Expression: (isModifier.exists() and isModifier) implies isModifierReason.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(isModifier.exists() and isModifier) implies isModifierReason.exists()"))
        // {
        //     yield return new ValidationResult("Must have a modifier reason if isModifier = true", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-19
        // Expression: path.matches('^[^\\s\\.,:;\\\'"\\/|?!@#$%&*()\\[\\]{}]{1,64}(\\.[^\\s\\.,:;\\\'"\\/|?!@#$%&*()\\[\\]{}]{1,64}(\\[x\\])?(\\:[^\\s\\.]+)?)*$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("path.matches('^[^\\s\\.,:;\\\'"\\/|?!@#$%&*()\\[\\]{}]{1,64}(\\.[^\\s\\.,:;\\\'"\\/|?!@#$%&*()\\[\\]{}]{1,64}(\\[x\\])?(\\:[^\\s\\.]+)?)*$')"))
        // {
        //     yield return new ValidationResult("Element path SHALL be expressed as a set of '.'-separated components with each component restricted to a maximum of 64 characters and with some limits on the allowed choice of characters", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-20
        // Expression: path.matches('^[A-Za-z][A-Za-z0-9]{0,63}(\\.[a-z][A-Za-z0-9]{0,63}(\\[x])?)*$')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("path.matches('^[A-Za-z][A-Za-z0-9]{0,63}(\\.[a-z][A-Za-z0-9]{0,63}(\\[x])?)*$')"))
        // {
        //     yield return new ValidationResult("The first component of the path should be UpperCamelCase.  Additional components (following a '.') should be lowerCamelCase.  If this syntax is not adhered to, code generation tools may be broken. Logical models may be less concerned about this implication.", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-22
        // Expression: sliceIsConstraining.exists() implies sliceName.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("sliceIsConstraining.exists() implies sliceName.exists()"))
        // {
        //     yield return new ValidationResult("sliceIsConstraining can only appear if slicename is present", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-24
        // Expression: fixed.exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("fixed.exists().not()"))
        // {
        //     yield return new ValidationResult("pattern[x] should be used rather than fixed[x]", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-25
        // Expression: orderMeaning.empty() implies slicing.where(rules='openAtEnd' or ordered).exists().not()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("orderMeaning.empty() implies slicing.where(rules='openAtEnd' or ordered).exists().not()"))
        // {
        //     yield return new ValidationResult("Order has no meaning (and cannot be asserted to have meaning), so enforcing rules on order is improper", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-27
        // Expression: mapping.select(identity).isDistinct()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("mapping.select(identity).isDistinct()"))
        // {
        //     yield return new ValidationResult("Mappings SHOULD be unique by key", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: eld-28
        // Expression: mustHaveValue.value implies valueAlternatives.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("mustHaveValue.value implies valueAlternatives.empty()"))
        // {
        //     yield return new ValidationResult("Can't have valueAlternatives if mustHaveValue is true", new[] { nameof(ElementDefinition) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ElementDefinition) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Representation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SliceName) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SliceIsConstraining) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Label) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Slicing) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Discriminator) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Description) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Ordered) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Rules) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Short) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Definition) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comment) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Requirements) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Alias) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Min) });
        // }
        // Constraint: eld-3
        // Expression: empty() or ($this = '*') or (toInteger() >= 0)
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("empty() or ($this = '*') or (toInteger() >= 0)"))
        // {
        //     yield return new ValidationResult("Max SHALL be a number or "*"", new[] { nameof(Max) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Max) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Base) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Path) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Min) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Max) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ContentReference) });
        // }
        // Constraint: eld-4
        // Expression: aggregation.empty() or (code = 'Reference') or (code = 'canonical') or (code = 'CodeableReference')
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("aggregation.empty() or (code = 'Reference') or (code = 'canonical') or (code = 'CodeableReference')"))
        // {
        //     yield return new ValidationResult("Aggregation may only be specified if one of the allowed types for the element is a reference", new[] { nameof(Type) });
        // }
        // Constraint: eld-17
        // Expression: (code='Reference' or code = 'canonical' or code = 'CodeableReference') or targetProfile.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(code='Reference' or code = 'canonical' or code = 'CodeableReference') or targetProfile.empty()"))
        // {
        //     yield return new ValidationResult("targetProfile is only allowed if the type is Reference or canonical", new[] { nameof(Type) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Profile) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(TargetProfile) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Aggregation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Versioning) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DefaultValue) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MeaningWhenMissing) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(OrderMeaning) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Fixed) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Pattern) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Example) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Label) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MinValue) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MaxValue) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MaxLength) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Condition) });
        // }
        // Constraint: eld-21
        // Expression: expression.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("expression.exists()"))
        // {
        //     yield return new ValidationResult("Constraints should have an expression or else validators will not be able to enforce them", new[] { nameof(Constraint) });
        // }
        // Constraint: eld-26
        // Expression: (severity = 'error') implies suppress.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(severity = 'error') implies suppress.empty()"))
        // {
        //     yield return new ValidationResult("Errors cannot be suppressed", new[] { nameof(Constraint) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Constraint) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Key) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Requirements) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Severity) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Suppress) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Human) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Expression) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Source) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MustHaveValue) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ValueAlternatives) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MustSupport) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IsModifier) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IsModifierReason) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(IsSummary) });
        // }
        // Constraint: eld-12
        // Expression: valueSet.exists() implies (valueSet.startsWith('http:') or valueSet.startsWith('https') or valueSet.startsWith('urn:') or valueSet.startsWith('#'))
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("valueSet.exists() implies (valueSet.startsWith('http:') or valueSet.startsWith('https') or valueSet.startsWith('urn:') or valueSet.startsWith('#'))"))
        // {
        //     yield return new ValidationResult("ValueSet SHALL start with http:// or https:// or urn: or #", new[] { nameof(Binding) });
        // }
        // Constraint: eld-23
        // Expression: description.exists() or valueSet.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("description.exists() or valueSet.exists()"))
        // {
        //     yield return new ValidationResult("binding SHALL have either description or valueSet", new[] { nameof(Binding) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Binding) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Strength) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Description) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ValueSet) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Additional) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Purpose) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ValueSet) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Documentation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ShortDoco) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Usage) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Any) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Mapping) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Identity) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Map) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Comment) });
        // }
    }

}
