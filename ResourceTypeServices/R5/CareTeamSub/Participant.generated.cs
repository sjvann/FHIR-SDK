
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CareTeamSub
{
    public class Participant : BackboneElement<Participant>
    {

        #region Property
        [Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("member", typeof(Reference), false, false, false, false)]
public Reference Member {get; set;}
[Element("onBehalfOf", typeof(Reference), false, false, false, false)]
public Reference OnBehalfOf {get; set;}
[Element("coverage", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Coverage {get; set;}

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
