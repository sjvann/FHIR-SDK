
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class HasPart : BackboneElement<HasPart>
    {

        #region Property
        [Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}
[Element("count", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Count {get; set;}

        #endregion
        #region Constructor
        public  HasPart() { }
        public  HasPart(string value) : base(value) { }
        public  HasPart(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "HasPart";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
