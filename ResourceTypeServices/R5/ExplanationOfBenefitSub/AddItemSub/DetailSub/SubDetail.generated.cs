
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub.AddItemSub.DetailSub
{
    public class SubDetail : BackboneElement<SubDetail>
    {

        #region Property
        [Element("traceNumber", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> TraceNumber {get; set;}
[Element("revenue", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Revenue {get; set;}
[Element("productOrService", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProductOrService {get; set;}
[Element("productOrServiceEnd", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProductOrServiceEnd {get; set;}
[Element("modifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Modifier {get; set;}
[Element("patientPaid", typeof(Money), false, false, false, false)]
public Money PatientPaid {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("unitPrice", typeof(Money), false, false, false, false)]
public Money UnitPrice {get; set;}
[Element("factor", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Factor {get; set;}
[Element("tax", typeof(Money), false, false, false, false)]
public Money Tax {get; set;}
[Element("net", typeof(Money), false, false, false, false)]
public Money Net {get; set;}
[Element("noteNumber", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> NoteNumber {get; set;}

        #endregion
        #region Constructor
        public  SubDetail() { }
        public  SubDetail(string value) : base(value) { }
        public  SubDetail(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SubDetail";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
