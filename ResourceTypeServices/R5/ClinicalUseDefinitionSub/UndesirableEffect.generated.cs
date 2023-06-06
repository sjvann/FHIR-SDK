
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub
{
    public class UndesirableEffect : BackboneElement<UndesirableEffect>
    {

        #region Property
        [Element("symptomConditionEffect", typeof(CodeableReference), false, false, false, false)]
public CodeableReference SymptomConditionEffect {get; set;}
[Element("classification", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Classification {get; set;}
[Element("frequencyOfOccurrence", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FrequencyOfOccurrence {get; set;}

        #endregion
        #region Constructor
        public  UndesirableEffect() { }
        public  UndesirableEffect(string value) : base(value) { }
        public  UndesirableEffect(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "UndesirableEffect";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
