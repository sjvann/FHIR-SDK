
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ClaimSub
{
    public class Payee : BackboneElement<Payee>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("party", typeof(Reference), false, false, false, false)]
public Reference Party {get; set;}

        #endregion
        #region Constructor
        public  Payee() { }
        public  Payee(string value) : base(value) { }
        public  Payee(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Payee";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
