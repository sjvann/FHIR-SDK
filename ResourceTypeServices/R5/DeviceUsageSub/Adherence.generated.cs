
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DeviceUsageSub
{
    public class Adherence : BackboneElement<Adherence>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("reason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Reason {get; set;}

        #endregion
        #region Constructor
        public  Adherence() { }
        public  Adherence(string value) : base(value) { }
        public  Adherence(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Adherence";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
