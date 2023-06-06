

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PaymentReconciliationSub
{
    public class PaymentReconciliation : DomainResource<PaymentReconciliation>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("kind", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Kind {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("enterer", typeof(Reference), false, false, false, false)]
public Reference Enterer {get; set;}
[Element("issuerType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept IssuerType {get; set;}
[Element("paymentIssuer", typeof(Reference), false, false, false, false)]
public Reference PaymentIssuer {get; set;}
[Element("request", typeof(Reference), false, false, false, false)]
public Reference Request {get; set;}
[Element("requestor", typeof(Reference), false, false, false, false)]
public Reference Requestor {get; set;}
[Element("outcome", typeof(FhirCode), true, false, false, false)]
public FhirCode Outcome {get; set;}
[Element("disposition", typeof(FhirString), true, false, false, false)]
public FhirString Disposition {get; set;}
[Element("date", typeof(FhirDate), true, false, false, false)]
public FhirDate Date {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("method", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Method {get; set;}
[Element("cardBrand", typeof(FhirString), true, false, false, false)]
public FhirString CardBrand {get; set;}
[Element("accountNumber", typeof(FhirString), true, false, false, false)]
public FhirString AccountNumber {get; set;}
[Element("expirationDate", typeof(FhirDate), true, false, false, false)]
public FhirDate ExpirationDate {get; set;}
[Element("processor", typeof(FhirString), true, false, false, false)]
public FhirString Processor {get; set;}
[Element("referenceNumber", typeof(FhirString), true, false, false, false)]
public FhirString ReferenceNumber {get; set;}
[Element("authorization", typeof(FhirString), true, false, false, false)]
public FhirString Authorization {get; set;}
[Element("tenderedAmount", typeof(Money), false, false, false, false)]
public Money TenderedAmount {get; set;}
[Element("returnedAmount", typeof(Money), false, false, false, false)]
public Money ReturnedAmount {get; set;}
[Element("amount", typeof(Money), false, false, false, false)]
public Money Amount {get; set;}
[Element("paymentIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier PaymentIdentifier {get; set;}
[Element("allocation", typeof(Allocation), false, true, false, true)]
public IEnumerable<Allocation> Allocation {get; set;}
[Element("formCode", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FormCode {get; set;}
[Element("processNote", typeof(ProcessNote), false, true, false, true)]
public IEnumerable<ProcessNote> ProcessNote {get; set;}

        #endregion
        #region Constructor
        public  PaymentReconciliation() { }

        public  PaymentReconciliation(string value) : base(value) { }
        public  PaymentReconciliation(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "PaymentReconciliation";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
