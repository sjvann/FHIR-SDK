
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ValueSetSub.ExpansionSub.ContainsSub.PropertySub
{
    public class SubProperty : BackboneElement<SubProperty>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  SubProperty() { }
        public  SubProperty(string value) : base(value) { }
        public  SubProperty(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SubProperty";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
