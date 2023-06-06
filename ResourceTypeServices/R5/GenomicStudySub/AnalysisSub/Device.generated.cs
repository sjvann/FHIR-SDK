
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.GenomicStudySub.AnalysisSub
{
    public class Device : BackboneElement<Device>
    {

        #region Property
        [Element("device", typeof(Reference), false, false, false, false)]
public Reference DeviceProp {get; set;}
[Element("function", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Function {get; set;}

        #endregion
        #region Constructor
        public  Device() { }
        public  Device(string value) : base(value) { }
        public  Device(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Device";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
