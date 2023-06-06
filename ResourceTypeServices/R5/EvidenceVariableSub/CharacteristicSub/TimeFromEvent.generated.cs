
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceVariableSub.CharacteristicSub
{
    public class TimeFromEvent : BackboneElement<TimeFromEvent>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("event", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Event {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("range", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range Range {get; set;}

        #endregion
        #region Constructor
        public  TimeFromEvent() { }
        public  TimeFromEvent(string value) : base(value) { }
        public  TimeFromEvent(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "TimeFromEvent";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
