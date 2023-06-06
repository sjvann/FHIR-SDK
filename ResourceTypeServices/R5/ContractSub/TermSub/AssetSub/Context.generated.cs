
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ContractSub.TermSub.AssetSub
{
    public class Context : BackboneElement<Context>
    {

        #region Property
        [Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}
[Element("code", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Code {get; set;}

        #endregion
        #region Constructor
        public  Context() { }
        public  Context(string value) : base(value) { }
        public  Context(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Context";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
