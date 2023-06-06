
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.RegulatedAuthorizationSub
{
    public class Case : BackboneElement<Case>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("date", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Date {get; set;}

        #endregion
        #region Constructor
        public  Case() { }
        public  Case(string value) : base(value) { }
        public  Case(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Case";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
