
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AccountSub
{
    public class Guarantor : BackboneElement<Guarantor>
    {

        #region Property
        [Element("party", typeof(Reference), false, false, false, false)]
public Reference Party {get; set;}
[Element("onHold", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean OnHold {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  Guarantor() { }
        public  Guarantor(string value) : base(value) { }
        public  Guarantor(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Guarantor";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
