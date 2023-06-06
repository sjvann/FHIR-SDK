
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceVariableSub
{
    public class Category : BackboneElement<Category>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  Category() { }
        public  Category(string value) : base(value) { }
        public  Category(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Category";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
