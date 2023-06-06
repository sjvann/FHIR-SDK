

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ObservationDefinitionSub
{
    public class ObservationDefinition : DomainResource<ObservationDefinition>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("versionAlgorithm", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased VersionAlgorithm {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
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
[Element("derivedFromCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> DerivedFromCanonical {get; set;}
[Element("derivedFromUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> DerivedFromUri {get; set;}
[Element("subject", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Subject {get; set;}
[Element("performerType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PerformerType {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("permittedDataType", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> PermittedDataType {get; set;}
[Element("multipleResultsAllowed", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean MultipleResultsAllowed {get; set;}
[Element("bodySite", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept BodySite {get; set;}
[Element("method", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Method {get; set;}
[Element("specimen", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Specimen {get; set;}
[Element("device", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Device {get; set;}
[Element("preferredReportName", typeof(FhirString), true, false, false, false)]
public FhirString PreferredReportName {get; set;}
[Element("permittedUnit", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> PermittedUnit {get; set;}
[Element("qualifiedValue", typeof(QualifiedValue), false, true, false, true)]
public IEnumerable<QualifiedValue> QualifiedValue {get; set;}
[Element("hasMember", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> HasMember {get; set;}
[Element("component", typeof(Component), false, true, false, true)]
public IEnumerable<Component> Component {get; set;}

        #endregion
        #region Constructor
        public  ObservationDefinition() { }

        public  ObservationDefinition(string value) : base(value) { }
        public  ObservationDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ObservationDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
