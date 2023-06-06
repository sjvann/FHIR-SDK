

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InvoiceSub
{
    public class Invoice : DomainResource<Invoice>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("cancelledReason", typeof(FhirString), true, false, false, false)]
public FhirString CancelledReason {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("recipient", typeof(Reference), false, false, false, false)]
public Reference Recipient {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("creation", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Creation {get; set;}
[Element("period", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Period {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("issuer", typeof(Reference), false, false, false, false)]
public Reference Issuer {get; set;}
[Element("account", typeof(Reference), false, false, false, false)]
public Reference Account {get; set;}
[Element("lineItem", typeof(LineItem), false, true, false, true)]
public IEnumerable<LineItem> LineItem {get; set;}
[Element("totalPriceComponent", typeof(MonetaryComponent), false, true, false, false)]
public IEnumerable<MonetaryComponent> TotalPriceComponent {get; set;}
[Element("totalNet", typeof(Money), false, false, false, false)]
public Money TotalNet {get; set;}
[Element("totalGross", typeof(Money), false, false, false, false)]
public Money TotalGross {get; set;}
[Element("paymentTerms", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown PaymentTerms {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Invoice() { }

        public  Invoice(string value) : base(value) { }
        public  Invoice(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Invoice";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
