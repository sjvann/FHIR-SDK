
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ResearchStudySub
{
    public class ProgressStatus : BackboneElement<ProgressStatus>
    {

        #region Property
        [Element("state", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept State {get; set;}
[Element("actual", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Actual {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  ProgressStatus() { }
        public  ProgressStatus(string value) : base(value) { }
        public  ProgressStatus(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ProgressStatus";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
