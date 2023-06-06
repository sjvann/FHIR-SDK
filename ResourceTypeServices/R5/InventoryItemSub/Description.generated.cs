
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InventoryItemSub
{
    public class Description : BackboneElement<Description>
    {

        #region Property
        [Element("language", typeof(FhirCode), true, false, false, false)]
public FhirCode Language {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString DescriptionProp {get; set;}

        #endregion
        #region Constructor
        public  Description() { }
        public  Description(string value) : base(value) { }
        public  Description(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Description";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
