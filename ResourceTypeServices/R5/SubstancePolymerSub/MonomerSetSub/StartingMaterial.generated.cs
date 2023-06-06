
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstancePolymerSub.MonomerSetSub
{
    public class StartingMaterial : BackboneElement<StartingMaterial>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("isDefining", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsDefining {get; set;}
[Element("amount", typeof(Quantity), false, false, false, false)]
public Quantity Amount {get; set;}

        #endregion
        #region Constructor
        public  StartingMaterial() { }
        public  StartingMaterial(string value) : base(value) { }
        public  StartingMaterial(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "StartingMaterial";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
