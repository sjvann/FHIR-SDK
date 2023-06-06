
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.QuestionnaireSub.ItemSub
{
    public class EnableWhen : BackboneElement<EnableWhen>
    {

        #region Property
        [Element("question", typeof(FhirString), true, false, false, false)]
public FhirString Question {get; set;}
[Element("operator", typeof(FhirCode), true, false, false, false)]
public FhirCode Operator {get; set;}
[Element("answer", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Answer {get; set;}

        #endregion
        #region Constructor
        public  EnableWhen() { }
        public  EnableWhen(string value) : base(value) { }
        public  EnableWhen(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "EnableWhen";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
