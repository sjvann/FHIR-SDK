
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.PackagedProductDefinitionSub.PackagingSub
{
    public class ContainedItem : BackboneElement<ContainedItem>
    {

        #region Property
        [Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Item {get; set;}
[Element("amount", typeof(Quantity), false, false, false, false)]
public Quantity Amount {get; set;}

        #endregion
        #region Constructor
        public  ContainedItem() { }
        public  ContainedItem(string value) : base(value) { }
        public  ContainedItem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ContainedItem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
