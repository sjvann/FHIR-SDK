
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceSourceMaterialSub
{
    public class PartDescription : BackboneElement<PartDescription>
    {

        #region Property
        [Element("part", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Part {get; set;}
[Element("partLocation", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PartLocation {get; set;}

        #endregion
        #region Constructor
        public  PartDescription() { }
        public  PartDescription(string value) : base(value) { }
        public  PartDescription(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PartDescription";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
