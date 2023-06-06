

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ContractSub
{
    public class Contract : DomainResource<Contract>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("legalState", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept LegalState {get; set;}
[Element("instantiatesCanonical", typeof(Reference), false, false, false, false)]
public Reference InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, false, false, false)]
public FhirUri InstantiatesUri {get; set;}
[Element("contentDerivative", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ContentDerivative {get; set;}
[Element("issued", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Issued {get; set;}
[Element("applies", typeof(Period), false, false, false, false)]
public Period Applies {get; set;}
[Element("expirationType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ExpirationType {get; set;}
[Element("subject", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Subject {get; set;}
[Element("authority", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Authority {get; set;}
[Element("domain", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Domain {get; set;}
[Element("site", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Site {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("subtitle", typeof(FhirString), true, false, false, false)]
public FhirString Subtitle {get; set;}
[Element("alias", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Alias {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("scope", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Scope {get; set;}
[Element("topic", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Topic {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SubType {get; set;}
[Element("contentDefinition", typeof(ContentDefinition), false, false, false, true)]
public ContentDefinition ContentDefinition {get; set;}
[Element("term", typeof(Term), false, true, false, true)]
public IEnumerable<Term> Term {get; set;}
[Element("supportingInfo", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInfo {get; set;}
[Element("relevantHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> RelevantHistory {get; set;}
[Element("signer", typeof(Signer), false, true, false, true)]
public IEnumerable<Signer> Signer {get; set;}
[Element("friendly", typeof(Friendly), false, true, false, true)]
public IEnumerable<Friendly> Friendly {get; set;}
[Element("legal", typeof(Legal), false, true, false, true)]
public IEnumerable<Legal> Legal {get; set;}
[Element("rule", typeof(Rule), false, true, false, true)]
public IEnumerable<Rule> Rule {get; set;}
[Element("legallyBinding", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased LegallyBinding {get; set;}

        #endregion
        #region Constructor
        public  Contract() { }

        public  Contract(string value) : base(value) { }
        public  Contract(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Contract";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
