
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.EvidenceReportSub.RelatesToSub;

namespace ResourceTypeServices.R5.EvidenceReportSub
{
    public class RelatesTo : BackboneElement<RelatesTo>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("target", typeof(Target), false, false, false, true)]
public Target Target {get; set;}

        #endregion
        #region Constructor
        public  RelatesTo() { }
        public  RelatesTo(string value) : base(value) { }
        public  RelatesTo(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RelatesTo";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
