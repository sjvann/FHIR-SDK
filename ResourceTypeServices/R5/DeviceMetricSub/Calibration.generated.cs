
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceMetricSub
{
    public class Calibration : BackboneElement<Calibration>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("state", typeof(FhirCode), true, false, false, false)]
public FhirCode State {get; set;}
[Element("time", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Time {get; set;}

        #endregion
        #region Constructor
        public  Calibration() { }
        public  Calibration(string value) : base(value) { }
        public  Calibration(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Calibration";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
