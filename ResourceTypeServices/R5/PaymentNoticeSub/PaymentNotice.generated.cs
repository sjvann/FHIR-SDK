

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PaymentNoticeSub
{
    public class PaymentNotice : DomainResource<PaymentNotice>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("request", typeof(Reference), false, false, false, false)]
public Reference Request {get; set;}
[Element("response", typeof(Reference), false, false, false, false)]
public Reference Response {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("reporter", typeof(Reference), false, false, false, false)]
public Reference Reporter {get; set;}
[Element("payment", typeof(Reference), false, false, false, false)]
public Reference Payment {get; set;}
[Element("paymentDate", typeof(FhirDate), true, false, false, false)]
public FhirDate PaymentDate {get; set;}
[Element("payee", typeof(Reference), false, false, false, false)]
public Reference Payee {get; set;}
[Element("recipient", typeof(Reference), false, false, false, false)]
public Reference Recipient {get; set;}
[Element("amount", typeof(Money), false, false, false, false)]
public Money Amount {get; set;}
[Element("paymentStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PaymentStatus {get; set;}

        #endregion
        #region Constructor
        public  PaymentNotice() { }

        public  PaymentNotice(string value) : base(value) { }
        public  PaymentNotice(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "PaymentNotice";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
