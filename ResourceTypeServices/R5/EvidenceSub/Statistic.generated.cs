
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.EvidenceSub.StatisticSub;

namespace ResourceTypeServices.R5.EvidenceSub
{
    public class Statistic : BackboneElement<Statistic>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("statisticType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept StatisticType {get; set;}
[Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("numberOfEvents", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberOfEvents {get; set;}
[Element("numberAffected", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberAffected {get; set;}
[Element("sampleSize", typeof(SampleSize), false, false, false, true)]
public SampleSize SampleSize {get; set;}
[Element("attributeEstimate", typeof(AttributeEstimate), false, true, false, true)]
public IEnumerable<AttributeEstimate> AttributeEstimate {get; set;}
[Element("modelCharacteristic", typeof(ModelCharacteristic), false, true, false, true)]
public IEnumerable<ModelCharacteristic> ModelCharacteristic {get; set;}

        #endregion
        #region Constructor
        public  Statistic() { }
        public  Statistic(string value) : base(value) { }
        public  Statistic(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Statistic";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
