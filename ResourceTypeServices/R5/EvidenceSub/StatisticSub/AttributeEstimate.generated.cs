
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceSub.StatisticSub
{
    public class AttributeEstimate : BackboneElement<AttributeEstimate>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("level", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Level {get; set;}
[Element("range", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range Range {get; set;}

        #endregion
        #region Constructor
        public  AttributeEstimate() { }
        public  AttributeEstimate(string value) : base(value) { }
        public  AttributeEstimate(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "AttributeEstimate";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
