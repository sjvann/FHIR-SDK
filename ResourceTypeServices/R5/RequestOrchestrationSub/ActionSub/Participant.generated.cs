
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RequestOrchestrationSub.ActionSub
{
    public class Participant : BackboneElement<Participant>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("typeCanonical", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical TypeCanonical {get; set;}
[Element("typeReference", typeof(Reference), false, false, false, false)]
public Reference TypeReference {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("function", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Function {get; set;}
[Element("actor", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Actor {get; set;}

        #endregion
        #region Constructor
        public  Participant() { }
        public  Participant(string value) : base(value) { }
        public  Participant(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Participant";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
