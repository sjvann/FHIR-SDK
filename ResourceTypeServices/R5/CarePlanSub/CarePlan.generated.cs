

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CarePlanSub
{
    public class CarePlan : DomainResource<CarePlan>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> InstantiatesUri {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("replaces", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Replaces {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("intent", typeof(FhirCode), true, false, false, false)]
public FhirCode Intent {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("custodian", typeof(Reference), false, false, false, false)]
public Reference Custodian {get; set;}
[Element("contributor", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Contributor {get; set;}
[Element("careTeam", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> CareTeam {get; set;}
[Element("addresses", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Addresses {get; set;}
[Element("supportingInfo", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInfo {get; set;}
[Element("goal", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Goal {get; set;}
[Element("activity", typeof(Activity), false, true, false, true)]
public IEnumerable<Activity> Activity {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  CarePlan() { }

        public  CarePlan(string value) : base(value) { }
        public  CarePlan(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "CarePlan";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
