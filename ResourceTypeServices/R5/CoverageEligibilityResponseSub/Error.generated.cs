
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CoverageEligibilityResponseSub
{
    public class Error : BackboneElement<Error>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("expression", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Expression {get; set;}

        #endregion
        #region Constructor
        public  Error() { }
        public  Error(string value) : base(value) { }
        public  Error(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Error";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
