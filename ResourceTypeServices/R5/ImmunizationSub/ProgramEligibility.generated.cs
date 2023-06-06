
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ImmunizationSub
{
    public class ProgramEligibility : BackboneElement<ProgramEligibility>
    {

        #region Property
        [Element("program", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Program {get; set;}
[Element("programStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProgramStatus {get; set;}

        #endregion
        #region Constructor
        public  ProgramEligibility() { }
        public  ProgramEligibility(string value) : base(value) { }
        public  ProgramEligibility(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ProgramEligibility";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
