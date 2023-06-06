
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureMapSub.GroupSub
{
    public class Input : BackboneElement<Input>
    {

        #region Property
        [Element("name", typeof(FhirId), true, false, false, false)]
public FhirId Name {get; set;}
[Element("type", typeof(FhirString), true, false, false, false)]
public FhirString Type {get; set;}
[Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("documentation", typeof(FhirString), true, false, false, false)]
public FhirString Documentation {get; set;}

        #endregion
        #region Constructor
        public  Input() { }
        public  Input(string value) : base(value) { }
        public  Input(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Input";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
