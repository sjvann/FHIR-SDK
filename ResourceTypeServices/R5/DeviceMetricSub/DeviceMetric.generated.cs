

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceMetricSub
{
    public class DeviceMetric : DomainResource<DeviceMetric>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("unit", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Unit {get; set;}
[Element("device", typeof(Reference), false, false, false, false)]
public Reference Device {get; set;}
[Element("operationalStatus", typeof(FhirCode), true, false, false, false)]
public FhirCode OperationalStatus {get; set;}
[Element("color", typeof(FhirCode), true, false, false, false)]
public FhirCode Color {get; set;}
[Element("category", typeof(FhirCode), true, false, false, false)]
public FhirCode Category {get; set;}
[Element("measurementFrequency", typeof(Quantity), false, false, false, false)]
public Quantity MeasurementFrequency {get; set;}
[Element("calibration", typeof(Calibration), false, true, false, true)]
public IEnumerable<Calibration> Calibration {get; set;}

        #endregion
        #region Constructor
        public  DeviceMetric() { }

        public  DeviceMetric(string value) : base(value) { }
        public  DeviceMetric(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DeviceMetric";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
