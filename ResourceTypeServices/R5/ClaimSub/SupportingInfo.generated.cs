
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClaimSub
{
    public class SupportingInfo : BackboneElement<SupportingInfo>
    {

        #region Property
        [Element("sequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Sequence {get; set;}
[Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("timing", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Timing {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}
[Element("reason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Reason {get; set;}

        #endregion
        #region Constructor
        public  SupportingInfo() { }
        public  SupportingInfo(string value) : base(value) { }
        public  SupportingInfo(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SupportingInfo";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
