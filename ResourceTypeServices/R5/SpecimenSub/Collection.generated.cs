
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SpecimenSub
{
    public class Collection : BackboneElement<Collection>
    {

        #region Property
        [Element("collector", typeof(Reference), false, false, false, false)]
public Reference Collector {get; set;}
[Element("collected", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Collected {get; set;}
[Element("duration", typeof(Duration), false, false, false, false)]
public Duration Duration {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("method", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Method {get; set;}
[Element("device", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Device {get; set;}
[Element("procedure", typeof(Reference), false, false, false, false)]
public Reference Procedure {get; set;}
[Element("bodySite", typeof(CodeableReference), false, false, false, false)]
public CodeableReference BodySite {get; set;}
[Element("fastingStatus", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased FastingStatus {get; set;}

        #endregion
        #region Constructor
        public  Collection() { }
        public  Collection(string value) : base(value) { }
        public  Collection(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Collection";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
