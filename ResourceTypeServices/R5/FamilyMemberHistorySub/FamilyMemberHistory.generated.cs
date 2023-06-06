

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.FamilyMemberHistorySub
{
    public class FamilyMemberHistory : DomainResource<FamilyMemberHistory>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> InstantiatesUri {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("dataAbsentReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DataAbsentReason {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("relationship", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Relationship {get; set;}
[Element("sex", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Sex {get; set;}
[Element("born", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Born {get; set;}
[Element("age", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Age {get; set;}
[Element("estimatedAge", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean EstimatedAge {get; set;}
[Element("deceased", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Deceased {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("condition", typeof(Condition), false, true, false, true)]
public IEnumerable<Condition> Condition {get; set;}
[Element("procedure", typeof(Procedure), false, true, false, true)]
public IEnumerable<Procedure> Procedure {get; set;}

        #endregion
        #region Constructor
        public  FamilyMemberHistory() { }

        public  FamilyMemberHistory(string value) : base(value) { }
        public  FamilyMemberHistory(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "FamilyMemberHistory";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
