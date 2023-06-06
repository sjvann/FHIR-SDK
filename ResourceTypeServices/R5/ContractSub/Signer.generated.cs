
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ContractSub
{
    public class Signer : BackboneElement<Signer>
    {

        #region Property
        [Element("type", typeof(Coding), false, false, false, false)]
public Coding Type {get; set;}
[Element("party", typeof(Reference), false, false, false, false)]
public Reference Party {get; set;}
[Element("signature", typeof(Signature), false, true, false, false)]
public IEnumerable<Signature> Signature {get; set;}

        #endregion
        #region Constructor
        public  Signer() { }
        public  Signer(string value) : base(value) { }
        public  Signer(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Signer";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
