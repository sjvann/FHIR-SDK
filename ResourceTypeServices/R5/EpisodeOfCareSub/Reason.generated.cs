
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.EpisodeOfCareSub
{
    public class Reason : BackboneElement<Reason>
    {

        #region Property
        [Element("use", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Use {get; set;}
[Element("value", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Value {get; set;}

        #endregion
        #region Constructor
        public  Reason() { }
        public  Reason(string value) : base(value) { }
        public  Reason(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Reason";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
