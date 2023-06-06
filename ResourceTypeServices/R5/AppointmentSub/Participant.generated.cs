
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AppointmentSub
{
    public class Participant : BackboneElement<Participant>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("actor", typeof(Reference), false, false, false, false)]
public Reference Actor {get; set;}
[Element("required", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Required {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}

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
