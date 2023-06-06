
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.QuestionnaireSub.ItemSub;

namespace ResourceTypeServices.R5.QuestionnaireSub
{
    public class Item : BackboneElement<Item>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("definition", typeof(FhirUri), true, false, false, false)]
public FhirUri Definition {get; set;}
[Element("code", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> Code {get; set;}
[Element("prefix", typeof(FhirString), true, false, false, false)]
public FhirString Prefix {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("enableWhen", typeof(EnableWhen), false, true, false, true)]
public IEnumerable<EnableWhen> EnableWhen {get; set;}
[Element("enableBehavior", typeof(FhirCode), true, false, false, false)]
public FhirCode EnableBehavior {get; set;}
[Element("disabledDisplay", typeof(FhirCode), true, false, false, false)]
public FhirCode DisabledDisplay {get; set;}
[Element("required", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Required {get; set;}
[Element("repeats", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Repeats {get; set;}
[Element("readOnly", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean ReadOnly {get; set;}
[Element("maxLength", typeof(FhirInteger), true, false, false, false)]
public FhirInteger MaxLength {get; set;}
[Element("answerConstraint", typeof(FhirCode), true, false, false, false)]
public FhirCode AnswerConstraint {get; set;}
[Element("answerValueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical AnswerValueSet {get; set;}
[Element("answerOption", typeof(AnswerOption), false, true, false, true)]
public IEnumerable<AnswerOption> AnswerOption {get; set;}
[Element("initial", typeof(Initial), false, true, false, true)]
public IEnumerable<Initial> Initial {get; set;}

        #endregion
        #region Constructor
        public  Item() { }
        public  Item(string value) : base(value) { }
        public  Item(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Item";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
