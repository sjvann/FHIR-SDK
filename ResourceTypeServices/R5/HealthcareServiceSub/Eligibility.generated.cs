
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.HealthcareServiceSub
{
    public class Eligibility : BackboneElement<Eligibility>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("comment", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Comment {get; set;}

        #endregion
        #region Constructor
        public  Eligibility() { }
        public  Eligibility(string value) : base(value) { }
        public  Eligibility(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Eligibility";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
