
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DiagnosticReportSub
{
    public class SupportingInfo : BackboneElement<SupportingInfo>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}

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
