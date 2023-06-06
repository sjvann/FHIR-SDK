
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.FamilyMemberHistorySub
{
    public class Participant : BackboneElement<Participant>
    {

        #region Property
        [Element("function", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Function {get; set;}
[Element("actor", typeof(Reference), false, false, false, false)]
public Reference Actor {get; set;}

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
