
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EpisodeOfCareSub
{
    public class StatusHistory : BackboneElement<StatusHistory>
    {

        #region Property
        [Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  StatusHistory() { }
        public  StatusHistory(string value) : base(value) { }
        public  StatusHistory(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "StatusHistory";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
