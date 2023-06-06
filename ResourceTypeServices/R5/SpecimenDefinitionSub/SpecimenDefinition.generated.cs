

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SpecimenDefinitionSub
{
    public class SpecimenDefinition : DomainResource<SpecimenDefinition>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("versionAlgorithm", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased VersionAlgorithm {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("derivedFromCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> DerivedFromCanonical {get; set;}
[Element("derivedFromUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> DerivedFromUri {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
[Element("subject", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Subject {get; set;}
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
[Element("approvalDate", typeof(FhirDate), true, false, false, false)]
public FhirDate ApprovalDate {get; set;}
[Element("lastReviewDate", typeof(FhirDate), true, false, false, false)]
public FhirDate LastReviewDate {get; set;}
[Element("effectivePeriod", typeof(Period), false, false, false, false)]
public Period EffectivePeriod {get; set;}
[Element("typeCollected", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept TypeCollected {get; set;}
[Element("patientPreparation", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> PatientPreparation {get; set;}
[Element("timeAspect", typeof(FhirString), true, false, false, false)]
public FhirString TimeAspect {get; set;}
[Element("collection", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Collection {get; set;}
[Element("typeTested", typeof(TypeTested), false, true, false, true)]
public IEnumerable<TypeTested> TypeTested {get; set;}

        #endregion
        #region Constructor
        public  SpecimenDefinition() { }

        public  SpecimenDefinition(string value) : base(value) { }
        public  SpecimenDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SpecimenDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
