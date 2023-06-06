

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub
{
    public class TerminologyCapabilities : DomainResource<TerminologyCapabilities>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("versionAlgorithm", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased VersionAlgorithm {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("publisher", typeof(FhirString), true, false, false, false)]
public FhirString Publisher {get; set;}
[Element("contact", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Contact {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("jurisdiction", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Jurisdiction {get; set;}
[Element("purpose", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Purpose {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}
[Element("copyrightLabel", typeof(FhirString), true, false, false, false)]
public FhirString CopyrightLabel {get; set;}
[Element("kind", typeof(FhirCode), true, false, false, false)]
public FhirCode Kind {get; set;}
[Element("software", typeof(Software), false, false, false, true)]
public Software Software {get; set;}
[Element("implementation", typeof(Implementation), false, false, false, true)]
public Implementation Implementation {get; set;}
[Element("lockedDate", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean LockedDate {get; set;}
[Element("codeSystem", typeof(CodeSystem), false, true, false, true)]
public IEnumerable<CodeSystem> CodeSystem {get; set;}
[Element("expansion", typeof(Expansion), false, false, false, true)]
public Expansion Expansion {get; set;}
[Element("codeSearch", typeof(FhirCode), true, false, false, false)]
public FhirCode CodeSearch {get; set;}
[Element("validateCode", typeof(ValidateCode), false, false, false, true)]
public ValidateCode ValidateCode {get; set;}
[Element("translation", typeof(Translation), false, false, false, true)]
public Translation Translation {get; set;}
[Element("closure", typeof(Closure), false, false, false, true)]
public Closure Closure {get; set;}

        #endregion
        #region Constructor
        public  TerminologyCapabilities() { }

        public  TerminologyCapabilities(string value) : base(value) { }
        public  TerminologyCapabilities(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "TerminologyCapabilities";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
