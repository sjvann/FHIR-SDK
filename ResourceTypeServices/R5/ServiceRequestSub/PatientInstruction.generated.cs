
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.ServiceRequestSub
{
    public class PatientInstruction : BackboneElement<PatientInstruction>
    {

        #region Property
        [Element("instruction", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Instruction {get; set;}

        #endregion
        #region Constructor
        public  PatientInstruction() { }
        public  PatientInstruction(string value) : base(value) { }
        public  PatientInstruction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PatientInstruction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
