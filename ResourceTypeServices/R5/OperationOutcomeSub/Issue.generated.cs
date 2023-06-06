
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.OperationOutcomeSub
{
    public class Issue : BackboneElement<Issue>
    {

        #region Property
        [Element("severity", typeof(FhirCode), true, false, false, false)]
public FhirCode Severity {get; set;}
[Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("details", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Details {get; set;}
[Element("diagnostics", typeof(FhirString), true, false, false, false)]
public FhirString Diagnostics {get; set;}
[Element("location", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Location {get; set;}
[Element("expression", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Expression {get; set;}

        #endregion
        #region Constructor
        public  Issue() { }
        public  Issue(string value) : base(value) { }
        public  Issue(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Issue";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
