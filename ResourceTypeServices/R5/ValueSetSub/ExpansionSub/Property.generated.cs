
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ValueSetSub.ExpansionSub
{
    public class Property : BackboneElement<Property>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("uri", typeof(FhirUri), true, false, false, false)]
public FhirUri Uri {get; set;}

        #endregion
        #region Constructor
        public  Property() { }
        public  Property(string value) : base(value) { }
        public  Property(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Property";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
