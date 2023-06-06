
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.QuestionnaireResponseSub.ItemSub
{
    public class Answer : BackboneElement<Answer>
    {

        #region Property
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  Answer() { }
        public  Answer(string value) : base(value) { }
        public  Answer(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Answer";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
