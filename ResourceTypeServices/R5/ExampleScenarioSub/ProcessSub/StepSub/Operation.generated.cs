
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExampleScenarioSub.ProcessSub.StepSub
{
    public class Operation : BackboneElement<Operation>
    {

        #region Property
        [Element("type", typeof(Coding), false, false, false, false)]
public Coding Type {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("initiator", typeof(FhirString), true, false, false, false)]
public FhirString Initiator {get; set;}
[Element("receiver", typeof(FhirString), true, false, false, false)]
public FhirString Receiver {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("initiatorActive", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean InitiatorActive {get; set;}
[Element("receiverActive", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ReceiverActive {get; set;}

        #endregion
        #region Constructor
        public  Operation() { }
        public  Operation(string value) : base(value) { }
        public  Operation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Operation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
