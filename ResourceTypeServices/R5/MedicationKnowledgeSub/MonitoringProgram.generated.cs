
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class MonitoringProgram : BackboneElement<MonitoringProgram>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}

        #endregion
        #region Constructor
        public  MonitoringProgram() { }
        public  MonitoringProgram(string value) : base(value) { }
        public  MonitoringProgram(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MonitoringProgram";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
