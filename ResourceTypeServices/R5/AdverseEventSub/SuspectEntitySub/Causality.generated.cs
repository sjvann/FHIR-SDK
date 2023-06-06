
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.AdverseEventSub.SuspectEntitySub
{
    public class Causality : BackboneElement<Causality>
    {

        #region Property
        [Element("assessmentMethod", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AssessmentMethod {get; set;}
[Element("entityRelatedness", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept EntityRelatedness {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}

        #endregion
        #region Constructor
        public  Causality() { }
        public  Causality(string value) : base(value) { }
        public  Causality(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Causality";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
