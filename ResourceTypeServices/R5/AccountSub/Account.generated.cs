

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AccountSub
{
    public class Account : DomainResource<Account>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
        public IEnumerable<Identifier> Identifier { get; set; }
        [Element("status", typeof(FhirCode), true, false, false, false)]
        public FhirCode Status { get; set; }
        [Element("billingStatus", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept BillingStatus { get; set; }
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept Type { get; set; }
        [Element("name", typeof(FhirString), true, false, false, false)]
        public FhirString Name { get; set; }
        [Element("subject", typeof(Reference), false, true, false, false)]
        public IEnumerable<Reference> Subject { get; set; }
        [Element("servicePeriod", typeof(Period), false, false, false, false)]
        public Period ServicePeriod { get; set; }
        [Element("coverage", typeof(Coverage), false, true, false, true)]
        public IEnumerable<Coverage> Coverage { get; set; }
        [Element("owner", typeof(Reference), false, false, false, false)]
        public Reference Owner { get; set; }
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
        public FhirMarkdown Description { get; set; }
        [Element("guarantor", typeof(Guarantor), false, true, false, true)]
        public IEnumerable<Guarantor> Guarantor { get; set; }
        [Element("diagnosis", typeof(Diagnosis), false, true, false, true)]
        public IEnumerable<Diagnosis> Diagnosis { get; set; }
        [Element("procedure", typeof(Procedure), false, true, false, true)]
        public IEnumerable<Procedure> Procedure { get; set; }
        [Element("relatedAccount", typeof(RelatedAccount), false, true, false, true)]
        public IEnumerable<RelatedAccount> RelatedAccount { get; set; }
        [Element("currency", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept Currency { get; set; }
        [Element("balance", typeof(Balance), false, true, false, true)]
        public IEnumerable<Balance> Balance { get; set; }
        [Element("calculatedAt", typeof(FhirInstant), true, false, false, false)]
        public FhirInstant CalculatedAt { get; set; }

        #endregion
        #region Constructor
        public Account() { }

        public Account(string value) : base(value) { }
        public Account(JsonNode source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Account";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
