
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub.RestSub
{
    public class Security : BackboneElement<Security>
    {

        #region Property
        [Element("cors", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Cors {get; set;}
[Element("service", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Service {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}

        #endregion
        #region Constructor
        public  Security() { }
        public  Security(string value) : base(value) { }
        public  Security(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Security";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
