
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ExplanationOfBenefitSub.AddItemSub;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class AddItem : BackboneElement<AddItem>
    {

        #region Property
        [Element("itemSequence", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> ItemSequence {get; set;}
[Element("detailSequence", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> DetailSequence {get; set;}
[Element("subDetailSequence", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> SubDetailSequence {get; set;}
[Element("traceNumber", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> TraceNumber {get; set;}
[Element("provider", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Provider {get; set;}
[Element("revenue", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Revenue {get; set;}
[Element("productOrService", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProductOrService {get; set;}
[Element("productOrServiceEnd", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProductOrServiceEnd {get; set;}
[Element("request", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Request {get; set;}
[Element("modifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Modifier {get; set;}
[Element("programCode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ProgramCode {get; set;}
[Element("serviced", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Serviced {get; set;}
[Element("location", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Location {get; set;}
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
[Element("bodySite", typeof(BodySite), false, true, false, true)]
public IEnumerable<BodySite> BodySite {get; set;}
[Element("noteNumber", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> NoteNumber {get; set;}
[Element("detail", typeof(Detail), false, true, false, true)]
public IEnumerable<Detail> Detail {get; set;}

        #endregion
        #region Constructor
        public  AddItem() { }
        public  AddItem(string value) : base(value) { }
        public  AddItem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "AddItem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
