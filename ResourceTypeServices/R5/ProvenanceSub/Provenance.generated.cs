

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ProvenanceSub
{
    public class Provenance : DomainResource<Provenance>
    {
        #region Property
        [Element("target", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Target {get; set;}
[Element("occurred", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurred {get; set;}
[Element("recorded", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Recorded {get; set;}
[Element("policy", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> Policy {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("authorization", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Authorization {get; set;}
[Element("activity", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Activity {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("agent", typeof(Agent), false, true, false, true)]
public IEnumerable<Agent> Agent {get; set;}
[Element("entity", typeof(Entity), false, true, false, true)]
public IEnumerable<Entity> Entity {get; set;}
[Element("signature", typeof(Signature), false, true, false, false)]
public IEnumerable<Signature> Signature {get; set;}

        #endregion
        #region Constructor
        public  Provenance() { }

        public  Provenance(string value) : base(value) { }
        public  Provenance(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Provenance";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
