

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CoverageSub
{
    public class Coverage : DomainResource<Coverage>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("kind", typeof(FhirCode), true, false, false, false)]
public FhirCode Kind {get; set;}
[Element("paymentBy", typeof(PaymentBy), false, true, false, true)]
public IEnumerable<PaymentBy> PaymentBy {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("policyHolder", typeof(Reference), false, false, false, false)]
public Reference PolicyHolder {get; set;}
[Element("subscriber", typeof(Reference), false, false, false, false)]
public Reference Subscriber {get; set;}
[Element("subscriberId", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> SubscriberId {get; set;}
[Element("beneficiary", typeof(Reference), false, false, false, false)]
public Reference Beneficiary {get; set;}
[Element("dependent", typeof(FhirString), true, false, false, false)]
public FhirString Dependent {get; set;}
[Element("relationship", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Relationship {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("insurer", typeof(Reference), false, false, false, false)]
public Reference Insurer {get; set;}
[Element("class", typeof(Class), false, true, false, true)]
public IEnumerable<Class> Class {get; set;}
[Element("order", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Order {get; set;}
[Element("network", typeof(FhirString), true, false, false, false)]
public FhirString Network {get; set;}
[Element("costToBeneficiary", typeof(CostToBeneficiary), false, true, false, true)]
public IEnumerable<CostToBeneficiary> CostToBeneficiary {get; set;}
[Element("subrogation", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Subrogation {get; set;}
[Element("contract", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Contract {get; set;}
[Element("insurancePlan", typeof(Reference), false, false, false, false)]
public Reference InsurancePlan {get; set;}

        #endregion
        #region Constructor
        public  Coverage() { }

        public  Coverage(string value) : base(value) { }
        public  Coverage(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Coverage";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
