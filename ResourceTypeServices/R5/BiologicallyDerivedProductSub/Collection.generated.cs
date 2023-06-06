
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.BiologicallyDerivedProductSub
{
    public class Collection : BackboneElement<Collection>
    {

        #region Property
        [Element("collector", typeof(Reference), false, false, false, false)]
public Reference Collector {get; set;}
[Element("source", typeof(Reference), false, false, false, false)]
public Reference Source {get; set;}
[Element("collected", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Collected {get; set;}

        #endregion
        #region Constructor
        public  Collection() { }
        public  Collection(string value) : base(value) { }
        public  Collection(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Collection";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
