

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConditionDefinitionSub
{
    public class ConditionDefinition : DomainResource<ConditionDefinition>
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
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("severity", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Severity {get; set;}
[Element("bodySite", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept BodySite {get; set;}
[Element("stage", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Stage {get; set;}
[Element("hasSeverity", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean HasSeverity {get; set;}
[Element("hasBodySite", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean HasBodySite {get; set;}
[Element("hasStage", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean HasStage {get; set;}
[Element("definition", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> Definition {get; set;}
[Element("observation", typeof(Observation), false, true, false, true)]
public IEnumerable<Observation> Observation {get; set;}
[Element("medication", typeof(Medication), false, true, false, true)]
public IEnumerable<Medication> Medication {get; set;}
[Element("precondition", typeof(Precondition), false, true, false, true)]
public IEnumerable<Precondition> Precondition {get; set;}
[Element("team", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Team {get; set;}
[Element("questionnaire", typeof(Questionnaire), false, true, false, true)]
public IEnumerable<Questionnaire> Questionnaire {get; set;}
[Element("plan", typeof(Plan), false, true, false, true)]
public IEnumerable<Plan> Plan {get; set;}

        #endregion
        #region Constructor
        public  ConditionDefinition() { }

        public  ConditionDefinition(string value) : base(value) { }
        public  ConditionDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ConditionDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
