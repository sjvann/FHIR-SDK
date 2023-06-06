
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.AccountSub
{
    public class RelatedAccount : BackboneElement<RelatedAccount>
    {

        #region Property
        [Element("relationship", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Relationship {get; set;}
[Element("account", typeof(Reference), false, false, false, false)]
public Reference Account {get; set;}

        #endregion
        #region Constructor
        public  RelatedAccount() { }
        public  RelatedAccount(string value) : base(value) { }
        public  RelatedAccount(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RelatedAccount";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
