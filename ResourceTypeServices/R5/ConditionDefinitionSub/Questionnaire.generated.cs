
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConditionDefinitionSub
{
    public class Questionnaire : BackboneElement<Questionnaire>
    {

        #region Property
        [Element("purpose", typeof(FhirCode), true, false, false, false)]
public FhirCode Purpose {get; set;}
[Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}

        #endregion
        #region Constructor
        public  Questionnaire() { }
        public  Questionnaire(string value) : base(value) { }
        public  Questionnaire(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Questionnaire";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
