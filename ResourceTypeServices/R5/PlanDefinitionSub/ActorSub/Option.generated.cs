
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PlanDefinitionSub.ActorSub
{
    public class Option : BackboneElement<Option>
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

        #endregion
        #region Constructor
        public  Option() { }
        public  Option(string value) : base(value) { }
        public  Option(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Option";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
