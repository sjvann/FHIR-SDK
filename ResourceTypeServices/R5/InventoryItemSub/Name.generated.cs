
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InventoryItemSub
{
    public class Name : BackboneElement<Name>
    {

        #region Property
        [Element("nameType", typeof(Coding), false, false, false, false)]
public Coding NameType {get; set;}
[Element("language", typeof(FhirCode), true, false, false, false)]
public FhirCode Language {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString NameProp {get; set;}

        #endregion
        #region Constructor
        public  Name() { }
        public  Name(string value) : base(value) { }
        public  Name(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Name";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
