

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TaskSub
{
    public class Task : DomainResource<Task>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, false, false, false)]
public FhirUri InstantiatesUri {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("groupIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier GroupIdentifier {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusReason", typeof(CodeableReference), false, false, false, false)]
public CodeableReference StatusReason {get; set;}
[Element("businessStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept BusinessStatus {get; set;}
[Element("intent", typeof(FhirCode), true, false, false, false)]
public FhirCode Intent {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("doNotPerform", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean DoNotPerform {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("focus", typeof(Reference), false, false, false, false)]
public Reference Focus {get; set;}
[Element("for", typeof(Reference), false, false, false, false)]
public Reference For {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("requestedPeriod", typeof(Period), false, false, false, false)]
public Period RequestedPeriod {get; set;}
[Element("executionPeriod", typeof(Period), false, false, false, false)]
public Period ExecutionPeriod {get; set;}
[Element("authoredOn", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime AuthoredOn {get; set;}
[Element("lastModified", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime LastModified {get; set;}
[Element("requester", typeof(Reference), false, false, false, false)]
public Reference Requester {get; set;}
[Element("requestedPerformer", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> RequestedPerformer {get; set;}
[Element("owner", typeof(Reference), false, false, false, false)]
public Reference Owner {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("insurance", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Insurance {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("relevantHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> RelevantHistory {get; set;}
[Element("restriction", typeof(Restriction), false, false, false, true)]
public Restriction Restriction {get; set;}
[Element("input", typeof(Input), false, true, false, true)]
public IEnumerable<Input> Input {get; set;}
[Element("output", typeof(Output), false, true, false, true)]
public IEnumerable<Output> Output {get; set;}

        #endregion
        #region Constructor
        public  Task() { }

        public  Task(string value) : base(value) { }
        public  Task(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Task";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
