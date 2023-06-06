
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.MedicationKnowledgeSub.IndicationGuidelineSub;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class IndicationGuideline : BackboneElement<IndicationGuideline>
    {

        #region Property
        [Element("indication", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Indication {get; set;}
[Element("dosingGuideline", typeof(DosingGuideline), false, true, false, true)]
public IEnumerable<DosingGuideline> DosingGuideline {get; set;}

        #endregion
        #region Constructor
        public  IndicationGuideline() { }
        public  IndicationGuideline(string value) : base(value) { }
        public  IndicationGuideline(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "IndicationGuideline";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
