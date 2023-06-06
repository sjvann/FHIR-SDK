
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.AuditEventSub
{
    public class Outcome : BackboneElement<Outcome>
    {

        #region Property
        [Element("code", typeof(Coding), false, false, false, false)]
public Coding Code {get; set;}
[Element("detail", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Detail {get; set;}

        #endregion
        #region Constructor
        public  Outcome() { }
        public  Outcome(string value) : base(value) { }
        public  Outcome(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Outcome";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
