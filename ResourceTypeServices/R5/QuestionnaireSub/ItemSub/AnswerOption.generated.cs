
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.QuestionnaireSub.ItemSub
{
    public class AnswerOption : BackboneElement<AnswerOption>
    {

        #region Property
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}
[Element("initialSelected", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean InitialSelected {get; set;}

        #endregion
        #region Constructor
        public  AnswerOption() { }
        public  AnswerOption(string value) : base(value) { }
        public  AnswerOption(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "AnswerOption";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
