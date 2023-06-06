
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceSourceMaterialSub
{
    public class FractionDescription : BackboneElement<FractionDescription>
    {

        #region Property
        [Element("fraction", typeof(FhirString), true, false, false, false)]
public FhirString Fraction {get; set;}
[Element("materialType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept MaterialType {get; set;}

        #endregion
        #region Constructor
        public  FractionDescription() { }
        public  FractionDescription(string value) : base(value) { }
        public  FractionDescription(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "FractionDescription";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
