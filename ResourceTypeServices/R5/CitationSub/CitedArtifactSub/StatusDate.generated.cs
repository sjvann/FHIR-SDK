
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class StatusDate : BackboneElement<StatusDate>
    {

        #region Property
        [Element("activity", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Activity {get; set;}
[Element("actual", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Actual {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  StatusDate() { }
        public  StatusDate(string value) : base(value) { }
        public  StatusDate(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "StatusDate";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
