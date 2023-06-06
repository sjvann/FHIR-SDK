

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ActivityDefinitionSub
{
    public class ActivityDefinition : DomainResource<ActivityDefinition>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("versionAlgorithm", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased VersionAlgorithm {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("subtitle", typeof(FhirString), true, false, false, false)]
public FhirString Subtitle {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
[Element("subject", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Subject {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("publisher", typeof(FhirString), true, false, false, false)]
public FhirString Publisher {get; set;}
[Element("contact", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Contact {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("jurisdiction", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Jurisdiction {get; set;}
[Element("purpose", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Purpose {get; set;}
[Element("usage", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Usage {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}
[Element("copyrightLabel", typeof(FhirString), true, false, false, false)]
public FhirString CopyrightLabel {get; set;}
[Element("approvalDate", typeof(FhirDate), true, false, false, false)]
public FhirDate ApprovalDate {get; set;}
[Element("lastReviewDate", typeof(FhirDate), true, false, false, false)]
public FhirDate LastReviewDate {get; set;}
[Element("effectivePeriod", typeof(Period), false, false, false, false)]
public Period EffectivePeriod {get; set;}
[Element("topic", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Topic {get; set;}
[Element("author", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Author {get; set;}
[Element("editor", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Editor {get; set;}
[Element("reviewer", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Reviewer {get; set;}
[Element("endorser", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Endorser {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatedArtifact {get; set;}
[Element("library", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Library {get; set;}
[Element("kind", typeof(FhirCode), true, false, false, false)]
public FhirCode Kind {get; set;}
[Element("profile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Profile {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("intent", typeof(FhirCode), true, false, false, false)]
public FhirCode Intent {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("doNotPerform", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean DoNotPerform {get; set;}
[Element("timing", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Timing {get; set;}
[Element("asNeeded", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased AsNeeded {get; set;}
[Element("location", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Location {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("product", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Product {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("dosage", typeof(Dosage), false, true, false, false)]
public IEnumerable<Dosage> Dosage {get; set;}
[Element("bodySite", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> BodySite {get; set;}
[Element("specimenRequirement", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> SpecimenRequirement {get; set;}
[Element("observationRequirement", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> ObservationRequirement {get; set;}
[Element("observationResultRequirement", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> ObservationResultRequirement {get; set;}
[Element("transform", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Transform {get; set;}
[Element("dynamicValue", typeof(DynamicValue), false, true, false, true)]
public IEnumerable<DynamicValue> DynamicValue {get; set;}

        #endregion
        #region Constructor
        public  ActivityDefinition() { }

        public  ActivityDefinition(string value) : base(value) { }
        public  ActivityDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ActivityDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
