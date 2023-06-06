
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConsentSub
{
    public class PolicyBasis : BackboneElement<PolicyBasis>
    {

        #region Property
        [Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}
[Element("url", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Url {get; set;}

        #endregion
        #region Constructor
        public  PolicyBasis() { }
        public  PolicyBasis(string value) : base(value) { }
        public  PolicyBasis(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PolicyBasis";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
