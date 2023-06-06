
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConceptMapSub.GroupSub.ElementSub.TargetSub
{
    public class Property : BackboneElement<Property>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

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
